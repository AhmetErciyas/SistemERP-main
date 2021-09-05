using ERP.Application.AutoMapper;
using ERP.Application.DTOs.Finans;
using ERP.Application.Interfaces;
using ERP.Data.Entities;
using ERP.Domain.Commands.Base;
using ERP.Domain.Commands.Finans;
using ERP.Domain.Core;
using ERP.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.Services
{
    public class FinansService : BaseService, IFinansService
    {
        public FinansService(IMediatorHandler mediator, IERPMapper mapper) : base(mediator, mapper)
        {
        }

        public async Task<FinansFirmaDTO> FirmaEkle(FinansFirmaEkleDTO finansFirmaDTO)
        {
            try
            {
                var command = _mapper.Map<FinansFirmaEkleCommand>(finansFirmaDTO);
                var sonuc = await _mediator.SendCommand<FinansFirmaEkleCommand, firma>(command);
                return _mapper.Map<FinansFirmaDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(FinansFirmaEkleCommand).Name, ex));
            }

            return null;
        }

        #region Firma Tür

        public async Task<IEnumerable<FirmaTurDTO>> FirmaTurListele()
        {
            try
            {
                var items = await QueryHelper.SendListeleQuery<firmaTur>(_mediator);
                return _mapper.Map<List<FirmaTurDTO>>(items);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(BaseListeleQuery<firmaTur>).Name, ex));
            }
            return null;
        }

        public async Task<FirmaTurDTO> FirmaTurGetir(byte id)
        {
            try
            {
                var item = await QueryHelper.SendGetirQuery<byte, firmaTur>(_mediator, id);
                return _mapper.Map<FirmaTurDTO>(item);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(BaseGetirQuery<byte, FirmaTurDTO>).Name, ex));
            }
            return null;
        }
        #endregion
    }
}
