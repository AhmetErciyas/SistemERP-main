using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.SozlesmeTur
{
    
    public class SozlesmeTurQueryHandler : BaseQueryHandler, IRequestHandler<SozlesmeTurListeleQuery, List<sozlesmeTur>>
    {
        private readonly ISozlesmeTurRepository _sozlesmeTurRepository;

        public SozlesmeTurQueryHandler(
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            ISozlesmeTurRepository sozlesmeTurRepository) : base(mediator, notifications)
        {
            _sozlesmeTurRepository = sozlesmeTurRepository;
        }

        public async Task<List<Data.Entities.sozlesmeTur>> Handle(SozlesmeTurListeleQuery request, CancellationToken cancellationToken)
        {
            return await _sozlesmeTurRepository.GetAsync();
        }
    }
}
