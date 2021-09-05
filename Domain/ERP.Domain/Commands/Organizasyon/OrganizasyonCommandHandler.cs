using ERP.Data;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.Organizasyon
{
    public class OrganizasyonCommandHandler : BaseCommandHandler,
       IRequestHandler<DepartmanEkleCommand, departman>,
       IRequestHandler<DepartmanGuncelleCommand, departman>,
       IRequestHandler<DepartmanSilCommand, bool>,
       IRequestHandler<UnvanEkleCommand, unvan>,
       IRequestHandler<UnvanGuncelleCommand, unvan>,
       IRequestHandler<UnvanSilCommand, bool>,
       IRequestHandler<KademeEkleCommand, kademe>,
       IRequestHandler<KademeGuncelleCommand, kademe>,
       IRequestHandler<KademeSilCommand, bool>
    {

        public IDepartmanRepository _departmanRepository;
        public IUnvanRepository _unvanRepository;
        public IKademeRepository _kademeRepository;

        public OrganizasyonCommandHandler(IUnitOfWork unitOfWork,
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notificationHandler,
            IDepartmanRepository departmanRepository,
            IUnvanRepository unvanRepository,
            IKademeRepository kademeRepository) : base(unitOfWork, mediator, notificationHandler)
        {
            _departmanRepository = departmanRepository;
            _unvanRepository = unvanRepository;
            _kademeRepository = kademeRepository;
        }

        #region Departman
        public async Task<departman> Handle(DepartmanEkleCommand request, CancellationToken cancellationToken)
        {
            var departman = request.departman;

            await _departmanRepository.AddAsync(departman);

            if (await Commit())
            {
                //await _mediator.SendEvent(new EklendiEvent<Departman>(departman));
            }

            return departman;
        }

        public async Task<departman> Handle(DepartmanGuncelleCommand request, CancellationToken cancellationToken)
        {
            var departman = request.Departman;

            await _departmanRepository.UpdateAsync(departman);

            if (await Commit())
            {
                //await _mediator.SendEvent(new EklendiEvent<Departman>(departman));
            }

            return departman;
        }

        public async Task<bool> Handle(DepartmanSilCommand request, CancellationToken cancellationToken)
        {
            await _departmanRepository.DeleteAsync(request.DepartmanId);

            if (await Commit())
            {
                //await _mediator.SendEvent(new SilindiEvent<short>(request.DepartmanId));
            }

            return await Task.FromResult(true);
        }
        #endregion

        #region Ünvan
        public async Task<unvan> Handle(UnvanEkleCommand request, CancellationToken cancellationToken)
        {
            var unvan = request.Unvan;

            await _unvanRepository.AddAsync(unvan);

            if (await Commit())
            {
                //await _mediator.SendEvent(new EklendiEvent<Unvan>(unvan));
            }

            return unvan;
        }

        public async Task<unvan> Handle(UnvanGuncelleCommand request, CancellationToken cancellationToken)
        {
            var unvan = request.Unvan;

            await _unvanRepository.UpdateAsync(unvan);

            if (await Commit())
            {
                //await _mediator.SendEvent(new EklendiEvent<Unvan>(unvan));
            }

            return unvan;
        }

        public async Task<bool> Handle(UnvanSilCommand request, CancellationToken cancellationToken)
        {
            await _unvanRepository.DeleteAsync(request.UnvanId);

            if (await Commit())
            {
                //await _mediator.SendEvent(new SilindiEvent<short>(request.UnvanId));
            }

            return await Task.FromResult(true);
        }
        #endregion

        #region Kademe
        public async Task<kademe> Handle(KademeEkleCommand request, CancellationToken cancellationToken)
        {
            var kademe = request.Kademe;

            await _kademeRepository.AddAsync(kademe);

            if (await Commit())
            {
                //await _mediator.SendEvent(new EklendiEvent<Kademe>(kademe));
            }

            return kademe;
        }

        public async Task<kademe> Handle(KademeGuncelleCommand request, CancellationToken cancellationToken)
        {
            var kademe = request.Kademe;

            await _kademeRepository.UpdateAsync(kademe);

            if (await Commit())
            {
                //await _mediator.SendEvent(new EklendiEvent<Kademe>(kademe));
            }

            return kademe;
        }

        public async Task<bool> Handle(KademeSilCommand request, CancellationToken cancellationToken)
        {
            await _kademeRepository.DeleteAsync(request.KademeId);

            if (await Commit())
            {
                //await _mediator.SendEvent(new SilindiEvent<short>(request.KademeId));
            }

            return await Task.FromResult(true);
        }
        #endregion
    }
}
