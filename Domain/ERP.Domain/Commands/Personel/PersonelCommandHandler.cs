using ERP.Data;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using ERP.Domain.RuleEngine;
using ERP.Domain.ServiceClient.MAIL;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands
{
    public class PersonelCommandHandler : BaseCommandHandler,
        IRequestHandler<PersonelEkleCommand, ERP.Data.Entities.personel>,
        IRequestHandler<PersonelGuncelleCommand, ERP.Data.Entities.personel>,
        IRequestHandler<PersonelSilCommand, bool>
    {

        public IPersonelRepository _personelRepository;
        public IKisiRepository _kisiRepository;
        public IMailServiceClient _mailServiceClient;


        public PersonelCommandHandler(IUnitOfWork unitOfWork,
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notificationHandler,
            IPersonelRepository personelRepository,
            IMailServiceClient mailServiceClient,
            IKisiRepository kisiRepository) : base(unitOfWork, mediator, notificationHandler)
        {
            _personelRepository = personelRepository;
            _kisiRepository = kisiRepository;
            _mailServiceClient = mailServiceClient;
        }

        public async Task<Data.Entities.personel> Handle(PersonelEkleCommand request, CancellationToken cancellationToken)
        {
            var personel = request.Personel;

            var validationResult = RuleManager.Instance.ValidatePersonelEkle(_personelRepository, _kisiRepository, personel);
            if (!validationResult.Success)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
                return null;
            }

            await _personelRepository.AddAsync(personel);

            if (await Commit())
            {
                return personel;
            }

            return null;
        }

        public async Task<Data.Entities.personel> Handle(PersonelGuncelleCommand request, CancellationToken cancellationToken)
        {
            var personel = request.Personel;


            var validationResult = RuleManager.Instance.ValidatePersonelGuncelle(_personelRepository, _kisiRepository, personel);
            if (!validationResult.Success)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
                return null;
            }
            /*
             * Tc değişmişse Nvi sorgula ve doğrula
             * Mail gönderecek
                   await _mailServiceClient.MailGonder(new MailRequestModel() { Subject = "Mail başlığı" });
             * SMS gönderecek
             */

            await _personelRepository.Update(personel);


                if (await Commit())
                {
                    return personel;
                }

            return null;
        }

        public async Task<bool> Handle(PersonelSilCommand request, CancellationToken cancellationToken)
        {
            var personel = await _personelRepository.GetFirstOrDefaultAsyncWithIncludes(q => q.id == request.PersonelId, q => q.OrderByDescending(q => q.id), "digerBilgiler", "ekGelirGider", "kullanici", "personelAgi", "personelBankaHesap", "personelDepartman", "personelEmeklilik", "personelKimlik", "personelMaas", "personelTabiKanun");

            //TODO : Silme işlemi için nrule eklenmeli
            //var validationResult = RuleManager.Instance.ValidatePersonelEkle(_personelRepository, _kisiRepository, personel);
            //if (!validationResult.Success)
            //{
            //    await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
            //    return false;
            //}
            personel.silindimi = true;
            personel.personelAgi.silindimi = true;
            personel.personelEmeklilik.silindimi = true;
            personel.personelKimlik.silindimi = true;
            personel.personelTabiKanun.silindimi = true;
            personel.personelMaas.silindimi = true;
            personel.digerBilgiler.silindimi = true;
            personel.personelBankaHesap.silindimi = true;
            if (personel.ekGelirGider.Any())
                personel.ekGelirGider.ToList().ForEach(q => { q.silindimi = true; });
            if (personel.personelDepartman.Any())
                personel.personelDepartman.ToList().ForEach(q => { q.silindimi = true; });


            await _personelRepository.Update(personel);

            if (await Commit())
            {
                return true;
            }

            return false;
        }
    }
}
