using ERP.Data;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Data.Repository;
using ERP.Domain.Core;
using ERP.Domain.RuleEngine;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.IstenAyrilmaNedenleri
{
    public class IstenAyrilmaNedenleriCommandHandler : BaseCommandHandler,
      IRequestHandler<IstenAyrilmaNedenleriEkleCommand, istenAyrilmaNedenleri>,
      IRequestHandler<IstenAyrilmaNedenleriGuncelleCommand, istenAyrilmaNedenleri>,
      IRequestHandler<IstenAyrilmaNedenleriSilCommand, bool>
    {
        
        private readonly IIstenAyrilmaNedenleriRepository _istenAyrilmaNedenleriRepository;

        public IstenAyrilmaNedenleriCommandHandler(IUnitOfWork unitOfWork,
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notificationHandler,
            IIstenAyrilmaNedenleriRepository istenAyrilmaNedenleriRepository) : base(unitOfWork, mediator, notificationHandler)
        {

            _istenAyrilmaNedenleriRepository = istenAyrilmaNedenleriRepository;
        }
        public async Task<istenAyrilmaNedenleri> Handle(IstenAyrilmaNedenleriEkleCommand request, CancellationToken cancellationToken)
        {
            var istenAyrilmaNedenleri = request.IstenAyrilmaNedenleri;
            var validationResult = RuleManager.Instance.ValidateIstenAyrılmaNedenEkle(_istenAyrilmaNedenleriRepository, istenAyrilmaNedenleri);
            if (!validationResult.Success)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
                return null;
            }
            await _istenAyrilmaNedenleriRepository.AddAsync(istenAyrilmaNedenleri);

            if (await Commit())
            {
                //await _mediator.SendEvent(new EklendiEvent<Kademe>(kademe));
            }

            return istenAyrilmaNedenleri;
        }

        public async Task<istenAyrilmaNedenleri> Handle(IstenAyrilmaNedenleriGuncelleCommand request, CancellationToken cancellationToken)
        {
            var istenAyrilmaNedenleri = request.IstenAyrilmaNedenleri;
            var validationResult = RuleManager.Instance.ValidateIstenAyrılmaNedenGuncelle(_istenAyrilmaNedenleriRepository, istenAyrilmaNedenleri);
            if (!validationResult.Success)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
                return null;
            }
            await _istenAyrilmaNedenleriRepository.UpdateAsync(istenAyrilmaNedenleri);

            if (await Commit())
            {
                //await _mediator.SendEvent(new EklendiEvent<Kademe>(kademe));
            }

            return istenAyrilmaNedenleri;
        }

        public async Task<bool> Handle(IstenAyrilmaNedenleriSilCommand request, CancellationToken cancellationToken)
        {

            var firmasube = await _istenAyrilmaNedenleriRepository.GetFirstOrDefaultAsync(q => q.id == request.IstenAyrilmaNedenleri);
            //var validationResult = RuleManager.Instance.ValidateIstenAyrılmaNedenGuncelle(_istenAyrilmaNedenleriRepository, istenAyrilmaNedenleri);
            //if (!validationResult.Success)
            //{
            //    await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
            //    return false;
            //}
            firmasube.silindimi = true;
            await _istenAyrilmaNedenleriRepository.UpdateAsync(firmasube);

            if (await Commit())
            {
                return true;
            }

            return false;

            
        }
    }
}