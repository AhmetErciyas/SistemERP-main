using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.Data.Entities
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ambar> ambar { get; set; }
        public virtual DbSet<asgariUcret> asgariUcret { get; set; }
        public virtual DbSet<askerlikDurum> askerlikDurum { get; set; }
        public virtual DbSet<banka> banka { get; set; }
        public virtual DbSet<bankaAdres> bankaAdres { get; set; }
        public virtual DbSet<bankaHesap> bankaHesap { get; set; }
        public virtual DbSet<bankaHesapTur> bankaHesapTur { get; set; }
        public virtual DbSet<birim> birim { get; set; }
        public virtual DbSet<bolum> bolum { get; set; }
        public virtual DbSet<cariKart> cariKart { get; set; }
        public virtual DbSet<departman> departman { get; set; }
        public virtual DbSet<depo> depo { get; set; }
        public virtual DbSet<digerBilgiler> digerBilgiler { get; set; }
        public virtual DbSet<eFaturaTur> eFaturaTur { get; set; }
        public virtual DbSet<ekGelirGider> ekGelirGider { get; set; }
        public virtual DbSet<ekGelirGiderAciklama> ekGelirGiderAciklama { get; set; }
        public virtual DbSet<ekGelirGiderTur> ekGelirGiderTur { get; set; }
        public virtual DbSet<engellilikDurum> engellilikDurum { get; set; }
        public virtual DbSet<fabrika> fabrika { get; set; }
        public virtual DbSet<firma> firma { get; set; }
        public virtual DbSet<firmaAdres> firmaAdres { get; set; }
        public virtual DbSet<firmaAdresTur> firmaAdresTur { get; set; }
        public virtual DbSet<firmaIletisim> firmaIletisim { get; set; }
        public virtual DbSet<firmaIletisimTur> firmaIletisimTur { get; set; }
        public virtual DbSet<firmaTur> firmaTur { get; set; }
        public virtual DbSet<firmaYon> firmaYon { get; set; }
        public virtual DbSet<fiyatListeTur> fiyatListeTur { get; set; }
        public virtual DbSet<genelOzellikler> genelOzellikler { get; set; }
        public virtual DbSet<grup> grup { get; set; }
        public virtual DbSet<il> il { get; set; }
        public virtual DbSet<ilce> ilce { get; set; }
        public virtual DbSet<istasyon> istasyon { get; set; }
        public virtual DbSet<istasyonUretim> istasyonUretim { get; set; }
        public virtual DbSet<istenAyrilmaNedenleri> istenAyrilmaNedenleri { get; set; }
        public virtual DbSet<kademe> kademe { get; set; }
        public virtual DbSet<kaliteKontrol> kaliteKontrol { get; set; }
        public virtual DbSet<kimlikTur> kimlikTur { get; set; }
        public virtual DbSet<kullanici> kullanici { get; set; }
        public virtual DbSet<kullaniciYetkileri> kullaniciYetkileri { get; set; }
        public virtual DbSet<malzeme> malzeme { get; set; }
        public virtual DbSet<malzemeIslemTur> malzemeIslemTur { get; set; }
        public virtual DbSet<malzemeOzellikleri> malzemeOzellikleri { get; set; }
        public virtual DbSet<nakliyeTur> nakliyeTur { get; set; }
        public virtual DbSet<odemePlan> odemePlan { get; set; }
        public virtual DbSet<odemePlanSatir> odemePlanSatir { get; set; }
        public virtual DbSet<ogrenimDurum> ogrenimDurum { get; set; }
        public virtual DbSet<operasyon> operasyon { get; set; }
        public virtual DbSet<operasyonIstasyon> operasyonIstasyon { get; set; }
        public virtual DbSet<operasyonIstasyonUretim> operasyonIstasyonUretim { get; set; }
        public virtual DbSet<organizasyon> organizasyon { get; set; }
        public virtual DbSet<organizasyonSatir> organizasyonSatir { get; set; }
        public virtual DbSet<ozelSigortaTur> ozelSigortaTur { get; set; }
        public virtual DbSet<paketlemeKod> paketlemeKod { get; set; }
        public virtual DbSet<paraBirim> paraBirim { get; set; }
        public virtual DbSet<paraBirimiTur> paraBirimiTur { get; set; }
        public virtual DbSet<parametreler> parametreler { get; set; }
        public virtual DbSet<personel> personel { get; set; }
        public virtual DbSet<personelAgi> personelAgi { get; set; }
        public virtual DbSet<personelBankaHesap> personelBankaHesap { get; set; }
        public virtual DbSet<personelDepartman> personelDepartman { get; set; }
        public virtual DbSet<personelEmeklilik> personelEmeklilik { get; set; }
        public virtual DbSet<personelKanun> personelKanun { get; set; }
        public virtual DbSet<personelKimlik> personelKimlik { get; set; }
        public virtual DbSet<personelMaas> personelMaas { get; set; }
        public virtual DbSet<personelMaasOdemeTur> personelMaasOdemeTur { get; set; }
        public virtual DbSet<personelMaasPeriyot> personelMaasPeriyot { get; set; }
        public virtual DbSet<personelTabiKanun> personelTabiKanun { get; set; }
        public virtual DbSet<postaKodu> postaKodu { get; set; }
        public virtual DbSet<recete> recete { get; set; }
        public virtual DbSet<rota> rota { get; set; }
        public virtual DbSet<sigortaDurum> sigortaDurum { get; set; }
        public virtual DbSet<sigortaTur> sigortaTur { get; set; }
        public virtual DbSet<siparisTur> siparisTur { get; set; }
        public virtual DbSet<sosyalGuvenlikKurum> sosyalGuvenlikKurum { get; set; }
        public virtual DbSet<sozlesmeTur> sozlesmeTur { get; set; }
        public virtual DbSet<stokHareket> stokHareket { get; set; }
        public virtual DbSet<stokHareketTur> stokHareketTur { get; set; }
        public virtual DbSet<stokTur> stokTur { get; set; }
        public virtual DbSet<sube> sube { get; set; }
        public virtual DbSet<tevkifatKodu> tevkifatKodu { get; set; }
        public virtual DbSet<ulke> ulke { get; set; }
        public virtual DbSet<unvan> unvan { get; set; }
        public virtual DbSet<vergiDaire> vergiDaire { get; set; }
        public virtual DbSet<yetkiGruplari> yetkiGruplari { get; set; }
        public virtual DbSet<yetkiGruplariDetay> yetkiGruplariDetay { get; set; }
        public virtual DbSet<yetkiler> yetkiler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=185.198.74.119;Database=ERPDB;User Id=sserp; Password=Erp-post*-ss;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<banka>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<bankaAdres>(entity =>
            {
                entity.Property(e => e.adres1).IsUnicode(false);

                entity.Property(e => e.adres2).IsUnicode(false);

                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<bankaHesap>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.firma)
                    .WithMany(p => p.bankaHesap)
                    .HasForeignKey(d => d.firmaid)
                    .HasConstraintName("FK_bankaHesap_firma");
            });

            modelBuilder.Entity<bankaHesapTur>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<birim>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<bolum>(entity =>
            {
                entity.HasKey(e => e.id)
                    .IsClustered(false);

                entity.HasOne(d => d.firma)
                    .WithMany(p => p.bolum)
                    .HasForeignKey(d => d.firmaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_bolum_firma");
            });

            modelBuilder.Entity<cariKart>(entity =>
            {
                entity.Property(e => e.eFaturaAdres).IsUnicode(false);

                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.kodu).IsUnicode(false);

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");

                entity.Property(e => e.unvan).IsUnicode(false);

                entity.Property(e => e.vergiDaire).IsUnicode(false);

                entity.Property(e => e.vergiNo).IsUnicode(false);

                entity.HasOne(d => d.firmaTur)
                    .WithMany(p => p.cariKart)
                    .HasForeignKey(d => d.firmaTurid)
                    .HasConstraintName("FK_firma_firmaTur");

                entity.HasOne(d => d.firmaYon)
                    .WithMany(p => p.cariKart)
                    .HasForeignKey(d => d.firmaYonid)
                    .HasConstraintName("FK_firma_firmaYon");

                entity.HasOne(d => d.firma)
                    .WithMany(p => p.Inversefirma)
                    .HasForeignKey(d => d.firmaid)
                    .HasConstraintName("FK_firma_firma");

                entity.HasOne(d => d.nakliyeTur)
                    .WithMany(p => p.cariKart)
                    .HasForeignKey(d => d.nakliyeTurid)
                    .HasConstraintName("FK_firma_nakliyeTur");

                entity.HasOne(d => d.odemePlan)
                    .WithMany(p => p.cariKart)
                    .HasForeignKey(d => d.odemePlanid)
                    .HasConstraintName("FK_firma_odemePlan");

                entity.HasOne(d => d.paraBirim)
                    .WithMany(p => p.cariKart)
                    .HasForeignKey(d => d.paraBirimid)
                    .HasConstraintName("FK_firma_paraBirim");
            });

            modelBuilder.Entity<departman>(entity =>
            {
                entity.HasKey(e => e.id)
                    .IsClustered(false);

                entity.HasOne(d => d.bolum)
                    .WithMany(p => p.departman)
                    .HasForeignKey(d => d.bolumid)
                    .HasConstraintName("FK_departman_bolum");
            });

            modelBuilder.Entity<depo>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.firma)
                    .WithMany(p => p.depo)
                    .HasForeignKey(d => d.firmaid)
                    .HasConstraintName("FK_depo_firma");
            });

            modelBuilder.Entity<digerBilgiler>(entity =>
            {
                entity.Property(e => e.personelid).ValueGeneratedNever();

                entity.HasOne(d => d.personel)
                    .WithOne(p => p.digerBilgiler)
                    .HasForeignKey<digerBilgiler>(d => d.personelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_digerBilgiler_personel");

                entity.HasOne(d => d.sosyalGuvenlikKurum)
                    .WithMany(p => p.digerBilgiler)
                    .HasForeignKey(d => d.sosyalGuvenlikKurumid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ekGelirGider_sosyalGuvenlikKurum");
            });

            modelBuilder.Entity<eFaturaTur>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ekGelirGider>(entity =>
            {
                entity.HasOne(d => d.ekGelirGiderAciklamaNavigation)
                    .WithMany(p => p.ekGelirGider)
                    .HasForeignKey(d => d.ekGelirGiderAciklama)
                    .HasConstraintName("FK_ekGelirGider_ekGelirGiderAciklama");

                entity.HasOne(d => d.ekGelirGiderTurNavigation)
                    .WithMany(p => p.ekGelirGider)
                    .HasForeignKey(d => d.ekGelirGiderTur)
                    .HasConstraintName("FK_ekGelirGider_ekGelirGiderTur");

                entity.HasOne(d => d.personel)
                    .WithMany(p => p.ekGelirGider)
                    .HasForeignKey(d => d.personelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ekGelirGider_personel");
            });

            modelBuilder.Entity<fabrika>(entity =>
            {
                entity.HasKey(e => e.id)
                    .IsClustered(false);

                entity.HasOne(d => d.firma)
                    .WithMany(p => p.fabrika)
                    .HasForeignKey(d => d.firmaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_fabrika_firma");
            });

            modelBuilder.Entity<firma>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<firmaAdres>(entity =>
            {
                entity.Property(e => e.adres1).IsUnicode(false);

                entity.Property(e => e.adres2).IsUnicode(false);

                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.firmaAdresTur)
                    .WithMany(p => p.firmaAdres)
                    .HasForeignKey(d => d.firmaAdresTurid)
                    .HasConstraintName("FK_firmaAdres_firmaAdresTur");

                entity.HasOne(d => d.firma)
                    .WithMany(p => p.firmaAdres)
                    .HasForeignKey(d => d.firmaid)
                    .HasConstraintName("FK_firma_firmaAdres");

                entity.HasOne(d => d.ilce)
                    .WithMany(p => p.firmaAdres)
                    .HasForeignKey(d => d.ilceid)
                    .HasConstraintName("FK_firmaAdres_ilce");

                entity.HasOne(d => d.il)
                    .WithMany(p => p.firmaAdres)
                    .HasForeignKey(d => d.ilid)
                    .HasConstraintName("FK_firmaAdres_il");

                entity.HasOne(d => d.postakodu)
                    .WithMany(p => p.firmaAdres)
                    .HasForeignKey(d => d.postakoduid)
                    .HasConstraintName("FK_postakodu_firmaAdres");

                entity.HasOne(d => d.ulke)
                    .WithMany(p => p.firmaAdres)
                    .HasForeignKey(d => d.ulkeid)
                    .HasConstraintName("FK_firmaAdres_ulke");
            });

            modelBuilder.Entity<firmaAdresTur>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<firmaIletisim>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.firmaIletisimTur)
                    .WithMany(p => p.firmaIletisim)
                    .HasForeignKey(d => d.firmaIletisimTurid)
                    .HasConstraintName("FK_firmaIletisim_firmaIletisimTur");

                entity.HasOne(d => d.firma)
                    .WithMany(p => p.firmaIletisim)
                    .HasForeignKey(d => d.firmaid)
                    .HasConstraintName("FK_firmaIletisim_firma");
            });

            modelBuilder.Entity<firmaIletisimTur>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<firmaTur>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<firmaYon>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<fiyatListeTur>(entity =>
            {
                entity.Property(e => e.adi).IsUnicode(false);

                entity.Property(e => e.kod).IsUnicode(false);
            });

            modelBuilder.Entity<genelOzellikler>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.tevkifatKoduNavigation)
                    .WithMany(p => p.genelOzellikler)
                    .HasForeignKey(d => d.tevkifatKodu)
                    .HasConstraintName("FK_genelOzellikler_tevkifatKodu");
            });

            modelBuilder.Entity<il>(entity =>
            {
                entity.HasKey(e => e.id)
                    .IsClustered(false);
            });

            modelBuilder.Entity<ilce>(entity =>
            {
                entity.HasKey(e => e.id)
                    .IsClustered(false);
            });

            modelBuilder.Entity<kullanici>(entity =>
            {
                entity.HasKey(e => e.id)
                    .IsClustered(false);

                entity.HasOne(d => d.personel)
                    .WithMany(p => p.kullanici)
                    .HasForeignKey(d => d.personelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kullanici_personel");
            });

            modelBuilder.Entity<kullaniciYetkileri>(entity =>
            {
                entity.HasOne(d => d.kullanici)
                    .WithMany(p => p.kullaniciYetkileri)
                    .HasForeignKey(d => d.kullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kullaniciYetkileri_kullanici");

                entity.HasOne(d => d.yetki)
                    .WithMany(p => p.kullaniciYetkileri)
                    .HasForeignKey(d => d.yetkiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_kullaniciYetkileri_Yetkiler");
            });

            modelBuilder.Entity<malzeme>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.anabirimNavigation)
                    .WithMany(p => p.malzeme)
                    .HasForeignKey(d => d.anabirim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_malzeme_birim");

                entity.HasOne(d => d.stokTur)
                    .WithMany(p => p.malzeme)
                    .HasForeignKey(d => d.stokTurid)
                    .HasConstraintName("FK_malzeme_stokTur");
            });

            modelBuilder.Entity<malzemeIslemTur>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<malzemeOzellikleri>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.alanBirimNavigation)
                    .WithMany(p => p.malzemeOzelliklerialanBirimNavigation)
                    .HasForeignKey(d => d.alanBirim)
                    .HasConstraintName("FK_malzemeOzellikleri_birim3");

                entity.HasOne(d => d.birim)
                    .WithMany(p => p.malzemeOzellikleribirim)
                    .HasForeignKey(d => d.birimid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_malzemeOzellikleri_birim4");

                entity.HasOne(d => d.boyBirimNavigation)
                    .WithMany(p => p.malzemeOzellikleriboyBirimNavigation)
                    .HasForeignKey(d => d.boyBirim)
                    .HasConstraintName("FK_malzemeOzellikleri_birim1");

                entity.HasOne(d => d.enBirimNavigation)
                    .WithMany(p => p.malzemeOzelliklerienBirimNavigation)
                    .HasForeignKey(d => d.enBirim)
                    .HasConstraintName("FK_malzemeOzellikleri_birim");

                entity.HasOne(d => d.islemTurNavigation)
                    .WithMany(p => p.malzemeOzellikleri)
                    .HasForeignKey(d => d.islemTur)
                    .HasConstraintName("FK_malzemeOzellikleri_malzemeIslemTur");

                entity.HasOne(d => d.malzeme)
                    .WithMany(p => p.malzemeOzellikleri)
                    .HasForeignKey(d => d.malzemeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_malzemeOzellikleri_malzeme");

                entity.HasOne(d => d.yukseklikBirimNavigation)
                    .WithMany(p => p.malzemeOzellikleriyukseklikBirimNavigation)
                    .HasForeignKey(d => d.yukseklikBirim)
                    .HasConstraintName("FK_malzemeOzellikleri_birim2");
            });

            modelBuilder.Entity<nakliyeTur>(entity =>
            {
                entity.Property(e => e.adi).IsUnicode(false);

                entity.Property(e => e.evrenselkod).IsUnicode(false);

                entity.Property(e => e.kod).IsUnicode(false);
            });

            modelBuilder.Entity<odemePlan>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<odemePlanSatir>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<operasyonIstasyon>(entity =>
            {
                entity.HasOne(d => d.istasyon)
                    .WithMany(p => p.operasyonIstasyon)
                    .HasForeignKey(d => d.istasyonid)
                    .HasConstraintName("FK_operasyonIstasyon_istasyon");

                entity.HasOne(d => d.operasyon)
                    .WithMany(p => p.operasyonIstasyon)
                    .HasForeignKey(d => d.operasyonid)
                    .HasConstraintName("FK_operasyonIstasyon_operasyon");
            });

            modelBuilder.Entity<operasyonIstasyonUretim>(entity =>
            {
                entity.HasOne(d => d.istasyonUretim)
                    .WithMany(p => p.operasyonIstasyonUretim)
                    .HasForeignKey(d => d.istasyonUretimid)
                    .HasConstraintName("FK_operasyonIstasyonUretim_istasyonUretim");

                entity.HasOne(d => d.operasyon)
                    .WithMany(p => p.operasyonIstasyonUretim)
                    .HasForeignKey(d => d.operasyonid)
                    .HasConstraintName("FK_operasyonIstasyonUretim_operasyon");
            });

            modelBuilder.Entity<organizasyon>(entity =>
            {
                entity.HasKey(e => e.id)
                    .IsClustered(false);

                entity.HasOne(d => d.firma)
                    .WithMany(p => p.organizasyon)
                    .HasForeignKey(d => d.firmaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_organizasyon_firma");
            });

            modelBuilder.Entity<organizasyonSatir>(entity =>
            {
                entity.HasKey(e => e.id)
                    .IsClustered(false);

                entity.HasOne(d => d.organizasyon)
                    .WithMany(p => p.organizasyonSatir)
                    .HasForeignKey(d => d.organizasyonid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_organizasyonSatir_organizasyon");
            });

            modelBuilder.Entity<paketlemeKod>(entity =>
            {
                entity.Property(e => e.ad).IsUnicode(false);

                entity.Property(e => e.evrenselkod).IsUnicode(false);

                entity.Property(e => e.kod).IsUnicode(false);
            });

            modelBuilder.Entity<paraBirim>(entity =>
            {
                entity.Property(e => e.evrenselAdi).IsUnicode(false);
            });

            modelBuilder.Entity<personel>(entity =>
            {
                entity.HasKey(e => e.id)
                    .IsClustered(false);

                entity.Property(e => e.adi).IsUnicode(false);

                entity.Property(e => e.bolum).IsUnicode(false);

                entity.Property(e => e.okul).IsUnicode(false);

                entity.Property(e => e.sicilNo).IsUnicode(false);

                entity.Property(e => e.sigortaNo).IsUnicode(false);

                entity.Property(e => e.soyadi).IsUnicode(false);

                entity.Property(e => e.vergiNo).IsUnicode(false);

                entity.HasOne(d => d.askerlikDurum)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.askerlikDurumid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personel_askerlikDurum");

                entity.HasOne(d => d.departman)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.departmanid)
                    .HasConstraintName("FK_personel_departman");

                entity.HasOne(d => d.engellilikDurum)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.engellilikDurumid)
                    .HasConstraintName("FK_personel_engellilikDurum");

                entity.HasOne(d => d.firma)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.firmaid)
                    .HasConstraintName("FK_personel_firma");

                entity.HasOne(d => d.grup)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.grupid)
                    .HasConstraintName("FK_personel_grup");

                entity.HasOne(d => d.istenAyrilmaNeden)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.istenAyrilmaNedenid)
                    .HasConstraintName("FK_personel_istenAyrilmaNedenleri");

                entity.HasOne(d => d.kademe)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.kademeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personel_kademe");

                entity.HasOne(d => d.ogrenimDurum)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.ogrenimDurumid)
                    .HasConstraintName("FK_personel_ogrenimDurum");

                entity.HasOne(d => d.sigortaDurum)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.sigortaDurumid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personel_sigortaDurum");

                entity.HasOne(d => d.sigortaTur)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.sigortaTurid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personel_sigortaTur");

                entity.HasOne(d => d.sozlesmeTur)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.sozlesmeTurid)
                    .HasConstraintName("FK_personel_sozlesmeTur");

                entity.HasOne(d => d.sube)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.subeid)
                    .HasConstraintName("FK_personel_sube");

                entity.HasOne(d => d.unvan)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.unvanid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personel_unvan");

                entity.HasOne(d => d.vergiDaire)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.vergiDaireid)
                    .HasConstraintName("FK_personel_vergiDaire");
            });

            modelBuilder.Entity<personelAgi>(entity =>
            {
                entity.Property(e => e.personelid).ValueGeneratedNever();

                entity.HasOne(d => d.personel)
                    .WithOne(p => p.personelAgi)
                    .HasForeignKey<personelAgi>(d => d.personelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personelAgi_personel");
            });

            modelBuilder.Entity<personelBankaHesap>(entity =>
            {
                entity.Property(e => e.personelid).ValueGeneratedNever();

                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.personel)
                    .WithOne(p => p.personelBankaHesap)
                    .HasForeignKey<personelBankaHesap>(d => d.personelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personelBankaHesap_personel");
            });

            modelBuilder.Entity<personelDepartman>(entity =>
            {
                entity.HasKey(e => e.id)
                    .IsClustered(false);

                entity.HasOne(d => d.departman)
                    .WithMany(p => p.personelDepartman)
                    .HasForeignKey(d => d.departmanid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personelDepartman_departman");

                entity.HasOne(d => d.personel)
                    .WithMany(p => p.personelDepartman)
                    .HasForeignKey(d => d.personelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personelDepartman_personel");
            });

            modelBuilder.Entity<personelEmeklilik>(entity =>
            {
                entity.Property(e => e.personelid).ValueGeneratedNever();

                entity.HasOne(d => d.personel)
                    .WithOne(p => p.personelEmeklilik)
                    .HasForeignKey<personelEmeklilik>(d => d.personelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personelEmeklilik_personel");
            });

            modelBuilder.Entity<personelKimlik>(entity =>
            {
                entity.Property(e => e.personelid).ValueGeneratedNever();

                entity.HasOne(d => d.ilce)
                    .WithMany(p => p.personelKimlik)
                    .HasForeignKey(d => d.ilceid)
                    .HasConstraintName("FK_personelKimlik_ilce");

                entity.HasOne(d => d.il)
                    .WithMany(p => p.personelKimlik)
                    .HasForeignKey(d => d.ilid)
                    .HasConstraintName("FK_personelKimlik_il");

                entity.HasOne(d => d.kimlikTur)
                    .WithMany(p => p.personelKimlik)
                    .HasForeignKey(d => d.kimlikTurid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personelKimlik_kimlikTur");

                entity.HasOne(d => d.personel)
                    .WithOne(p => p.personelKimlik)
                    .HasForeignKey<personelKimlik>(d => d.personelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personelKimlik_personel");

                entity.HasOne(d => d.ulke)
                    .WithMany(p => p.personelKimlikulke)
                    .HasForeignKey(d => d.ulkeid)
                    .HasConstraintName("FK_personelKimlik_ulke");

                entity.HasOne(d => d.uyruk)
                    .WithMany(p => p.personelKimlikuyruk)
                    .HasForeignKey(d => d.uyrukid)
                    .HasConstraintName("FK_personelKimlik_uyruk");
            });

            modelBuilder.Entity<personelMaas>(entity =>
            {
                entity.Property(e => e.personelid).ValueGeneratedNever();

                entity.HasOne(d => d.maasParaBirim)
                    .WithMany(p => p.personelMaas)
                    .HasForeignKey(d => d.maasParaBirimid)
                    .HasConstraintName("FK_personelMaas_maasParaBirim");

                entity.HasOne(d => d.personelMaasOdemeTur)
                    .WithMany(p => p.personelMaas)
                    .HasForeignKey(d => d.personelMaasOdemeTurid)
                    .HasConstraintName("FK_personelMaas_personelMaasOdemeTur");

                entity.HasOne(d => d.personelMaasPeriyot)
                    .WithMany(p => p.personelMaas)
                    .HasForeignKey(d => d.personelMaasPeriyotid)
                    .HasConstraintName("FK_personelMaas_personelMaasPeriyot");

                entity.HasOne(d => d.personel)
                    .WithOne(p => p.personelMaas)
                    .HasForeignKey<personelMaas>(d => d.personelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personelMaas_personel");
            });

            modelBuilder.Entity<personelTabiKanun>(entity =>
            {
                entity.Property(e => e.personelid).ValueGeneratedNever();

                entity.HasOne(d => d.personelKanun)
                    .WithMany(p => p.personelTabiKanun)
                    .HasForeignKey(d => d.personelKanunid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personelTabiKanun_personelKanun");

                entity.HasOne(d => d.personel)
                    .WithOne(p => p.personelTabiKanun)
                    .HasForeignKey<personelTabiKanun>(d => d.personelid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personelTabiKanun_personel");
            });

            modelBuilder.Entity<postaKodu>(entity =>
            {
                entity.HasKey(e => e.id)
                    .IsClustered(false);
            });

            modelBuilder.Entity<recete>(entity =>
            {
                entity.Property(e => e.aciklama).IsUnicode(false);

                entity.Property(e => e.kodu).IsUnicode(false);

                entity.Property(e => e.not).IsUnicode(false);

                entity.HasOne(d => d.anareceteNavigation)
                    .WithMany(p => p.InverseanareceteNavigation)
                    .HasForeignKey(d => d.anarecete)
                    .HasConstraintName("FK_recete_recete");

                entity.HasOne(d => d.rota)
                    .WithMany(p => p.recete)
                    .HasForeignKey(d => d.rotaid)
                    .HasConstraintName("FK_recete_rota");
            });

            modelBuilder.Entity<rota>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<stokHareket>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.depo)
                    .WithMany(p => p.stokHareket)
                    .HasForeignKey(d => d.depoid)
                    .HasConstraintName("FK_stokHareket_depo");

                entity.HasOne(d => d.malzeme)
                    .WithMany(p => p.stokHareket)
                    .HasForeignKey(d => d.malzemeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_stokHareket_malzeme");

                entity.HasOne(d => d.stokHareketTur)
                    .WithMany(p => p.stokHareket)
                    .HasForeignKey(d => d.stokHareketTurid)
                    .HasConstraintName("FK_stokHareket_stokHareketTur");
            });

            modelBuilder.Entity<stokHareketTur>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<stokTur>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<sube>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.firma)
                    .WithMany(p => p.sube)
                    .HasForeignKey(d => d.firmaid)
                    .HasConstraintName("FK_sube_firma");
            });

            modelBuilder.Entity<tevkifatKodu>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ulke>(entity =>
            {
                entity.HasKey(e => e.id)
                    .IsClustered(false);

                entity.Property(e => e.id).ValueGeneratedNever();
            });

            modelBuilder.Entity<vergiDaire>(entity =>
            {
                entity.Property(e => e.ad).IsUnicode(false);

                entity.Property(e => e.kod).IsUnicode(false);
            });

            modelBuilder.Entity<yetkiGruplariDetay>(entity =>
            {
                entity.HasOne(d => d.grup)
                    .WithMany(p => p.yetkiGruplariDetay)
                    .HasForeignKey(d => d.grupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_yetkiGruplariDetay_YetkiGruplari");

                entity.HasOne(d => d.yetki)
                    .WithMany(p => p.yetkiGruplariDetay)
                    .HasForeignKey(d => d.yetkiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_yetkiGruplariDetay_Yetkiler");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
