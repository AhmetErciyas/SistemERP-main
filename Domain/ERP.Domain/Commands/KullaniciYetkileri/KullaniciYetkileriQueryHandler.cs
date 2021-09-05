using ERP.Data.DAO.KullaniciYetkileri;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.KullaniciYetkileri
{
    public class KullaniciYetkileriQueryHandler : BaseQueryHandler, IRequestHandler<KullaniciYetkileriListeleQuery, List<KullaniciYetkiDAO>>
    {
        private readonly IKullaniciYetkileriRepository _kullaniciYetkilerRepository;

        public KullaniciYetkileriQueryHandler(
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            IKullaniciYetkileriRepository kullaniciYetkilerRepository) : base(mediator, notifications)
        {
            _kullaniciYetkilerRepository = kullaniciYetkilerRepository;
        }

        public async Task<List<KullaniciYetkiDAO>> Handle(KullaniciYetkileriListeleQuery request, CancellationToken cancellationToken)
        {
            return await _kullaniciYetkilerRepository.KullanicalarıGetir();
        }
    }
}

