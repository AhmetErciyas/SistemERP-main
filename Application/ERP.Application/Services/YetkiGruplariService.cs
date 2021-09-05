using ERP.Application.AutoMapper;
using ERP.Application.DTOs.YetkiGruplariDTOs;
using ERP.Application.Interfaces;
using ERP.Data.Entities;
using ERP.Domain.Commands.Base;
using ERP.Domain.Commands.YetkiGruplari;
using ERP.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.Services
{
    public class YetkiGruplariService : BaseService, IYetkiGruplariService
    {
        public YetkiGruplariService(IMediatorHandler mediator, IERPMapper mapper) : base(mediator, mapper)
        {
        }
       
        public async Task<YetkiGrupDTO> YetkiGrupEkle(YetkiGrupEkleDTO yetkiGrupEkleDTO)
        {
            try
            {
                var command = _mapper.Map<YetkiGruplariEkleCommand>(yetkiGrupEkleDTO);
                var sonuc = await _mediator.SendCommand<YetkiGruplariEkleCommand, yetkiGruplari>(command);
                return _mapper.Map<YetkiGrupDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(YetkiGruplariEkleCommand).Name, ex));
            }

            return null;
        }

        public async Task<YetkiGrupDTO> YetkiGrupGuncelle(YetkiGrupGuncelleDTO yetkiGrupGuncelleDTO)
        {
            try
            {
                var command = _mapper.Map<YetkiGruplariGuncelleCommand>(yetkiGrupGuncelleDTO);
                var sonuc = await _mediator.SendCommand<YetkiGruplariGuncelleCommand, yetkiGruplari>(command);
                return _mapper.Map<YetkiGrupDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(YetkiGruplariGuncelleCommand).Name, ex));
            }

            return null;
        }

        public async  Task<List<YetkiGrupDTO>> YetkiGruplariGetir()
        {
            try
            {
                var query = new YetkiGruplariListeleQuery();
                var sonuc = await _mediator.SendQuery<YetkiGruplariListeleQuery, List<yetkiGruplari>>(query);
                return _mapper.Map<List<YetkiGrupDTO>>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(BaseGetirQuery<int, yetkiGruplari>).Name, ex));
            }

            return null;
        }
        
        public async Task<bool> YetkiGrupSil(int yetkiGrupId)
        {
            try
            {

                var command = new YetkiGruplariSilCommand() { yetkiGruplariId = yetkiGrupId };
                var sonuc = await _mediator.SendCommand<YetkiGruplariSilCommand, bool>(command);
                return sonuc;
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(YetkiGruplariSilCommand).Name, ex));
            }

            return false;
        }
    }
}
