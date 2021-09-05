using ERP.Application.AutoMapper;
using ERP.Application.DTOs.YetkilerDTOs;
using ERP.Application.Interfaces;
using ERP.Data.Entities;
using ERP.Domain.Commands.Base;
using ERP.Domain.Commands.Yetkliler;
using ERP.Domain.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.Application.Services
{
    public class YetkilerService : BaseService, IYetkilerService
    {
        public YetkilerService(IMediatorHandler mediator, IERPMapper mapper) : base(mediator, mapper)
        {

        }

        public async Task<List<YetkiDTO>> YetkileriGetir()
        {
            try
            {
                var query = new YetkilerListeleQuery();
                var sonuc = await _mediator.SendQuery<YetkilerListeleQuery, List<yetkiler>>(query);
                return _mapper.Map<List<YetkiDTO>>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(BaseGetirQuery<int, yetkiler>).Name, ex));
            }

            return null;
        }
    }
}
