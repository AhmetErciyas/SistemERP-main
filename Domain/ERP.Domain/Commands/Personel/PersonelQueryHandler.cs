using ERP.Core.PageSortFilter;
using ERP.Data.DAO.Personel;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.Personel
{
    public class PersonelQueryHandler : BaseQueryHandler,
        IRequestHandler<PersonelQuery, PersonelDAO>,
        IRequestHandler<PersonelAraQuery, List<PersonelDAO>>
    {

        private readonly IPersonelRepository _personelRepository;                                                                                               

        public PersonelQueryHandler(
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            IPersonelRepository personelRepository) : base(mediator, notifications)
        {
            _personelRepository = personelRepository;
        }

        public async Task<PersonelDAO> Handle(PersonelQuery request, CancellationToken cancellationToken)
        {
            //return await _personelRepository.GetFirstOrDefaultAsyncWithIncludes(q => q.id == request.PersonelId, q => q.OrderByDescending(q => q.id), "digerBilgiler", "ekGelirGider", "kullanici", "personelAgi", "personelBankaHesap", "personelDepartman", "personelEmeklilik", "personelKimlik", "personelMaas", "personelTabiKanun");
            return await _personelRepository.PersonelGetir(request.PersonelId);


        }

        public async Task<List<PersonelDAO>> Handle(PersonelAraQuery request, CancellationToken cancellationToken)
        {
            return await _personelRepository.PersonelAra(request.Personel);
        }
    }
}


                                                                                                            