using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ERP.WebApi.Entities
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
        public virtual DbSet<askerlikDurum> askerlikDurum { get; set; }
        public virtual DbSet<banka> banka { get; set; }
        public virtual DbSet<bankaAdres> bankaAdres { get; set; }
        public virtual DbSet<bankaHesap> bankaHesap { get; set; }
        public virtual DbSet<bankaHesapTur> bankaHesapTur { get; set; }
        public virtual DbSet<bolum> bolum { get; set; }
        public virtual DbSet<departman> departman { get; set; }
        public virtual DbSet<eFaturaTur> eFaturaTur { get; set; }
        public virtual DbSet<ekGelirGider> ekGelirGider { get; set; }
        public virtual DbSet<ekGelirGiderTur> ekGelirGiderTur { get; set; }
        public virtual DbSet<engellilikDurum> engellilikDurum { get; set; }
        public virtual DbSet<fabrika> fabrika { get; set; }
        public virtual DbSet<firma> firma { get; set; }
        public virtual DbSet<firma1> firma1 { get; set; }
        public virtual DbSet<firma2> firma2 { get; set; }
        public virtual DbSet<firmaAdres> firmaAdres { get; set; }
        public virtual DbSet<firmaAdresTur> firmaAdresTur { get; set; }
        public virtual DbSet<firmaBanka> firmaBanka { get; set; }
        public virtual DbSet<firmaIletisim> firmaIletisim { get; set; }
        public virtual DbSet<firmaIletisimTur> firmaIletisimTur { get; set; }
        public virtual DbSet<firmaTur> firmaTur { get; set; }
        public virtual DbSet<firmaYon> firmaYon { get; set; }
        public virtual DbSet<fiyatListeTur> fiyatListeTur { get; set; }
        public virtual DbSet<gtip> gtip { get; set; }
        public virtual DbSet<gtipTanim> gtipTanim { get; set; }
        public virtual DbSet<il> il { get; set; }
        public virtual DbSet<ilce> ilce { get; set; }
        public virtual DbSet<kademe> kademe { get; set; }
        public virtual DbSet<kanGrup> kanGrup { get; set; }
        public virtual DbSet<kimlikTur> kimlikTur { get; set; }
        public virtual DbSet<kullanici> kullanici { get; set; }
        public virtual DbSet<medeniHal> medeniHal { get; set; }
        public virtual DbSet<meslek> meslek { get; set; }
        public virtual DbSet<nakliyeTur> nakliyeTur { get; set; }
        public virtual DbSet<odemePlan> odemePlan { get; set; }
        public virtual DbSet<odemePlanSatir> odemePlanSatir { get; set; }
        public virtual DbSet<ogrenimDurum> ogrenimDurum { get; set; }
        public virtual DbSet<organizasyon> organizasyon { get; set; }
        public virtual DbSet<organizasyonSatir> organizasyonSatir { get; set; }
        public virtual DbSet<ozelSigortaTur> ozelSigortaTur { get; set; }
        public virtual DbSet<paketlemeKod> paketlemeKod { get; set; }
        public virtual DbSet<paraBirim> paraBirim { get; set; }
        public virtual DbSet<paraBirimiTur> paraBirimiTur { get; set; }
        public virtual DbSet<personel> personel { get; set; }
        public virtual DbSet<personelAgi> personelAgi { get; set; }
        public virtual DbSet<personelBankaHesap> personelBankaHesap { get; set; }
        public virtual DbSet<personelDepartman> personelDepartman { get; set; }
        public virtual DbSet<personelDiger> personelDiger { get; set; }
        public virtual DbSet<personelEmeklilik> personelEmeklilik { get; set; }
        public virtual DbSet<personelKanun> personelKanun { get; set; }
        public virtual DbSet<personelKimlik> personelKimlik { get; set; }
        public virtual DbSet<personelMaas> personelMaas { get; set; }
        public virtual DbSet<personelMaasOdemeTur> personelMaasOdemeTur { get; set; }
        public virtual DbSet<personelMaasPeriyot> personelMaasPeriyot { get; set; }
        public virtual DbSet<personelMesaiTur> personelMesaiTur { get; set; }
        public virtual DbSet<personelTabiKanun> personelTabiKanun { get; set; }
        public virtual DbSet<postaKodu> postaKodu { get; set; }
        public virtual DbSet<sigortaDurum> sigortaDurum { get; set; }
        public virtual DbSet<sigortaTur> sigortaTur { get; set; }
        public virtual DbSet<siparisTur> siparisTur { get; set; }
        public virtual DbSet<sosyalGuvenlikKurum> sosyalGuvenlikKurum { get; set; }
        public virtual DbSet<sozlesmeTur> sozlesmeTur { get; set; }
        public virtual DbSet<ulke> ulke { get; set; }
        public virtual DbSet<unvan> unvan { get; set; }
        public virtual DbSet<vergiDaire> vergiDaire { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=185.198.74.119;Database=ERPDB;User Id=sserp; Password=Erp-post*-ss;Trusted_Connection=False;");
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
            });

            modelBuilder.Entity<bankaHesapTur>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<bolum>(entity =>
            {
                entity.HasKey(e => e.id)
                    .IsClustered(false);
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

            modelBuilder.Entity<eFaturaTur>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ekGelirGider>(entity =>
            {
                entity.HasOne(d => d.ekGelirGiderTur)
                    .WithMany(p => p.ekGelirGider)
                    .HasForeignKey(d => d.ekGelirGiderTurid)
                    .HasConstraintName("FK_ekGelirGider_ekGelirGiderTur");

                entity.HasOne(d => d.sosyalGuvenlikKurum)
                    .WithMany(p => p.ekGelirGider)
                    .HasForeignKey(d => d.sosyalGuvenlikKurumid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ekGelirGider_sosyalGuvenlikKurum");
            });

            modelBuilder.Entity<fabrika>(entity =>
            {
                entity.HasKey(e => e.id)
                    .IsClustered(false);
            });

            modelBuilder.Entity<firma>(entity =>
            {
                entity.Property(e => e.adi).IsUnicode(false);

                entity.Property(e => e.eFaturaAdres).IsUnicode(false);

                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.kodu).IsUnicode(false);

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");

                entity.Property(e => e.vergiDaire).IsUnicode(false);

                entity.Property(e => e.vergiNo).IsUnicode(false);

                entity.HasOne(d => d.firmaTur)
                    .WithMany(p => p.firma)
                    .HasForeignKey(d => d.firmaTurid)
                    .HasConstraintName("FK_firma_firmaTur");

                entity.HasOne(d => d.firmaYon)
                    .WithMany(p => p.firma)
                    .HasForeignKey(d => d.firmaYonid)
                    .HasConstraintName("FK_firma_firmaYon");

                entity.HasOne(d => d.firmaNavigation)
                    .WithMany(p => p.InversefirmaNavigation)
                    .HasForeignKey(d => d.firmaid)
                    .HasConstraintName("FK_firma_firma");

                entity.HasOne(d => d.nakliyeTur)
                    .WithMany(p => p.firma)
                    .HasForeignKey(d => d.nakliyeTurid)
                    .HasConstraintName("FK_firma_nakliyeTur");

                entity.HasOne(d => d.odemePlan)
                    .WithMany(p => p.firma)
                    .HasForeignKey(d => d.odemePlanid)
                    .HasConstraintName("FK_firma_odemePlan");

                entity.HasOne(d => d.paraBirim)
                    .WithMany(p => p.firma)
                    .HasForeignKey(d => d.paraBirimid)
                    .HasConstraintName("FK_firma_paraBirim");
            });

            modelBuilder.Entity<firma1>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<firma2>(entity =>
            {
                entity.HasKey(e => e.id)
                    .IsClustered(false);
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

            modelBuilder.Entity<firmaBanka>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.firma)
                    .WithMany(p => p.firmaBanka)
                    .HasForeignKey(d => d.firmaid)
                    .HasConstraintName("FK_firmaBanka_firma");
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

            modelBuilder.Entity<gtip>(entity =>
            {
                entity.Property(e => e.kod).IsUnicode(false);
            });

            modelBuilder.Entity<gtipTanim>(entity =>
            {
                entity.Property(e => e.adi).IsUnicode(false);
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

                entity.HasOne(d => d.engellilikDurum)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.engellilikDurumid)
                    .HasConstraintName("FK_personel_engellilikDurum");

                entity.HasOne(d => d.firma)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.firmaid)
                    .HasConstraintName("FK_personel_firma");

                entity.HasOne(d => d.kademe)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.kademeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personel_kademe");

                entity.HasOne(d => d.meslek)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.meslekid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personel_meslek");

                entity.HasOne(d => d.ogrenimDurum)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.ogrenimDurumid)
                    .HasConstraintName("FK_personel_ogrenimDurum");

                entity.HasOne(d => d.personelBankaHesap)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.personelBankaHesapid)
                    .HasConstraintName("FK_personel_personelBankaHesap");

                entity.HasOne(d => d.personelKimlik)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.personelKimlikid)
                    .HasConstraintName("FK_personelKimlik_personel");

                entity.HasOne(d => d.personelMaas)
                    .WithMany(p => p.personel)
                    .HasForeignKey(d => d.personelMaasid)
                    .HasConstraintName("FK_personel_personelMaas");

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

            modelBuilder.Entity<personelBankaHesap>(entity =>
            {
                entity.Property(e => e.iptalmi).HasDefaultValueSql("((0))");

                entity.Property(e => e.silindimi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<personelDepartman>(entity =>
            {
                entity.HasKey(e => e.id)
                    .IsClustered(false);
            });

            modelBuilder.Entity<personelKimlik>(entity =>
            {
                entity.HasOne(d => d.ilce)
                    .WithMany(p => p.personelKimlik)
                    .HasForeignKey(d => d.ilceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personelKimlik_ilce");

                entity.HasOne(d => d.il)
                    .WithMany(p => p.personelKimlik)
                    .HasForeignKey(d => d.ilid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personelKimlik_il");

                entity.HasOne(d => d.kanGrup)
                    .WithMany(p => p.personelKimlik)
                    .HasForeignKey(d => d.kanGrupid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personelKimlik_kanGrup");

                entity.HasOne(d => d.kimlikTur)
                    .WithMany(p => p.personelKimlik)
                    .HasForeignKey(d => d.kimlikTurid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personelKimlik_kimlikTur");

                entity.HasOne(d => d.medeniHal)
                    .WithMany(p => p.personelKimlik)
                    .HasForeignKey(d => d.medeniHalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personelKimlik_medeniHal");

                entity.HasOne(d => d.ulke)
                    .WithMany(p => p.personelKimlikulke)
                    .HasForeignKey(d => d.ulkeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personelKimlik_ulke");

                entity.HasOne(d => d.uyruk)
                    .WithMany(p => p.personelKimlikuyruk)
                    .HasForeignKey(d => d.uyrukid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_personelKimlik_uyruk");
            });

            modelBuilder.Entity<personelMaas>(entity =>
            {
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
            });

            modelBuilder.Entity<personelTabiKanun>(entity =>
            {
                entity.HasOne(d => d.personelKanun)
                    .WithMany(p => p.personelTabiKanun)
                    .HasForeignKey(d => d.personelKanunid)
                    .HasConstraintName("FK_personelTabiKanun_personelKanun");

                entity.HasOne(d => d.personel)
                    .WithMany(p => p.personelTabiKanun)
                    .HasForeignKey(d => d.personelid)
                    .HasConstraintName("FK_personelTabiKanun_personel");
            });

            modelBuilder.Entity<postaKodu>(entity =>
            {
                entity.HasKey(e => e.id)
                    .IsClustered(false);
            });

            modelBuilder.Entity<ulke>(entity =>
            {
                entity.HasKey(e => e.id)
                    .IsClustered(false);
            });

            modelBuilder.Entity<vergiDaire>(entity =>
            {
                entity.Property(e => e.ad).IsUnicode(false);

                entity.Property(e => e.kod).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
