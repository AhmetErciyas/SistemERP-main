using ERP.Data;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using ERP.Domain.RuleEngine;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.YetkiGruplariDetay
{
    
    public class YetkiGruplariDetayCommandHandler : BaseCommandHandler,
       IRequestHandler<YetkiGruplariDetayEkleCommand, yetkiGruplariDetay>,
       IRequestHandler<YetkiGruplariDetayGuncelleCommand, yetkiGruplariDetay>,
       IRequestHandler<YetkiGruplariDetaySilCommand, bool>

    {

        public IYetkiGruplariDetayRepository _yetkiGuruplariDetayRepository;
        public IYetkilerRepository _yetkilerRepository;
        public IGrupRepository _grupRepository;


        public YetkiGruplariDetayCommandHandler(IUnitOfWork unitOfWork,
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notificationHandler,
            IYetkiGruplariDetayRepository yetkiGuruplariDetayRepository,
            IYetkilerRepository yetkilerRepository,
            IGrupRepository grupRepository

           ) : base(unitOfWork, mediator, notificationHandler)
        {
            _yetkiGuruplariDetayRepository = yetkiGuruplariDetayRepository;
            _yetkilerRepository = yetkilerRepository;
            _grupRepository = grupRepository;

        }

        public async Task<yetkiGruplariDetay> Handle(YetkiGruplariDetayGuncelleCommand request, CancellationToken cancellationToken)
        {
            var yetkiGruplariDetay = request.yetkiGruplariDetay;
            var validationResult = RuleManager.Instance.YetkiGruplariDetayGuncelle(_yetkiGuruplariDetayRepository,_yetkilerRepository,_grupRepository, yetkiGruplariDetay);
            if (!validationResult.Success)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
                return null;
            }
            await _yetkiGuruplariDetayRepository.UpdateAsync(yetkiGruplariDetay);

            if (await Commit())
            {
                //await _mediator.SendEvent(new EklendiEvent<Departman>(departman));
            }

            return yetkiGruplariDetay;
        }

        public async  Task<yetkiGruplariDetay> Handle(YetkiGruplariDetayEkleCommand request, CancellationToken cancellationToken)
        {
            var kullaniciYetkileri = request.yetkiGruplariDetay;
            var validationResult = RuleManager.Instance.ValidateYetkiGrupDetayEkle(_yetkiGuruplariDetayRepository,_yetkilerRepository,_grupRepository, kullaniciYetkileri);
            if (!validationResult.Success)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
                return null;
            }

            await _yetkiGuruplariDetayRepository.AddAsync(kullaniciYetkileri);

            if (await Commit())
            {
                //await _mediator.SendEvent(new EklendiEvent<Departman>(departman));
            }

            return kullaniciYetkileri;
        }

        public async  Task<bool> Handle(YetkiGruplariDetaySilCommand request, CancellationToken cancellationToken)
        {

            var yetkiGruplariDetay = await _yetkiGuruplariDetayRepository.GetFirstOrDefaultAsync(x => x.id == request.yetkiGruplariDetayId);
            //var validationResult = RuleManager.Instance.YetkiGruplariDetaySil(_yetkiGuruplariDetayRepository, yetkiGruplariDetay);
            //if (!validationResult.Success)
            //{
            //    await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
            //    return false;
            //}
            yetkiGruplariDetay.silindimi = true;
            await _yetkiGuruplariDetayRepository.UpdateAsync(yetkiGruplariDetay);

            if (await Commit())
            {
                return true;
            }

            return false;
        }
    }
}
