using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.AskerlikDurum
{
    public class AskerlikDurumQueryHandler: BaseQueryHandler,IRequestHandler<AskerlikDurumListeleQuery, List<askerlikDurum>> 
    {
        private readonly IAskerlikDurumRepository _askerlikDurumRepository;

        public AskerlikDurumQueryHandler(
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            IAskerlikDurumRepository askerlikDurumRepository) : base(mediator, notifications)
        {
                _askerlikDurumRepository = askerlikDurumRepository;
        }

        public async Task<List<Data.Entities.askerlikDurum>> Handle(AskerlikDurumListeleQuery request, CancellationToken cancellationToken)
        {
            return await _askerlikDurumRepository.GetAsync();
        }
    }
}
