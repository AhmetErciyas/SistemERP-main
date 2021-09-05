using ERP.Core.PageSortFilter;
using ERP.Data.DAO.FirmaSube;
using ERP.Data.DAO.Personel;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.Personel
{
    public class FirmaSubeQueryHandler : BaseQueryHandler,
        IRequestHandler<FirmaSubeQuery, ERP.Data.Entities.sube>,
        IRequestHandler<FirmaSubeAraQuery, PagedResult<FirmaSubeDAO>>
    {

        private readonly ISubeRepository _firmaSubeRepository;

        public FirmaSubeQueryHandler(
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            ISubeRepository firmaSubeRepository) : base(mediator, notifications)
        {
            _firmaSubeRepository = firmaSubeRepository;
        }

        public async Task<Data.Entities.sube> Handle(FirmaSubeQuery request, CancellationToken cancellationToken)
        {
            return await _firmaSubeRepository.GetFirstOrDefaultAsyncWithIncludes(q => q.id == request.firmaSubeId, null);
        }

        public async Task<PagedResult<FirmaSubeDAO>> Handle(FirmaSubeAraQuery request, CancellationToken cancellationToken)
        {
            return await _firmaSubeRepository.FirmaSubeAra(request.FirmaSube);
        }
    }
}
