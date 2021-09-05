using ERP.Application.AutoMapper;
using ERP.Application.DTOs.KullaniciYetkileriDTOs;
using ERP.Application.Interfaces;
using ERP.Data.DAO.KullaniciYetkileri;
using ERP.Data.Entities;
using ERP.Domain.Commands.Base;
using ERP.Domain.Commands.KullaniciYetkileri;
using ERP.Domain.Core;
using ERP.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.Services
{
    public class KullaniciYetkileriService : BaseService, IKullaniciYetkileriService
    {
        public KullaniciYetkileriService(IMediatorHandler mediator, IERPMapper mapper) : base(mediator, mapper)
        {
        }


        public async Task<KullaniciYetkiDTO> KullaniciYetkiEkle(KullaniciYetkiEkleDTO kullaniciYetkiEkleDTO)
        {
            try
            {
                var command = _mapper.Map<KullaniciYetkileriEkleCommand>(kullaniciYetkiEkleDTO);
                var sonuc = await _mediator.SendCommand<KullaniciYetkileriEkleCommand, kullaniciYetkileri>(command);
                return _mapper.Map<KullaniciYetkiDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(KullaniciYetkileriEkleCommand).Name, ex));
            }

            return null;
        }

        public async Task<KullaniciYetkiDTO> KullaniciYetkiGuncelle(KullaniciYetkiGuncelleDTO kullaniciYetkiGuncelleDTO)
        {
            try
            {
                var command = _mapper.Map<KullaniciYetkileriGuncelleCommand>(kullaniciYetkiGuncelleDTO);
                var sonuc = await _mediator.SendCommand<KullaniciYetkileriGuncelleCommand, kullaniciYetkileri>(command);
                return _mapper.Map<KullaniciYetkiDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(KullaniciYetkileriGuncelleCommand).Name, ex));
            }

            return null;
        }

        public async Task<List<KullaniciYetkiDTO>> KullaniciYetkileriGetir()
        {
            try
            {
                var query = new KullaniciYetkileriListeleQuery();
                var sonuc = await _mediator.SendQuery<KullaniciYetkileriListeleQuery, List<KullaniciYetkiDAO>>(query);
                return _mapper.Map<List<KullaniciYetkiDTO>>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(BaseGetirQuery<int, kullaniciYetkileri>).Name, ex));
            }

            return null;

            try
            {
                var item = await QueryHelper.SendListeleQuery<kullaniciYetkileri>(_mediator);
                return _mapper.Map<List<KullaniciYetkiDTO>>(item);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(BaseGetirQuery<int, kullaniciYetkileri>).Name, ex));
            }
            return null;
        }

        public async Task<bool> KullaniciYetkiSil(int kullaniciYetkiId)
        {
            try
            {

                var command = new KullaniciYetkileriSilCommand() { kullaniciYetkileriId = kullaniciYetkiId };
                var sonuc = await _mediator.SendCommand<KullaniciYetkileriSilCommand, bool>(command);
                return sonuc;
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(KullaniciYetkileriSilCommand).Name, ex));
            }

            return false;
        }
    }
}
