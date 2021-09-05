using ERP.Application.AutoMapper;
using ERP.Application.DTOs.KullaniciDTOs;
using ERP.Application.DTOs.OrganizasyonDTOs;
using ERP.Application.Interfaces;
using ERP.Core.PageSortFilter;
using ERP.Data.DAO.Kullanici;
using ERP.Data.Interfaces;
using ERP.Domain.Commands.Kullanici;
using ERP.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.Services
{
    public class KullaniciService : BaseService, IKullaniciService
    {
        private readonly IKullaniciRepository _kullaniciRepository;

        public KullaniciService(IERPMapper mapper,
                                IMediatorHandler mediator,
                                IKullaniciRepository kullaniciRepository) : base(mediator, mapper)
        {
            _kullaniciRepository = kullaniciRepository;
        }

        public async Task<KullaniciToken> GirisYap(KullaniciGirisDTO kullaniciGirisDTO)
        {
            try
            {
                var command = _mapper.Map<KullaniciGirisCommand>(kullaniciGirisDTO);
                var token = await _mediator.SendCommand<KullaniciGirisCommand, KullaniciToken>(command);
                return token;
            }
            catch (Exception ex)
            {
                await base._mediator.SendEvent(new DomainNotification(typeof(KullaniciGirisCommand).Name, ex));
            }
            return null;
        }

        public async Task<KullaniciDTO> KullaniciEkle(KullaniciDTO kullaniciEkleDTO)
        {
            try
            {
                var command = _mapper.Map<KullaniciEkleCommand>(kullaniciEkleDTO);
                var kullanici = await _mediator.SendCommand<KullaniciEkleCommand, KullaniciDAO>(command);
                return _mapper.Map<KullaniciDTO>(kullanici);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(KullaniciEkleCommand).Name, ex));
            }

            return null;
        }

        public async Task<KullaniciDTO> KullaniciGetir(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<KademeDTO>> KullaniciGorevler(int kullaniciId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> KullaniciGuncelle(KullaniciDTO kullaniciGuncelleDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResult<KullaniciDTO>> KullaniciListele(KullaniciAraDTO kullaniciAraDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> KullaniciSil(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SifreDegistir(KullaniciDTO sifreDegistirDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SifremiUnuttum(KullaniciDTO sifremiUnuttumDTO)
        {
            throw new NotImplementedException();
        }
    }
}
