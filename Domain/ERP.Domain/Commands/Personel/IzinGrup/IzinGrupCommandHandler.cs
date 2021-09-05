using ERP.Data;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using ERP.Domain.RuleEngine;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.IzinGrup
{
    public class IzinGrupCommandHandler : BaseCommandHandler,
        IRequestHandler<IzinGrupEkleCommand, izinGrubu>,
        IRequestHandler<IzinGrupGuncelleCommand, izinGrubu>,
        IRequestHandler<IzinGrupSilCommand, bool>
    {

        public IIzinGrubuRepository _izinGrupRepository;

        public IzinGrupCommandHandler(IUnitOfWork unitOfWork,
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notificationHandler,
            IIzinGrubuRepository izinGrupRepository) : base(unitOfWork, mediator, notificationHandler)
        {

            _izinGrupRepository = izinGrupRepository;
        }
        public async Task<izinGrubu> Handle(IzinGrupEkleCommand request, CancellationToken cancellationToken)
        {
            var izinGrubu = request.izinGrubu;
            var validationResult = RuleManager.Instance.ValidatePersonelİzinGrupEkle(_izinGrupRepository, izinGrubu);
            if (!validationResult.Success)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
                return null;
            }
            await _izinGrupRepository.AddAsync(izinGrubu);

            if (await Commit())
            {
                //await _mediator.SendEvent(new EklendiEvent<Kademe>(kademe));
            }

            return izinGrubu;
        }

        public async Task<izinGrubu> Handle(IzinGrupGuncelleCommand request, CancellationToken cancellationToken)
        {
            var istenAyrilmaNedenleri = request.izinGrubu;
            var izinGrubu = request.izinGrubu;
            var validationResult = RuleManager.Instance.ValidatePersonelİzinGrupGuncelle(_izinGrupRepository, izinGrubu);
            if (!validationResult.Success)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
                return null;
            }
            await _izinGrupRepository.UpdateAsync(istenAyrilmaNedenleri);

            if (await Commit())
            {
                //await _mediator.SendEvent(new EklendiEvent<Kademe>(kademe));
            }

            return istenAyrilmaNedenleri;
        }

        public async Task<bool> Handle(IzinGrupSilCommand request, CancellationToken cancellationToken)
        {
            var firmasube = await _izinGrupRepository.GetFirstOrDefaultAsync(q => q.id == request.izinGrubu);
            //var validationResult = RuleManager.Instance.ValidatePersonelİzinGrupGuncelle(_izinGrupRepository, izinGrubu);
            //if (!validationResult.Success)
            //{
            //    await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, validationResult.Errors));
            //    return false;
            //}
            firmasube.silindimi = true;
            await _izinGrupRepository.UpdateAsync(firmasube);

            if (await Commit())
            {
                return true;
            }

            return false;

        }
    }
}
