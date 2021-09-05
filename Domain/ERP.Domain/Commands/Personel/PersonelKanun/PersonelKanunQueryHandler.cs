using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.PersonelKanun
{
   public class PersonelKanunQueryHandler : BaseQueryHandler,
        IRequestHandler<PersonelKanuListeleQuery, List<personelKanun>>
    {
        private readonly IPersonelKanunRepository _personelKanunRepository;

        public PersonelKanunQueryHandler(
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            IPersonelKanunRepository personelKanunRepository) : base(mediator, notifications)
        {
            _personelKanunRepository = personelKanunRepository;
        }

        public async Task<List<Data.Entities.personelKanun>> Handle(PersonelKanuListeleQuery request, CancellationToken cancellationToken)
        {
            return await _personelKanunRepository.GetAsync(x=>x.silindimi==false);
        }
    }
}
