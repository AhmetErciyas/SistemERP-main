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

namespace ERP.Domain.Commands.KullaniciYetkileri
{
   
    public class KullaniciYetkileriCommandHandler : BaseCommandHandler,
       IRequestHandler<KullaniciYetkileriEkleCommand, kullaniciYetkileri>,
       IRequestHandler<KullaniciYetkileriGuncelleCommand, kullaniciYetkileri>,
       IRequestHandler<KullaniciYetkileriSilCommand, bool>
      
    {

        public IKullaniciYetkileriRepository _kullaniciYetkilerRepository;
        public IKullaniciRepository _kullaniciRepository;
        public IYetkilerRepository _yetkilerRepository;


        public KullaniciYetkileriCommandHandler(IUnitOfWork unitOfWork,
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notificationHandler,
            IKullaniciYetkileriRepository kullaniciYetkilerRepository,
            IKullaniciRepository kullaniciRepository,
            IYetkilerRepository yetkilerRepository
           ) : base(unitOfWork, mediator, notificationHandler)
        {
            _kullaniciYetkilerRepository = kullaniciYetkilerRepository;
            _kullaniciRepository = kullaniciRepository;
            _yetkilerRepository = yetkilerRepository;

           
        }
        public async  Task<kullaniciYetkileri> Handle(KullaniciYetkileriEkleCommand request, CancellationToken cancellationToken)
        {
            var kullaniciYetkileri = request.kullaniciYetkileri;
            var validationResult = RuleManager.Instance.ValidateKullanıcıYetkileriEkle(_kullaniciYetkilerRepository,_yetkilerRepository,_kullaniciRepository,kullaniciYetkileri);
            if (!validationResult.Success)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
                return null;
            }
            await _kullaniciYetkilerRepository.AddAsync(kullaniciYetkileri);

            if (await Commit())
            {
                //await _mediator.SendEvent(new EklendiEvent<Departman>(departman));
            }

            return kullaniciYetkileri;
        }

        public async Task<kullaniciYetkileri> Handle(KullaniciYetkileriGuncelleCommand request, CancellationToken cancellationToken)
        {
            var kullaniciYetkileri = request.kullaniciYetkileri;
            var validationResult = RuleManager.Instance.ValidateKullanıcıYetkileriGuncelle(_kullaniciYetkilerRepository, _yetkilerRepository, _kullaniciRepository, kullaniciYetkileri);
            if (!validationResult.Success)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
                return null;
            }
            await _kullaniciYetkilerRepository.UpdateAsync(kullaniciYetkileri);

            if (await Commit())
            {
                //await _mediator.SendEvent(new EklendiEvent<Departman>(departman));
            }

            return kullaniciYetkileri;
        }

        public async Task<bool> Handle(KullaniciYetkileriSilCommand request, CancellationToken cancellationToken)
        {
            var kullaniciYetkileri = await _kullaniciYetkilerRepository.GetFirstOrDefaultAsync(q => q.id == request.kullaniciYetkileriId);
            //var validationResult = RuleManager.Instance.ValidateKullanıcıYetkileriGuncelle(_kullaniciYetkilerRepository, _yetkilerRepository, _kullaniciRepository, kullaniciYetkileri);
            //if (!validationResult.Success)
            //{
            //    await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
            //    return fa;
            //}
            kullaniciYetkileri.silindimi = true;
            await _kullaniciYetkilerRepository.UpdateAsync(kullaniciYetkileri);

            if (await Commit())
            {
                return true;
            }

            return false;

        }
    }
}
