using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.EngellilikDurum
{
    public class EngellilikDurumQueryHandler : BaseQueryHandler,
        IRequestHandler<EngellilikDurumListeleQuery, List<Data.Entities.engellilikDurum>>
    {
        private readonly IEngellilikDurumRepository _engellikDurumRepository;

        public EngellilikDurumQueryHandler(
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            IEngellilikDurumRepository engellikDurumRepository) : base(mediator, notifications)
        {
            _engellikDurumRepository = engellikDurumRepository;
        }

        public async Task<List<Data.Entities.engellilikDurum>> Handle(EngellilikDurumListeleQuery request, CancellationToken cancellationToken)
        {
            return await _engellikDurumRepository.GetAsync();
        }
    }
}
