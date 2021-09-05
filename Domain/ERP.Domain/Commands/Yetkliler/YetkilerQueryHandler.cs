using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.Yetkliler
{
    public class YetkilerQueryHandler : BaseQueryHandler, IRequestHandler<YetkilerListeleQuery, List<yetkiler>>
    {
        private readonly IYetkilerRepository _yetkilerRepository;

        public YetkilerQueryHandler(
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            IYetkilerRepository yetkilerRepository) : base(mediator, notifications)
        {
            _yetkilerRepository = yetkilerRepository;
        }

        public async Task<List<Data.Entities.yetkiler>> Handle(YetkilerListeleQuery request, CancellationToken cancellationToken)
        {
            return await _yetkilerRepository.GetAsync();
        }
    }
}

