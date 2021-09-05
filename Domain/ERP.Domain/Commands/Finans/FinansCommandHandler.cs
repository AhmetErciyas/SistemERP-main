using ERP.Data;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.Finans
{
    public class FinansCommandHandler : BaseCommandHandler,
        IRequestHandler<FinansFirmaEkleCommand, firma>

    {
        private readonly IFirmaRepository _firmaRepository;

        public FinansCommandHandler(IUnitOfWork unitOfWork,
                                        IMediatorHandler mediator,
                                        INotificationHandler<DomainNotification> notifications,
                                        IFirmaRepository firmaRepository) : base(unitOfWork, mediator, notifications)
        {
            _firmaRepository = firmaRepository;
        }

        public async Task<firma> Handle(FinansFirmaEkleCommand request, CancellationToken cancellationToken)
        {
            /*
             * TODO : nrules rule engine eklenecek
             * */

            var firma = request.Firma;
            await _firmaRepository.AddAsync(firma);

            if (await Commit())
            {
                return firma;
            }

            return null;
        }
    }
}
