using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.OgrenimDurum
{
    public class OgrenimDurumQueryHandler : BaseQueryHandler, IRequestHandler<OgrenimDurumListeleQuery, List<ogrenimDurum>>
    {
        private readonly IOgrenimDurumRepository _ogrenimDurumRepository;

        public OgrenimDurumQueryHandler(
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            IOgrenimDurumRepository ogrenimDurumRepository) : base(mediator, notifications)
        {
            _ogrenimDurumRepository = ogrenimDurumRepository;
        }

        public async Task<List<Data.Entities.ogrenimDurum>> Handle(OgrenimDurumListeleQuery request, CancellationToken cancellationToken)
        {
            return await _ogrenimDurumRepository.GetAsync();
        }
    }
}
