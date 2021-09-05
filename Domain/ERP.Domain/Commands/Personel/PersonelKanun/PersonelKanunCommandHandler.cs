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

namespace ERP.Domain.Commands.PersonelKanun
{
    public class PersonelKanunCommandHandler : BaseCommandHandler,
      IRequestHandler<PersonelKanunEKleCommand, personelKanun>,
      IRequestHandler<PersonelKanunGuncelleCommand, personelKanun>,
      IRequestHandler<PersonelKanunSilCommand, bool>
    {

        private readonly IPersonelKanunRepository _personelKanunRepository;

        public PersonelKanunCommandHandler(IUnitOfWork unitOfWork,
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notificationHandler,
            IPersonelKanunRepository personelKanunRepository) : base(unitOfWork, mediator, notificationHandler)
        {

            _personelKanunRepository = personelKanunRepository;
        }
        public async Task<personelKanun> Handle(PersonelKanunEKleCommand request, CancellationToken cancellationToken)
        {
            var personelKanun = request.personelKanun;
            await _personelKanunRepository.AddAsync(personelKanun);

            if (await Commit())
            {
                //await _mediator.SendEvent(new EklendiEvent<Kademe>(kademe));
            }

            return personelKanun;
        }

        public async Task<personelKanun> Handle(PersonelKanunGuncelleCommand request, CancellationToken cancellationToken)
        {
            var personelKanun = request.personelKanun;
            await _personelKanunRepository.UpdateAsync(personelKanun);

            if (await Commit())
            {
                //await _mediator.SendEvent(new EklendiEvent<Kademe>(kademe));
            }

            return personelKanun;
        }

        public async Task<bool> Handle(PersonelKanunSilCommand request, CancellationToken cancellationToken)
        {

            var personelKanun = await _personelKanunRepository.GetFirstOrDefaultAsync(q => q.id == request.personelKanunId);
            //var validationResult = RuleManager.Instance.ValidateIstenAyrılmaNedenGuncelle(_istenAyrilmaNedenleriRepository, istenAyrilmaNedenleri);
            //if (!validationResult.Success)
            //{
            //    await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
            //    return false;
            //}
            personelKanun.silindimi = true;
            await _personelKanunRepository.UpdateAsync(personelKanun);

            if (await Commit())
            {
                return true;
            }

            return false;


        }
    }
}
