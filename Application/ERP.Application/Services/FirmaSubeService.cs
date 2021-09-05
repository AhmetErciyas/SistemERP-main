using ERP.Application.AutoMapper;
using ERP.Application.DTOs.FirmaSubeDTOs;
using ERP.Application.Interfaces;
using ERP.Core.PageSortFilter;
using ERP.Data.DAO.FirmaSube;
using ERP.Data.Entities;
using ERP.Domain.Commands;
using ERP.Domain.Commands.Base;
using ERP.Domain.Commands.Personel;
using ERP.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static ERP.Application.DTOs.FirmaSubeDTOs.FirmaSubeDTO;

namespace ERP.Application.Services
{
    public class FirmaSubeService : BaseService, IFirmaSubeService
    {
        public FirmaSubeService(IMediatorHandler mediator, IERPMapper mapper) : base(mediator, mapper)
        {
        }

        public async Task<FirmaSubeDTO> FirmaSubeEkle(FirmaSubeEkleDTO firmasubeEkleDTO)
        {
            try
            {
                var command = _mapper.Map<FirmaSubeEkleCommand>(firmasubeEkleDTO);
                var sonuc = await _mediator.SendCommand<FirmaSubeEkleCommand, sube>(command);
                return _mapper.Map<FirmaSubeDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, ex));
            }

            return null;
        }

        public async Task<PagedResult<FirmaSubeDTO>> FirmaSubeAra(FirmaSubeAraDTO firmasubeAraDTO)
        {
            try
            {
                var query = _mapper.Map<FirmaSubeAraQuery>(firmasubeAraDTO);
                var sonuc = await _mediator.SendQuery<FirmaSubeAraQuery, PagedResult<FirmaSubeDAO>>(query);
                return _mapper.MapToPaged<FirmaSubeDTO, FirmaSubeDAO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(FirmaSubeAraQuery).Name, ex));
            }

            return null;
        }

        public async Task<FirmaSubeDTO> FirmaSubeGetir(int id)
        {
            try
            {
                var sonuc = await _mediator.SendQuery<FirmaSubeQuery, sube>(new FirmaSubeQuery() { firmaSubeId = id });
                return _mapper.Map<FirmaSubeDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(BaseGetirQuery<int, sube>).Name, ex));
            }

            return null;
        }

        public async Task<FirmaSubeDTO> FirmaSubeGuncelle(FirmaSubeGuncelleDTO personelGuncelleDTO)
        {
            try
            {
                var command = _mapper.Map<FirmaSubeGuncelleCommand>(personelGuncelleDTO);
                var sonuc = await _mediator.SendCommand<FirmaSubeGuncelleCommand, sube>(command);
                return _mapper.Map<FirmaSubeDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(FirmaSubeGuncelleCommand).Name, ex));
            }

            return null;
        }

        public async Task<bool> FirmaSubeSil(int id)
        {
            try
            {
                var command = new FirmaSubeSilCommand() { FirmaSubeId = id };
                return await _mediator.SendCommand<FirmaSubeSilCommand, bool>(command); 
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(FirmaSubeSilCommand).Name, ex));
            }

            return false;
        }

    }
}
