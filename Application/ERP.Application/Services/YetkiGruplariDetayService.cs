using ERP.Application.AutoMapper;
using ERP.Application.DTOs.YetkiGruplariDetayDTOs;
using ERP.Application.Interfaces;
using ERP.Data.DAO.YetkiGruplariDetay;
using ERP.Data.Entities;
using ERP.Domain.Commands.Base;
using ERP.Domain.Commands.YetkiGruplari;
using ERP.Domain.Commands.YetkiGruplariDetay;
using ERP.Domain.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.Application.Services
{
    public class YetkiGruplariDetayService : BaseService, IYetkiGruplariDetayService
    {
        public YetkiGruplariDetayService(IMediatorHandler mediator, IERPMapper mapper) : base(mediator, mapper)
        {
        }


        public async Task<YetkiGrupDetayDTO> YetkiGrupDetayEkle(YetkiGrupDetayEkleDTO yetkiGrupDetayEkleDTO)
        {
            try
            {
                var command = _mapper.Map<YetkiGruplariDetayEkleCommand>(yetkiGrupDetayEkleDTO);
                var sonuc = await _mediator.SendCommand<YetkiGruplariDetayEkleCommand, yetkiGruplariDetay>(command);
                return _mapper.Map<YetkiGrupDetayDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(YetkiGruplariEkleCommand).Name, ex));
            }

            return null;
        }

        public async Task<YetkiGrupDetayDTO> YetkiGrupDetayGuncelle(YetkiGrupDetayGuncelleDTO yetkiGrupDetayGuncelleDTO)
        {
            try
            {
                var command = _mapper.Map<YetkiGruplariDetayGuncelleCommand>(yetkiGrupDetayGuncelleDTO);
                var sonuc = await _mediator.SendCommand<YetkiGruplariDetayGuncelleCommand, yetkiGruplariDetay>(command);
                return _mapper.Map<YetkiGrupDetayDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(YetkiGruplariDetayGuncelleCommand).Name, ex));
            }

            return null;
        }
        public async Task<List<YetkiGrupDetayDTO>> YetkiGrupDetaylariGetir()
        {
            try
            {
                var query = new YetkiGruplariDetayListeleQuery();
                var sonuc = await _mediator.SendQuery<YetkiGruplariDetayListeleQuery, List<YetkiGruplariDetayDAO>>(query);
                return _mapper.Map<List<YetkiGrupDetayDTO>>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(BaseGetirQuery<int, yetkiGruplariDetay>).Name, ex));
            }

            return null;
        }

        public async Task<bool> YetkiGrupDetaySil(int yetkiGrupDetayId)
        {
            try
            {

                var command = new YetkiGruplariDetaySilCommand() { yetkiGruplariDetayId = yetkiGrupDetayId };
                var sonuc = await _mediator.SendCommand<YetkiGruplariDetaySilCommand, bool>(command);
                return sonuc;
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(YetkiGruplariDetaySilCommand).Name, ex));
            }

            return false;
        }
    }
}
