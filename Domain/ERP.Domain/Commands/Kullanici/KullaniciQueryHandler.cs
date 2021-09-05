using ERP.Data.DAO.Kullanici;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.Kullanici
{
    public class KullaniciQueryHandler : BaseQueryHandler,
            IRequestHandler<KullaniciGetirQuery, KullaniciDAO>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IKullaniciRepository _kullaniciRepository;

        public KullaniciQueryHandler(IMediatorHandler mediator,
                                        INotificationHandler<DomainNotification> notifications,
                                        IHttpContextAccessor httpContextAccessor,
                                        IKullaniciRepository kullaniciRepository) : base(mediator, notifications)
        {
            _httpContextAccessor = httpContextAccessor;
            _kullaniciRepository = kullaniciRepository;
        }

        public async Task<KullaniciDAO> Handle(KullaniciGetirQuery request, CancellationToken cancellationToken)
        {
            return await _kullaniciRepository.GetKullanici(request.KullaniciId);
        }
    }
}
