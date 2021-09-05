using ERP.Core.PageSortFilter;
using ERP.Data;
using ERP.Data.DAO.FirmaSube;
using ERP.Data.DAO.Organizasyon;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Commands.Base;
using ERP.Domain.Core;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.Organizasyon
{
    public class DepartmanAraQueryHandler : BaseQueryHandler, IRequestHandler<DepartmanAraQuery, List<DepartmanDAO>>
    {
        private readonly IDepartmanRepository _departmanRepository;

        public DepartmanAraQueryHandler(IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications, 
            IDepartmanRepository departmanRepository) : base(mediator, notifications)
        {
            _departmanRepository = departmanRepository;
        }

        public async Task<List<DepartmanDAO>> Handle(DepartmanAraQuery request, CancellationToken cancellationToken)
        {
            return await _departmanRepository.DepartmanAra(request.Departman);

        }

        
    }

    public class UnvanAraQueryHandler : BaseQueryHandler, IRequestHandler<UnvanAraQuery, List<UnvanDAO>>
    {
        private readonly IUnvanRepository _unvanRepository;

        public UnvanAraQueryHandler(IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            IUnvanRepository unvanRepository) : base(mediator, notifications)
        {
            _unvanRepository = unvanRepository;
        }

        public async Task<List<UnvanDAO>> Handle(UnvanAraQuery request, CancellationToken cancellationToken)
        {
            return await _unvanRepository.UnvanAra(request.Unvan);
        }
    }

    public class KademeAraQueryHandler : BaseQueryHandler, IRequestHandler<KademeAraQuery, List<KademeDAO>>
    {
        private readonly IKademeRepository _kademeRepository;

        public KademeAraQueryHandler(IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications, 
            IKademeRepository kademeRepository) : base(mediator, notifications)
        {
            _kademeRepository = kademeRepository;
        }

        public async Task<List<KademeDAO>> Handle(KademeAraQuery request, CancellationToken cancellationToken)
        {
            return await _kademeRepository.KademeAra(request.Kademe);

        }

        
    }
}
