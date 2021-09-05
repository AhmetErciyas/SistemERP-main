using ERP.Application.AutoMapper;
using ERP.Application.DTOs.AskerlikDurumDTOs;
using ERP.Application.DTOs.EngellilikDurumDTOs;
using ERP.Application.DTOs.IstenAyrılmaNedenleriDTOs;
using ERP.Application.DTOs.IzinGrupDTOs;
using ERP.Application.DTOs.OgrenimDurumDTOs;
using ERP.Application.DTOs.PersonelDTOs;
using ERP.Application.DTOs.PersonelKanun;
using ERP.Application.DTOs.SigortaTurDTOs;
using ERP.Application.DTOs.SozlesmeTurDTOs;
using ERP.Application.Interfaces;
using ERP.Data;
using ERP.Data.DAO.Personel;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Commands;
using ERP.Domain.Commands.AskerlikDurum;
using ERP.Domain.Commands.Base;
using ERP.Domain.Commands.EngellilikDurum;
using ERP.Domain.Commands.IstenAyrilmaNedenleri;
using ERP.Domain.Commands.IzinGrup;
using ERP.Domain.Commands.OgrenimDurum;
using ERP.Domain.Commands.Personel;
using ERP.Domain.Commands.PersonelKanun;
using ERP.Domain.Commands.SigortaTur;
using ERP.Domain.Commands.SozlesmeTur;
using ERP.Domain.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.Application.Services
{
    public class PersonelService : BaseService, IPersonelService
    {
        IPersonelRepository _personelRepository;
        protected readonly IUnitOfWork _unitOfWork;
        public PersonelService(IMediatorHandler mediator, IERPMapper mapper, IPersonelRepository personelRepository, IUnitOfWork unitOfWork) : base(mediator, mapper)
        {
            _personelRepository = personelRepository;
            _unitOfWork = unitOfWork;

        }

        #region Personel
        public async Task<PersonelDTO> PersonelEkle(PersonelEkleDTO personelEkleDTO)
        {
            try
            {
                var command = _mapper.Map<PersonelEkleCommand>(personelEkleDTO);
                var sonuc = await _mediator.SendCommand<PersonelEkleCommand, personel>(command);
                return _mapper.Map<PersonelDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelEkleCommand).Name, ex));
            }

            return null;
        }

        public async Task<List<PersonelDTO>> PersonelAra(PersonelAraDTO personelAraDTO)
        {
            try
            {
                var query = _mapper.Map<PersonelAraQuery>(personelAraDTO);
                var sonuc = await _mediator.SendQuery<PersonelAraQuery, List<PersonelDAO>>(query);
                return _mapper.Map<List<PersonelDTO>>(sonuc);


            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelAraQuery).Name, ex));
            }

            return null;
        }

        public async Task<PersonelDTO> PersonelGetir(int id)
        {
            try
            {
                var sonuc = await _mediator.SendQuery<PersonelQuery, PersonelDAO>(new PersonelQuery() { PersonelId = id });
                return _mapper.Map<PersonelDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(BaseGetirQuery<int, personel>).Name, ex));
            }

            return null;
        }

        public async Task<PersonelDTO> PersonelGuncelle(PersonelGuncelleDTO personelGuncelleDTO)
        {
            try
            {
                var command = _mapper.Map<PersonelGuncelleCommand>(personelGuncelleDTO);
                var sonuc = await _mediator.SendCommand<PersonelGuncelleCommand, personel>(command);
                return _mapper.Map<PersonelDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelGuncelleCommand).Name, ex));
            }

            return null;
        }

        /// <summary>
        /// Personel silme
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> PersonelSil(int id)
        {
            try
            {
                var command = new PersonelSilCommand() { PersonelId = id };
                return await _mediator.SendCommand<PersonelSilCommand, bool>(command);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelSilCommand).Name, ex));
            }

            return false;
        }
        #endregion

        #region Askerlik Durumları
        public async Task<List<AskerlikDurumDTO>> AskerlikDurumlariGetir()
        {
            try
            {
                var query = new AskerlikDurumListeleQuery();
                var sonuc = await _mediator.SendQuery<AskerlikDurumListeleQuery, List<askerlikDurum>>(query);
                return _mapper.Map<List<AskerlikDurumDTO>>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(BaseGetirQuery<int, askerlikDurum>).Name, ex));
            }
            return null;
        }
        #endregion

        #region Personel Kanun
        public async Task<PersonelKanunDTO> PersonelKanunEkle(PersonelKanunEkleDTO personelKanunEkleDTO)
        {
            try
            {
                var command = _mapper.Map<PersonelKanunEKleCommand>(personelKanunEkleDTO);
                var sonuc = await _mediator.SendCommand<PersonelKanunEKleCommand, personelKanun>(command);
                return _mapper.Map<PersonelKanunDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelKanunEKleCommand).Name, ex));
            }

            return null;
        }

        public async Task<PersonelKanunDTO> PersonelKanunGuncelle(PersonelKanunGuncelleDTO personelKanunGuncelleDTO)
        {
            try
            {
                var command = _mapper.Map<PersonelKanunGuncelleCommand>(personelKanunGuncelleDTO);
                var sonuc = await _mediator.SendCommand<PersonelKanunGuncelleCommand, personelKanun>(command);
                return _mapper.Map<PersonelKanunDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelKanunGuncelleCommand).Name, ex));
            }

            return null;
        }

        public async Task<List<PersonelKanunDTO>> PersonelKanunlariGetir()
        {
            try
            {
                var query = new PersonelKanuListeleQuery();
                var sonuc = await _mediator.SendQuery<PersonelKanuListeleQuery, List<personelKanun>>(query);
                return _mapper.Map<List<PersonelKanunDTO>>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(BaseGetirQuery<int, personelKanun>).Name, ex));
            }

            return null;
        }

        public async Task<bool> PersonelKanunSil(int personelKanunId)
        {
            try
            {
                var command = new PersonelKanunSilCommand() { personelKanunId = personelKanunId };
                var sonuc = await _mediator.SendCommand<PersonelKanunSilCommand, bool>(command);
                return sonuc;
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(PersonelKanunSilCommand).Name, ex));
            }

            return false;
        }
        #endregion

        #region Engellilik Durum
        public async Task<List<EngellilikDurumDto>> EngellilikDurumlariGetir()
        {
            try
            {
                var query = new EngellilikDurumListeleQuery();
                var sonuc = await _mediator.SendQuery<EngellilikDurumListeleQuery, List<engellilikDurum>>(query);
                return _mapper.Map<List<EngellilikDurumDto>>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(BaseGetirQuery<int, engellilikDurum>).Name, ex));
            }

            return null;
        }
        #endregion

        #region Isten Ayrılma
        public async Task<IstenAyrilmaNedenleriDTO> IstenAyrilmaNedenGuncelle(IstenAyrilmaNedenleriGuncelleDTO istenAyrilmaNedenleriGuncelleDTO)
        {
            try
            {
                var command = _mapper.Map<IstenAyrilmaNedenleriGuncelleCommand>(istenAyrilmaNedenleriGuncelleDTO);
                var sonuc = await _mediator.SendCommand<IstenAyrilmaNedenleriGuncelleCommand, istenAyrilmaNedenleri>(command);
                return _mapper.Map<IstenAyrilmaNedenleriDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(IstenAyrilmaNedenleriGuncelleCommand).Name, ex));
            }

            return null;
        }

        public async Task<IstenAyrilmaNedenleriDTO> IstenAyrilmaNedenleriEkle(IstenAyrilmaNedenleriEkleDTO istenAyrilmaNedenleriEkleDTO)
        {
            try
            {
                var command = _mapper.Map<IstenAyrilmaNedenleriEkleCommand>(istenAyrilmaNedenleriEkleDTO);
                var sonuc = await _mediator.SendCommand<IstenAyrilmaNedenleriEkleCommand, istenAyrilmaNedenleri>(command);
                return _mapper.Map<IstenAyrilmaNedenleriDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(IstenAyrilmaNedenleriEkleCommand).Name, ex));
            }

            return null;
        }

        public async Task<List<IstenAyrilmaNedenleriDTO>> IstenAyrilmaNedenleriGetir()
        {
            try
            {
                var query = new IstenAyrilmaNedenleriListeleQuery();
                var sonuc = await _mediator.SendQuery<IstenAyrilmaNedenleriListeleQuery, List<istenAyrilmaNedenleri>>(query);
                return _mapper.Map<List<IstenAyrilmaNedenleriDTO>>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(BaseGetirQuery<int, istenAyrilmaNedenleri>).Name, ex));
            }

            return null;
        }

        public async Task<bool> IstenAyrilmaNedenSil(int istenAyrilmaNedenId)
        {
            try
            {
                var command = new IstenAyrilmaNedenleriSilCommand() { IstenAyrilmaNedenleri = istenAyrilmaNedenId };
                var sonuc = await _mediator.SendCommand<IstenAyrilmaNedenleriSilCommand, bool>(command);
                return sonuc;
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(IstenAyrilmaNedenleriSilCommand).Name, ex));
            }

            return false;
        }
        #endregion

        #region Izin Grup
        public async Task<IzinGrupDTO> IzinGrupEkle(IzinGrupEkleDTO ızinGrupEkleDTO)
        {
            try
            {
                var command = _mapper.Map<IzinGrupEkleCommand>(ızinGrupEkleDTO);
                var sonuc = await _mediator.SendCommand<IzinGrupEkleCommand, izinGrubu>(command);
                return _mapper.Map<IzinGrupDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(IzinGrupEkleCommand).Name, ex));
            }

            return null;
        }

        public async Task<IzinGrupDTO> IzinGrupGuncelle(IzinGrupGuncelleDTO ızinGrupGuncelleDTO)
        {
            try
            {
                var command = _mapper.Map<IzinGrupGuncelleCommand>(ızinGrupGuncelleDTO);
                var sonuc = await _mediator.SendCommand<IzinGrupGuncelleCommand, izinGrubu>(command);
                return _mapper.Map<IzinGrupDTO>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(IzinGrupGuncelleCommand).Name, ex));
            }

            return null;
        }

        public async Task<List<IzinGrupDTO>> IzinGruplariGetir()
        {
            try
            {
                var query = new IzinGrupListeleQuery();
                var sonuc = await _mediator.SendQuery<IzinGrupListeleQuery, List<izinGrubu>>(query);
                return _mapper.Map<List<IzinGrupDTO>>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(BaseGetirQuery<int, izinGrubu>).Name, ex));
            }

            return null;
        }

        public async Task<bool> IzinGrupSil(int izinGrupId)
        {
            try
            {
                var command = new IzinGrupSilCommand() { izinGrubu = izinGrupId };
                var sonuc = await _mediator.SendCommand<IzinGrupSilCommand, bool>(command);
                return sonuc;
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(IzinGrupSilCommand).Name, ex));
            }

            return false;
        }
        #endregion

        #region Ogrenim Durum
        public async Task<List<OgrenimDurumDTO>> OgrenimDurumlariGetir()
        {
            try
            {
                var query = new OgrenimDurumListeleQuery();
                var sonuc = await _mediator.SendQuery<OgrenimDurumListeleQuery, List<ogrenimDurum>>(query);
                return _mapper.Map<List<OgrenimDurumDTO>>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(BaseGetirQuery<int, ogrenimDurum>).Name, ex));
            }

            return null;
        }
        #endregion

        #region Sigrota Tur
        public async Task<List<SigortaTurDTO>> SigortaTurleriGetir()
        {
            try
            {
                var query = new SigortaTurListeleQuery();
                var sonuc = await _mediator.SendQuery<SigortaTurListeleQuery, List<sigortaTur>>(query);
                return _mapper.Map<List<SigortaTurDTO>>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(BaseGetirQuery<int, sigortaTur>).Name, ex));
            }

            return null;
        }
        #endregion

        #region Sozlesme Tur
        public async Task<List<SozlesmeTurDTO>> SozlesmeTurleriGetir()
        {
            try
            {
                var query = new SozlesmeTurListeleQuery();
                var sonuc = await _mediator.SendQuery<SozlesmeTurListeleQuery, List<sozlesmeTur>>(query);
                return _mapper.Map<List<SozlesmeTurDTO>>(sonuc);
            }
            catch (Exception ex)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(BaseGetirQuery<int, sozlesmeTur>).Name, ex));
            }

            return null;
        }
        #endregion

    }
}
