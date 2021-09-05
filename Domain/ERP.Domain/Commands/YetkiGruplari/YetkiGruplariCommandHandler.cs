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

namespace ERP.Domain.Commands.YetkiGruplari
{

    public class YetkiGruplariCommandHandler : BaseCommandHandler,
       IRequestHandler<YetkiGruplariEkleCommand, yetkiGruplari>,
       IRequestHandler<YetkiGruplariGuncelleCommand, yetkiGruplari>,
       IRequestHandler<YetkiGruplariSilCommand, bool>

    {

        public IYetkiGruplariRepository _yetkiGuruplariRepository;


        public YetkiGruplariCommandHandler(IUnitOfWork unitOfWork,
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notificationHandler,
            IYetkiGruplariRepository yetkiGuruplariRepository
           ) : base(unitOfWork, mediator, notificationHandler)
        {
            _yetkiGuruplariRepository = yetkiGuruplariRepository;

        }


        public async Task<bool> Handle(YetkiGruplariSilCommand request, CancellationToken cancellationToken)
        {
            var yetkiGruplari = await _yetkiGuruplariRepository.GetFirstOrDefaultAsync(q => q.id == request.yetkiGruplariId);
            //var validationResult = RuleManager.Instance.ValidateYetkiGrupGuncelle(_yetkiGuruplariRepository, yetkiGruplari);
            //if (!validationResult.Success)
            //{
            //    await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
            //    return null;
            //}
            yetkiGruplari.silindimi = true;
            await _yetkiGuruplariRepository.UpdateAsync(yetkiGruplari);

            if (await Commit())
            {
                return true;
            }

            return false;

        }

        public async Task<yetkiGruplari> Handle(YetkiGruplariGuncelleCommand request, CancellationToken cancellationToken)
        {
            var yetkiGruplari = request.yetkiGruplari;
            var validationResult = RuleManager.Instance.ValidateYetkiGrupGuncelle(_yetkiGuruplariRepository, yetkiGruplari);
            if (!validationResult.Success)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
                return null;
            }
            await _yetkiGuruplariRepository.UpdateAsync(yetkiGruplari);

            if (await Commit())
            {
                //await _mediator.SendEvent(new EklendiEvent<Departman>(departman));
            }

            return yetkiGruplari;
        }

        public async Task<yetkiGruplari> Handle(YetkiGruplariEkleCommand request, CancellationToken cancellationToken)
        {
            var yetkiGruplari = request.yetkiGruplari;
            
            var validationResult = RuleManager.Instance.ValidateYetkiGrupEkle(_yetkiGuruplariRepository, yetkiGruplari);
            if (!validationResult.Success)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
                return null;
            }
            await _yetkiGuruplariRepository.AddAsync(yetkiGruplari);

            if (await Commit())
            {
                //await _mediator.SendEvent(new EklendiEvent<Departman>(departman));
            }

            return yetkiGruplari;
        }
    }
}
