using ERP.Data;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using ERP.Domain.RuleEngine;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands
{
    public class FirmaSubeCommandHandler : BaseCommandHandler,
        IRequestHandler<FirmaSubeEkleCommand, ERP.Data.Entities.sube>,
        IRequestHandler<FirmaSubeGuncelleCommand, ERP.Data.Entities.sube>,
        IRequestHandler<FirmaSubeSilCommand, bool>
    {

        public ISubeRepository _firmasubeRepository;

        public FirmaSubeCommandHandler(IUnitOfWork unitOfWork,
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notificationHandler, IKisiRepository kisiRepository,
            ISubeRepository firmasubeRepository) : base(unitOfWork, mediator, notificationHandler)
        {
            _firmasubeRepository = firmasubeRepository;

        }

        public async Task<bool> Handle(FirmaSubeSilCommand request, CancellationToken cancellationToken)
        {
            var firmasube = await _firmasubeRepository.GetFirstOrDefaultAsync(q => q.id == request.FirmaSubeId);

            firmasube.silindimi = true;
            await _firmasubeRepository.UpdateAsync(firmasube);

            if (await Commit())
            {
                return true;
            }

            return false;
        }

        public async Task<sube> Handle(FirmaSubeGuncelleCommand request, CancellationToken cancellationToken)
        {
            var firmasube = request.FirmaSube;
            await _firmasubeRepository.UpdateAsync(request.FirmaSube);

            if (await Commit())
            {
                return await _firmasubeRepository.GetFirstOrDefaultAsync(q => q.id == firmasube.id, null);
            }

            return null;
        }

        public async Task<sube> Handle(FirmaSubeEkleCommand request, CancellationToken cancellationToken)
        {
            var firmasube = request.FirmaSube;

            await _firmasubeRepository.AddAsync(request.FirmaSube);

            if (await Commit())
            {
                return await _firmasubeRepository.GetFirstOrDefaultAsync(q => q.id == firmasube.id, null);
            }

            return null;
        }
    }
}
