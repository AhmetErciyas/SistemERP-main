using ERP.Application.AutoMapper;
using ERP.Application.DTOs.OrganizasyonDTOs;
using ERP.Application.Interfaces;
using ERP.Core.PageSortFilter;
using ERP.Data.DAO.Organizasyon;
using ERP.Data.Entities;
using ERP.Domain.Commands.Organizasyon;
using ERP.Domain.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.Application.Services
{
    public class OrganizasyonService : BaseService, IOrganizasyonService
    {
        public OrganizasyonService(IMediatorHandler mediator, IERPMapper mapper) : base(mediator, mapper)
        {
        }

        #region Departman
        public async Task<DepartmanDTO> DepartmanEkle(DepartmanEkleDTO departmanEkleDTO)
        {
            try
            {
                var command = _mapper.Map<DepartmanEkleCommand>(departmanEkleDTO);
                var sonuc = await _mediator.SendCommand<DepartmanEkleCommand, departman>(command);
                return _mapper.Map<DepartmanDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(DepartmanEkleCommand).Name, ex));
            }

            return null;
        }

        public async Task<DepartmanDTO> DepartmanGuncelle(DepartmanDTO departmanDTO)
        {
            try
            {
                var command = _mapper.Map<DepartmanGuncelleCommand>(departmanDTO);
                var sonuc = await _mediator.SendCommand<DepartmanGuncelleCommand, departman>(command);
                return _mapper.Map<DepartmanDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(DepartmanGuncelleCommand).Name, ex));
            }

            return null;
        }

        public async Task<bool> DepartmanSil(int departmanId)
        {
            try
            {
                
                var command = new DepartmanSilCommand() { DepartmanId = departmanId };
                var sonuc = await _mediator.SendCommand<DepartmanSilCommand, bool>(command);
                return sonuc;
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(DepartmanSilCommand).Name, ex));
            }

            return false;
        }

        public async Task<List<DepartmanDTO>> DepartmanAra(DepartmanDTO departmanDTO)
        {
            try
            {
                var command = _mapper.Map<DepartmanAraQuery>(departmanDTO);
                var departmanlar = await _mediator.SendQuery<DepartmanAraQuery, List<DepartmanDAO>>(command);
                 return _mapper.Map<List<DepartmanDTO>>(departmanlar);

            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(DepartmanAraQuery).Name, ex));
            }

            return null;
        }
        #endregion

        #region Unvan
        public async Task<UnvanDTO> UnvanEkle(UnvanEkleDTO unvanEkleDTO)
        {
            try
            {
                var command = _mapper.Map<UnvanEkleCommand>(unvanEkleDTO);
                var sonuc = await _mediator.SendCommand<UnvanEkleCommand, unvan>(command);
                return _mapper.Map<UnvanDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(UnvanEkleCommand).Name, ex));
            }

            return null;
        }

        public async Task<UnvanDTO> UnvanGuncelle(UnvanDTO unvanDTO)
        {
            try
            {
                var command = _mapper.Map<UnvanGuncelleCommand>(unvanDTO);
                var sonuc = await _mediator.SendCommand<UnvanGuncelleCommand, unvan>(command);
                return _mapper.Map<UnvanDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(UnvanGuncelleCommand).Name, ex));
            }

            return null;
        }

        public async Task<bool> UnvanSil(int unvanId)
        {
            try
            {
                var command = new UnvanSilCommand() { UnvanId = unvanId };
                var sonuc = await _mediator.SendCommand<UnvanSilCommand, bool>(command);
                return sonuc;
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(UnvanSilCommand).Name, ex));
            }

            return false;
        }

        public async Task<List<UnvanDTO>> UnvanAra(UnvanDTO unvanDTO)
        {
            try
            {
                var command = _mapper.Map<UnvanAraQuery>(unvanDTO);
                var unvanlar = await _mediator.SendQuery<UnvanAraQuery, List<UnvanDAO>>(command);
                 return _mapper.Map<List<UnvanDTO>>(unvanlar);

            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(UnvanAraQuery).Name, ex));
            }

            return null;
        }
        #endregion

        #region Gorev
        public async Task<KademeDTO> KademeEkle(KademeEkleDTO kademeEkleDTO)
        {
            try
            {
                var command = _mapper.Map<KademeEkleCommand>(kademeEkleDTO);
                var sonuc = await _mediator.SendCommand<KademeEkleCommand, kademe>(command);
                return _mapper.Map<KademeDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(KademeEkleCommand).Name, ex));
            }

            return null;
        }

        public async Task<KademeDTO> KademeGuncelle(KademeGuncelleDTO kademeGuncelleDTO)
        {
            try
            {
                var command = _mapper.Map<KademeGuncelleCommand>(kademeGuncelleDTO);
                var sonuc = await _mediator.SendCommand<KademeGuncelleCommand, kademe>(command);
                return _mapper.Map<KademeDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(KademeGuncelleCommand).Name, ex));
            }

            return null;
        }

        public async Task<bool> KademeSil(int kademeId)
        {
            try
            {
                var command = new KademeSilCommand() { KademeId = kademeId };
                var sonuc = await _mediator.SendCommand<KademeSilCommand, bool>(command);
                return sonuc;
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(KademeSilCommand).Name, ex));
            }

            return false;
        }

        public async Task<List<KademeDTO>> KademeAra(KademeDTO kademeDTO)
        {
            try
            {
                var command = _mapper.Map<KademeAraQuery>(kademeDTO);
                var kademelar = await _mediator.SendQuery<KademeAraQuery, List<KademeDAO>>(command);
                return _mapper.Map<List<KademeDTO>>(kademelar);

            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(KademeAraQuery).Name, ex));
            }

            return null;
        }

        
        #endregion
    }
}
