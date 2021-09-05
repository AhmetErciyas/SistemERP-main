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

namespace ERP.Domain.Commands.IstenAyrilmaNedenleri
{
    
    public class IstenAyrilmaNedenleriQueryHandler : BaseQueryHandler, 
        IRequestHandler<IstenAyrilmaNedenleriListeleQuery, List<istenAyrilmaNedenleri>>
    {
        private readonly IIstenAyrilmaNedenleriRepository _istenAyrilmaNedenleriRepository;

        public IstenAyrilmaNedenleriQueryHandler(
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            IIstenAyrilmaNedenleriRepository istenAyrilmaNedenleriRepository) : base(mediator, notifications)
        {
            _istenAyrilmaNedenleriRepository = istenAyrilmaNedenleriRepository;
        }

        public async Task<List<Data.Entities.istenAyrilmaNedenleri>> Handle(IstenAyrilmaNedenleriListeleQuery request, CancellationToken cancellationToken)
        {
            return await _istenAyrilmaNedenleriRepository.GetAsync();
        }
    }
}
