using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.SigortaTur
{
    public class SigortaTurQueryHandler:BaseQueryHandler, IRequestHandler<SigortaTurListeleQuery, List<sigortaTur>>
    {
        private readonly ISigortaTurRepository _sigortaTurRepository;

        public SigortaTurQueryHandler(
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            ISigortaTurRepository sigortaTurRepository) : base(mediator, notifications)
        {
            _sigortaTurRepository = sigortaTurRepository;
        }

        public async Task<List<Data.Entities.sigortaTur>> Handle(SigortaTurListeleQuery request, CancellationToken cancellationToken)
        {
            return await _sigortaTurRepository.GetAsync();
        }
    }
}
