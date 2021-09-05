using Domain.Security.Jwt;
using ERP.Data;
using ERP.Data.DAO.Kullanici;
using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using ERP.Domain.ServiceClient.MAIL;
using ERP.Domain.ServiceClient.SMS;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.Kullanici
{
    public class KullaniciCommandHandler : BaseCommandHandler,
                 IRequestHandler<KullaniciGirisCommand, KullaniciToken>,
                 IRequestHandler<KullaniciEkleCommand, KullaniciDAO>,
                 IRequestHandler<KullaniciGuncelleCommand, bool>,
                 IRequestHandler<KullaniciSilCommand, bool>

    {

        private readonly IConfiguration _configuration;
        private readonly ISMSServiceClient _smsServiceClient;
        private readonly IMailServiceClient _mailServiceClient;
        private readonly IKullaniciRepository _kullaniciRepository;
        private readonly IKisiRepository _kisiRepository;
        private readonly IPersonelRepository _personelRepository;
        private readonly ITokenHelper _tokenHelper;

        public KullaniciCommandHandler(IUnitOfWork unitOfWork,
                                        IMediatorHandler mediator,
                                        INotificationHandler<DomainNotification> notifications,
                                        IConfiguration configuration,
                                        ISMSServiceClient smsServiceClient,
                                        IMailServiceClient mailServiceClient,
                                        IKullaniciRepository kullaniciRepository,
                                        IPersonelRepository personelRepository,
                                        IKisiRepository kisiRepository,
                                        ITokenHelper tokenHelper) : base(unitOfWork, mediator, notifications)
        {
            _configuration = configuration;
            _smsServiceClient = smsServiceClient;
            _mailServiceClient = mailServiceClient;
            _kullaniciRepository = kullaniciRepository;
            _kisiRepository = kisiRepository;
            _personelRepository = personelRepository;
            _tokenHelper = tokenHelper;
        }

        public async Task<KullaniciToken> Handle(KullaniciGirisCommand request, CancellationToken cancellationToken)
        {
            string md5sifre = MD5Hash(request.Sifre);
            var kullanici = await _kullaniciRepository.GetFirstOrDefaultAsyncWithIncludes(q => q.kullaniciAdi == request.KullaniciAdi && q.sifre == md5sifre && q.personel.firmaid == request.FirmaId,
               null, "personel.personelKimlik", "personel.firma","personel.sube");
            if (kullanici == null)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(KullaniciGirisCommand).Name, "Hatalı kullanıcı adı yada şifre veya Firma Kodu Yanlış"));
                return null;
            }

            return new KullaniciToken()
            {
                Id = kullanici.id,
                TCKimlikNo = kullanici.personel?.personelKimlik?.tckNo,
                Ad = kullanici.personel.adi,
                Soyad = kullanici.personel.soyadi,
                Token = TokenYarat(kullanici),
                Email = kullanici.email,
                FirmaId = kullanici.personel?.firma?.id != null ? Convert.ToInt32(kullanici.personel?.firma?.id) : 0,
                FirmaAd = kullanici.personel?.firma?.adi,
                SubeId = kullanici.personel?.sube?.id != null ? Convert.ToInt32(kullanici.personel?.sube?.id) : 0,
                SubeAd = kullanici.personel?.sube?.adi,
                Expires = DateTime.UtcNow.AddMinutes(15000)
            };
        }

        public async Task<KullaniciDAO> Handle(KullaniciEkleCommand request, CancellationToken cancellationToken)
        {
            var kisi = await _kisiRepository.GetFirstOrDefaultAsync(q => q.Id == request.KisiId);
            if (kisi == null)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(KullaniciGirisCommand).Name, "Kişi bilgisi bulunamadı"));
                return null;
            }


            var personel = await _personelRepository.GetFirstOrDefaultAsync(q => q.id == request.PersonelId);
            if (personel == null)
            {
                await _mediator.SendEvent(new DomainNotification(typeof(KullaniciGirisCommand).Name, "Personel bilgisi bulunamadı"));
                return null;
            }

            var kullanici = await _kullaniciRepository.GetFirstOrDefaultAsync(/*k => k.Personel.KisiId == kisi.Id, null, k => k.Personel.Kisi*/);
            //if (kullanici == null)
            //{
            //    kullanici = new ERP.Data.Entities.Kullanici()
            //    {
            //        Kisi = kisi,
            //        KullaniciAdi = kisi.TCKN,
            //        Sifre = MD5Hash("123456"),
            //    };
            //}
            //kullanici.KullaniciGorevs.Add(new KullaniciGorev()
            //{
            //    GorevId = request.GorevId
            //});

            var kullaniciEntity = new Data.Entities.kullanici()
            {
                //PersonelId = (int)request.PersonelId,
                //KullaniciAdi = request.KullaniciAdi,
                //KullaniciGrupId = (short)request.KullaniciGrupId,
                //Sifre = MD5Hash(request.Sifre)
            };
            if (kullanici == null || kullanici.id == 0)
            {
                await _kullaniciRepository.AddAsync(kullaniciEntity);
            }
            else
                await _kullaniciRepository.UpdateAsync(kullanici);

            if (await Commit())
            {
                return await _mediator.SendQuery<KullaniciGetirQuery, KullaniciDAO>(new KullaniciGetirQuery() { KullaniciId = (kullanici != null) ? kullanici.id : kullaniciEntity.id });
            }

            return null;
        }

        public async Task<bool> Handle(KullaniciGuncelleCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Handle(KullaniciSilCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


        #region Helpers
        
        private string TokenYarat(ERP.Data.Entities.kullanici kullanici)
        {
            
            var claims = _kullaniciRepository.GetKullaniciYetkileri(kullanici);
            var accessToken = _tokenHelper.CreateToken(kullanici, claims);
            return accessToken.Token;
        }

        public static string MD5Hash(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private static string KodYarat()
        {
            string k1, k2, k3, k4, code;

            do
            {
                code = Convert.ToString(new Random().Next(1000, 10000));
                k1 = code.Substring(0, 1);
                k2 = code.Substring(1, 1);
                k3 = code.Substring(2, 1);
                k4 = code.Substring(3, 1);
            }
            while ((k4 == k3) || (k4 == k2) || (k4 == k1) || (k3 == k2) || (k3 == k1) || (k2 == k1));

            return code;
        }

        #endregion Helpers
    }
}
