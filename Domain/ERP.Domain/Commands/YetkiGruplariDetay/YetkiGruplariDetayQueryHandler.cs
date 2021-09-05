using ERP.Data.DAO.YetkiGruplariDetay;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Data.Repository;
using ERP.Domain.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.YetkiGruplariDetay
{
    public class YetkiGruplariDetayQueryHandler : BaseQueryHandler, IRequestHandler<YetkiGruplariDetayListeleQuery, List<YetkiGruplariDetayDAO>>
    {
        private readonly IYetkiGruplariDetayRepository _yetkiGruplariDetayRepository;

        public YetkiGruplariDetayQueryHandler(
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            IYetkiGruplariDetayRepository yetkiGruplariDetayRepository) : base(mediator, notifications)
        {
            _yetkiGruplariDetayRepository = yetkiGruplariDetayRepository;
        }

        public async Task<List<YetkiGruplariDetayDAO>> Handle(YetkiGruplariDetayListeleQuery request, CancellationToken cancellationToken)
        {
            return await _yetkiGruplariDetayRepository.YetkiGruplariGetir();
        }

       
    }
}
