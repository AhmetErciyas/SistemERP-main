using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.YetkiGruplari
{
    public class YetkiGruplariQueryHandler : BaseQueryHandler, IRequestHandler<YetkiGruplariListeleQuery, List<yetkiGruplari>>
    {
        private readonly IYetkiGruplariRepository _yetkiGuruplariRepository;

        public YetkiGruplariQueryHandler(
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            IYetkiGruplariRepository yetkiGuruplariRepository) : base(mediator, notifications)
        {
            _yetkiGuruplariRepository = yetkiGuruplariRepository;
        }

        public async Task<List<Data.Entities.yetkiGruplari>> Handle(YetkiGruplariListeleQuery request, CancellationToken cancellationToken)
        {
            //return await _yetkiGuruplariRepository.GetAsync();
            return await _yetkiGuruplariRepository.GetAsyncWithIncludes(q => true, q => q.OrderByDescending(q => q.id), "yetkiGruplariDetay");

        }
    }
}

