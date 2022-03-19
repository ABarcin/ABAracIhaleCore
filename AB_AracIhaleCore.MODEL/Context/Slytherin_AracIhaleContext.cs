using System;
using AB_AracIhaleCore.MODEL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AB_AracIhaleCore.MODEL.Context
{
    public partial class Slytherin_AracIhaleContext : DbContext
    {
        public Slytherin_AracIhaleContext()
        {
        }

        public Slytherin_AracIhaleContext(DbContextOptions<Slytherin_AracIhaleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ArabaModel> ArabaModels { get; set; }
        public virtual DbSet<Arac> Aracs { get; set; }
        public virtual DbSet<AracFiyat> AracFiyats { get; set; }
        public virtual DbSet<AracOzellik> AracOzelliks { get; set; }
        public virtual DbSet<AracParca> AracParcas { get; set; }
        public virtual DbSet<AracStatu> AracStatus { get; set; }
        public virtual DbSet<AracTeklif> AracTeklifs { get; set; }
        public virtual DbSet<AracTramer> AracTramers { get; set; }
        public virtual DbSet<AracTramerDetay> AracTramerDetays { get; set; }
        public virtual DbSet<Calisan> Calisans { get; set; }
        public virtual DbSet<CalisanIletisim> CalisanIletisims { get; set; }
        public virtual DbSet<Ekspertiz> Ekspertizs { get; set; }
        public virtual DbSet<FavoriArama> FavoriAramas { get; set; }
        public virtual DbSet<FavoriAramaKriter> FavoriAramaKriters { get; set; }
        public virtual DbSet<FavoriIlan> FavoriIlans { get; set; }
        public virtual DbSet<FavoriOzellik> FavoriOzelliks { get; set; }
        public virtual DbSet<Firma> Firmas { get; set; }
        public virtual DbSet<FirmaIletisim> FirmaIletisims { get; set; }
        public virtual DbSet<FirmaTip> FirmaTips { get; set; }
        public virtual DbSet<Fotograf> Fotografs { get; set; }
        public virtual DbSet<Ihale> Ihales { get; set; }
        public virtual DbSet<IhaleArac> IhaleAracs { get; set; }
        public virtual DbSet<IhaleStatu> IhaleStatus { get; set; }
        public virtual DbSet<IhaleSurec> IhaleSurecs { get; set; }
        public virtual DbSet<Ilan> Ilans { get; set; }
        public virtual DbSet<Ilce> Ilces { get; set; }
        public virtual DbSet<IletisimTur> IletisimTurs { get; set; }
        public virtual DbSet<Kullanici> Kullanicis { get; set; }
        public virtual DbSet<KullaniciIletisim> KullaniciIletisims { get; set; }
        public virtual DbSet<KullaniciTip> KullaniciTips { get; set; }
        public virtual DbSet<KurumsalIhale> KurumsalIhales { get; set; }
        public virtual DbSet<KurumsalKullanici> KurumsalKullanicis { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<LogError> LogErrors { get; set; }
        public virtual DbSet<Marka> Markas { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<Ozellik> Ozelliks { get; set; }
        public virtual DbSet<OzellikBilgi> OzellikBilgis { get; set; }
        public virtual DbSet<Paket> Pakets { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<RolYetki> RolYetkis { get; set; }
        public virtual DbSet<Sayfa> Sayfas { get; set; }
        public virtual DbSet<Sehir> Sehirs { get; set; }
        public virtual DbSet<SehirIlce> SehirIlces { get; set; }
        public virtual DbSet<Statu> Status { get; set; }
        public virtual DbSet<Stok> Stoks { get; set; }
        public virtual DbSet<TramerDetay> TramerDetays { get; set; }
        public virtual DbSet<Yetki> Yetkis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Slytherin_AracIhale;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<ArabaModel>(entity =>
            {
                entity.HasKey(e => e.ModelId)
                    .HasName("PK_dbo.ArabaModel");

                entity.ToTable("ArabaModel");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.Ad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MarkaId).HasColumnName("MarkaID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UstModelId).HasColumnName("UstModelID");
            });

            modelBuilder.Entity<Arac>(entity =>
            {
                entity.ToTable("Arac");

                entity.HasIndex(e => e.KullaniciId, "IX_KullaniciID");

                entity.HasIndex(e => e.MarkaId, "IX_MarkaID");

                entity.HasIndex(e => e.ModelId, "IX_ModelID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.MarkaId).HasColumnName("MarkaID");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.Aracs)
                    .HasForeignKey(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Arac_dbo.Kullanici_KullaniciID");

                entity.HasOne(d => d.Marka)
                    .WithMany(p => p.Aracs)
                    .HasForeignKey(d => d.MarkaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Arac_dbo.Marka_MarkaID");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Aracs)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Arac_dbo.ArabaModel_ModelID");
            });

            modelBuilder.Entity<AracFiyat>(entity =>
            {
                entity.ToTable("AracFiyat");

                entity.HasIndex(e => e.AracId, "IX_AracID");

                entity.Property(e => e.AracFiyatId).HasColumnName("AracFiyatID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Fiyat).HasColumnType("money");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.AracFiyats)
                    .HasForeignKey(d => d.AracId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AracFiyat_dbo.Arac_AracID");
            });

            modelBuilder.Entity<AracOzellik>(entity =>
            {
                entity.ToTable("AracOzellik");

                entity.HasIndex(e => e.AracId, "IX_AracID");

                entity.HasIndex(e => e.OzellikBilgiId, "IX_OzellikBilgiID");

                entity.Property(e => e.AracOzellikId).HasColumnName("AracOzellikID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OzellikBilgiId).HasColumnName("OzellikBilgiID");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.AracOzelliks)
                    .HasForeignKey(d => d.AracId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AracOzellik_dbo.Arac_AracID");

                entity.HasOne(d => d.OzellikBilgi)
                    .WithMany(p => p.AracOzelliks)
                    .HasForeignKey(d => d.OzellikBilgiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AracOzellik_dbo.OzellikBilgi_OzellikBilgiID");
            });

            modelBuilder.Entity<AracParca>(entity =>
            {
                entity.ToTable("AracParca");

                entity.Property(e => e.AracParcaId).HasColumnName("AracParcaID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParcaAd).IsRequired();
            });

            modelBuilder.Entity<AracStatu>(entity =>
            {
                entity.ToTable("AracStatu");

                entity.HasIndex(e => e.AracId, "IX_AracID");

                entity.HasIndex(e => e.StatuId, "IX_StatuID");

                entity.Property(e => e.AracStatuId).HasColumnName("AracStatuID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StatuId).HasColumnName("StatuID");

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.AracStatus)
                    .HasForeignKey(d => d.AracId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AracStatu_dbo.Arac_AracID");

                entity.HasOne(d => d.Statu)
                    .WithMany(p => p.AracStatus)
                    .HasForeignKey(d => d.StatuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AracStatu_dbo.Statu_StatuID");
            });

            modelBuilder.Entity<AracTeklif>(entity =>
            {
                entity.ToTable("AracTeklif");

                entity.HasIndex(e => e.IhaleAracId, "IX_IhaleAracID");

                entity.HasIndex(e => e.KullaniciId, "IX_KullaniciID");

                entity.Property(e => e.AracTeklifId).HasColumnName("AracTeklifID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IhaleAracId).HasColumnName("IhaleAracID");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.Property(e => e.TeklifFiyat).HasColumnType("money");

                entity.HasOne(d => d.IhaleArac)
                    .WithMany(p => p.AracTeklifs)
                    .HasForeignKey(d => d.IhaleAracId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AracTeklif_dbo.IhaleArac_IhaleAracID");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.AracTeklifs)
                    .HasForeignKey(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AracTeklif_dbo.Kullanici_KullaniciID");
            });

            modelBuilder.Entity<AracTramer>(entity =>
            {
                entity.ToTable("AracTramer");

                entity.HasIndex(e => e.AracId, "IX_AracID");

                entity.Property(e => e.AracTramerId).HasColumnName("AracTramerID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Fiyat).HasColumnType("money");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.AracTramers)
                    .HasForeignKey(d => d.AracId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AracTramer_dbo.Arac_AracID");
            });

            modelBuilder.Entity<AracTramerDetay>(entity =>
            {
                entity.ToTable("AracTramerDetay");

                entity.HasIndex(e => e.AracParcaId, "IX_AracParcaID");

                entity.HasIndex(e => e.AracTramerId, "IX_AracTramerID");

                entity.HasIndex(e => e.TramerDetayId, "IX_TramerDetayID");

                entity.Property(e => e.AracTramerDetayId).HasColumnName("AracTramerDetayID");

                entity.Property(e => e.AracParcaId).HasColumnName("AracParcaID");

                entity.Property(e => e.AracTramerId).HasColumnName("AracTramerID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TramerDetayId).HasColumnName("TramerDetayID");

                entity.HasOne(d => d.AracParca)
                    .WithMany(p => p.AracTramerDetays)
                    .HasForeignKey(d => d.AracParcaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AracTramerDetay_dbo.AracParca_AracParcaID");

                entity.HasOne(d => d.AracTramer)
                    .WithMany(p => p.AracTramerDetays)
                    .HasForeignKey(d => d.AracTramerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AracTramerDetay_dbo.AracTramer_AracTramerID");

                entity.HasOne(d => d.TramerDetay)
                    .WithMany(p => p.AracTramerDetays)
                    .HasForeignKey(d => d.TramerDetayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AracTramerDetay_dbo.TramerDetay_TramerDetayID");
            });

            modelBuilder.Entity<Calisan>(entity =>
            {
                entity.ToTable("Calisan");

                entity.HasIndex(e => e.KullaniciAd, "IX_KullaniciAd")
                    .IsUnique();

                entity.HasIndex(e => e.RolId, "IX_RolID");

                entity.Property(e => e.CalisanId).HasColumnName("CalisanID");

                entity.Property(e => e.Ad).IsRequired();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.KullaniciAd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.Property(e => e.Sifre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Soyad).IsRequired();

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Calisans)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Calisan_dbo.Rol_RolID");
            });

            modelBuilder.Entity<CalisanIletisim>(entity =>
            {
                entity.ToTable("CalisanIletisim");

                entity.HasIndex(e => e.CalisanId, "IX_CalisanID");

                entity.HasIndex(e => e.IletisimTuruId, "IX_IletisimTuruID");

                entity.Property(e => e.CalisanIletisimId).HasColumnName("CalisanIletisimID");

                entity.Property(e => e.CalisanId).HasColumnName("CalisanID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IletisimBilgi).IsRequired();

                entity.Property(e => e.IletisimTuruId).HasColumnName("IletisimTuruID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Calisan)
                    .WithMany(p => p.CalisanIletisims)
                    .HasForeignKey(d => d.CalisanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CalisanIletisim_dbo.Calisan_CalisanID");

                entity.HasOne(d => d.IletisimTuru)
                    .WithMany(p => p.CalisanIletisims)
                    .HasForeignKey(d => d.IletisimTuruId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CalisanIletisim_dbo.IletisimTur_IletisimTuruID");
            });

            modelBuilder.Entity<Ekspertiz>(entity =>
            {
                entity.HasKey(e => new { e.EkspertizId, e.Ad, e.Adres })
                    .HasName("PK_dbo.Ekspertiz");

                entity.ToTable("Ekspertiz");

                entity.Property(e => e.EkspertizId).HasColumnName("EkspertizID");

                entity.Property(e => e.Ad)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Adres)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FavoriArama>(entity =>
            {
                entity.ToTable("FavoriArama");

                entity.HasIndex(e => e.FavoriAramaKriterId, "IX_FavoriAramaKriterID");

                entity.HasIndex(e => e.KullaniciId, "IX_KullaniciID");

                entity.Property(e => e.FavoriAramaId).HasColumnName("FavoriAramaID");

                entity.Property(e => e.Ad).IsRequired();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FavoriAramaKriterId).HasColumnName("FavoriAramaKriterID");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.FavoriAramaKriter)
                    .WithMany(p => p.FavoriAramas)
                    .HasForeignKey(d => d.FavoriAramaKriterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FavoriArama_dbo.FavoriAramaKriter_FavoriAramaKriterID");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.FavoriAramas)
                    .HasForeignKey(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FavoriArama_dbo.Kullanici_KullaniciID");
            });

            modelBuilder.Entity<FavoriAramaKriter>(entity =>
            {
                entity.ToTable("FavoriAramaKriter");

                entity.HasIndex(e => e.MarkaId, "IX_MarkaID");

                entity.HasIndex(e => e.ModelId, "IX_ModelID");

                entity.Property(e => e.FavoriAramaKriterId).HasColumnName("FavoriAramaKriterID");

                entity.Property(e => e.BaslangicFiyat).HasColumnType("money");

                entity.Property(e => e.BaslangicKm).HasColumnName("BaslangicKM");

                entity.Property(e => e.BaslangicYil).HasColumnType("datetime");

                entity.Property(e => e.BitisFiyat).HasColumnType("money");

                entity.Property(e => e.BitisKm).HasColumnName("BitisKM");

                entity.Property(e => e.BitisYil).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MarkaId).HasColumnName("MarkaID");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Marka)
                    .WithMany(p => p.FavoriAramaKriters)
                    .HasForeignKey(d => d.MarkaId)
                    .HasConstraintName("FK_dbo.FavoriAramaKriter_dbo.Marka_MarkaID");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.FavoriAramaKriters)
                    .HasForeignKey(d => d.ModelId)
                    .HasConstraintName("FK_dbo.FavoriAramaKriter_dbo.ArabaModel_ModelID");
            });

            modelBuilder.Entity<FavoriIlan>(entity =>
            {
                entity.ToTable("FavoriIlan");

                entity.HasIndex(e => e.IlanId, "IX_IlanID");

                entity.HasIndex(e => e.KullaniciId, "IX_KullaniciID");

                entity.Property(e => e.FavoriIlanId).HasColumnName("FavoriIlanID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IlanId).HasColumnName("IlanID");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.HasOne(d => d.Ilan)
                    .WithMany(p => p.FavoriIlans)
                    .HasForeignKey(d => d.IlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FavoriIlan_dbo.Ilan_IlanID");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.FavoriIlans)
                    .HasForeignKey(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FavoriIlan_dbo.Kullanici_KullaniciID");
            });

            modelBuilder.Entity<FavoriOzellik>(entity =>
            {
                entity.ToTable("FavoriOzellik");

                entity.HasIndex(e => e.FavoriAramaKriterId, "IX_FavoriAramaKriterID");

                entity.HasIndex(e => e.OzellikBilgiId, "IX_OzellikBilgiID");

                entity.Property(e => e.FavoriOzellikId).HasColumnName("FavoriOzellikID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FavoriAramaKriterId).HasColumnName("FavoriAramaKriterID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OzellikBilgiId).HasColumnName("OzellikBilgiID");

                entity.HasOne(d => d.FavoriAramaKriter)
                    .WithMany(p => p.FavoriOzelliks)
                    .HasForeignKey(d => d.FavoriAramaKriterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FavoriOzellik_dbo.FavoriAramaKriter_FavoriAramaKriterID");

                entity.HasOne(d => d.OzellikBilgi)
                    .WithMany(p => p.FavoriOzelliks)
                    .HasForeignKey(d => d.OzellikBilgiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FavoriOzellik_dbo.OzellikBilgi_OzellikBilgiID");
            });

            modelBuilder.Entity<Firma>(entity =>
            {
                entity.ToTable("Firma");

                entity.HasIndex(e => e.FirmaTipId, "IX_FirmaTipID");

                entity.HasIndex(e => e.PaketId, "IX_PaketID");

                entity.HasIndex(e => e.SehirIlceId, "IX_SehirIlceID");

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FirmaTipId).HasColumnName("FirmaTipID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaketId).HasColumnName("PaketID");

                entity.Property(e => e.SehirIlceId).HasColumnName("SehirIlceID");

                entity.HasOne(d => d.FirmaTip)
                    .WithMany(p => p.Firmas)
                    .HasForeignKey(d => d.FirmaTipId)
                    .HasConstraintName("FK_dbo.Firma_dbo.FirmaTip_FirmaTipID");

                entity.HasOne(d => d.Paket)
                    .WithMany(p => p.Firmas)
                    .HasForeignKey(d => d.PaketId)
                    .HasConstraintName("FK_dbo.Firma_dbo.Paket_PaketID");

                entity.HasOne(d => d.SehirIlce)
                    .WithMany(p => p.Firmas)
                    .HasForeignKey(d => d.SehirIlceId)
                    .HasConstraintName("FK_dbo.Firma_dbo.SehirIlce_SehirIlceID");
            });

            modelBuilder.Entity<FirmaIletisim>(entity =>
            {
                entity.ToTable("FirmaIletisim");

                entity.HasIndex(e => e.FirmaId, "IX_FirmaID");

                entity.HasIndex(e => e.IletisimTuruId, "IX_IletisimTuruID");

                entity.Property(e => e.FirmaIletisimId).HasColumnName("FirmaIletisimID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.IletisimBilgi).IsRequired();

                entity.Property(e => e.IletisimTuruId).HasColumnName("IletisimTuruID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Firma)
                    .WithMany(p => p.FirmaIletisims)
                    .HasForeignKey(d => d.FirmaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FirmaIletisim_dbo.Firma_FirmaID");

                entity.HasOne(d => d.IletisimTuru)
                    .WithMany(p => p.FirmaIletisims)
                    .HasForeignKey(d => d.IletisimTuruId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FirmaIletisim_dbo.IletisimTur_IletisimTuruID");
            });

            modelBuilder.Entity<FirmaTip>(entity =>
            {
                entity.ToTable("FirmaTip");

                entity.Property(e => e.FirmaTipId).HasColumnName("FirmaTipID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fotograf>(entity =>
            {
                entity.ToTable("Fotograf");

                entity.HasIndex(e => e.AracId, "IX_AracID");

                entity.Property(e => e.FotografId).HasColumnName("FotografID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FotoPath).IsRequired();

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.Fotografs)
                    .HasForeignKey(d => d.AracId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Fotograf_dbo.Arac_AracID");
            });

            modelBuilder.Entity<Ihale>(entity =>
            {
                entity.ToTable("Ihale");

                entity.HasIndex(e => e.CalisanId, "IX_CalisanID");

                entity.HasIndex(e => e.KullaniciTipId, "IX_KullaniciTipID");

                entity.Property(e => e.IhaleId).HasColumnName("IhaleID");

                entity.Property(e => e.CalisanId).HasColumnName("CalisanID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IhaleAdi)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.IhaleBaslangic).HasColumnType("date");

                entity.Property(e => e.IhaleBitis).HasColumnType("date");

                entity.Property(e => e.KullaniciTipId).HasColumnName("KullaniciTipID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Calisan)
                    .WithMany(p => p.Ihales)
                    .HasForeignKey(d => d.CalisanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Ihale_dbo.Calisan_CalisanID");

                entity.HasOne(d => d.KullaniciTip)
                    .WithMany(p => p.Ihales)
                    .HasForeignKey(d => d.KullaniciTipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Ihale_dbo.KullaniciTip_KullaniciTipID");
            });

            modelBuilder.Entity<IhaleArac>(entity =>
            {
                entity.ToTable("IhaleArac");

                entity.HasIndex(e => e.AracId, "IX_AracID");

                entity.HasIndex(e => e.IhaleId, "IX_IhaleID");

                entity.Property(e => e.IhaleAracId).HasColumnName("IhaleAracID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IhaleBaslangicFiyat).HasColumnType("money");

                entity.Property(e => e.IhaleId).HasColumnName("IhaleID");

                entity.Property(e => e.MinAlimFiyati).HasColumnType("money");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.IhaleAracs)
                    .HasForeignKey(d => d.AracId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.IhaleArac_dbo.Arac_AracID");

                entity.HasOne(d => d.Ihale)
                    .WithMany(p => p.IhaleAracs)
                    .HasForeignKey(d => d.IhaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.IhaleArac_dbo.Ihale_IhaleID");
            });

            modelBuilder.Entity<IhaleStatu>(entity =>
            {
                entity.ToTable("IhaleStatu");

                entity.Property(e => e.IhaleStatuId).HasColumnName("IhaleStatuID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Durum).IsRequired();

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<IhaleSurec>(entity =>
            {
                entity.HasKey(e => e.StatuIhaleId)
                    .HasName("PK_dbo.IhaleSurec");

                entity.ToTable("IhaleSurec");

                entity.HasIndex(e => e.IhaleId, "IX_IhaleID");

                entity.HasIndex(e => e.IhaleStatuId, "IX_IhaleStatuID");

                entity.Property(e => e.StatuIhaleId).HasColumnName("StatuIhaleID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IhaleId).HasColumnName("IhaleID");

                entity.Property(e => e.IhaleStatuId).HasColumnName("IhaleStatuID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.HasOne(d => d.Ihale)
                    .WithMany(p => p.IhaleSurecs)
                    .HasForeignKey(d => d.IhaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.IhaleSurec_dbo.Ihale_IhaleID");

                entity.HasOne(d => d.IhaleStatu)
                    .WithMany(p => p.IhaleSurecs)
                    .HasForeignKey(d => d.IhaleStatuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.IhaleSurec_dbo.IhaleStatu_IhaleStatuID");
            });

            modelBuilder.Entity<Ilan>(entity =>
            {
                entity.ToTable("Ilan");

                entity.HasIndex(e => e.AracId, "IX_AracID");

                entity.Property(e => e.IlanId).HasColumnName("IlanID");

                entity.Property(e => e.Aciklama)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.Baslik)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.Ilans)
                    .HasForeignKey(d => d.AracId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Ilan_dbo.Arac_AracID");
            });

            modelBuilder.Entity<Ilce>(entity =>
            {
                entity.ToTable("Ilce");

                entity.Property(e => e.IlceId).HasColumnName("IlceID");

                entity.Property(e => e.Ad).IsRequired();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<IletisimTur>(entity =>
            {
                entity.HasKey(e => e.IletisimTuruId)
                    .HasName("PK_dbo.IletisimTur");

                entity.ToTable("IletisimTur");

                entity.Property(e => e.IletisimTuruId).HasColumnName("IletisimTuruID");

                entity.Property(e => e.Ad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Kullanici>(entity =>
            {
                entity.ToTable("Kullanici");

                entity.HasIndex(e => e.KullaniciAd, "IX_KullaniciAd")
                    .IsUnique();

                entity.HasIndex(e => e.KullaniciTipId, "IX_KullaniciTipID");

                entity.HasIndex(e => e.RolId, "IX_RolID");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.Ad).IsRequired();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.KullaniciAd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KullaniciTipId).HasColumnName("KullaniciTipID");

                entity.Property(e => e.Kvkk).HasColumnName("KVKK");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.Property(e => e.Sifre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Soyad).IsRequired();

                entity.HasOne(d => d.KullaniciTip)
                    .WithMany(p => p.Kullanicis)
                    .HasForeignKey(d => d.KullaniciTipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Kullanici_dbo.KullaniciTip_KullaniciTipID");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Kullanicis)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Kullanici_dbo.Rol_RolID");
            });

            modelBuilder.Entity<KullaniciIletisim>(entity =>
            {
                entity.ToTable("KullaniciIletisim");

                entity.HasIndex(e => e.IletisimTuruId, "IX_IletisimTuruID");

                entity.HasIndex(e => e.KullaniciId, "IX_KullaniciID");

                entity.Property(e => e.KullaniciIletisimId).HasColumnName("KullaniciIletisimID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IletisimBilgi).IsRequired();

                entity.Property(e => e.IletisimTuruId).HasColumnName("IletisimTuruID");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.IletisimTuru)
                    .WithMany(p => p.KullaniciIletisims)
                    .HasForeignKey(d => d.IletisimTuruId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KullaniciIletisim_dbo.IletisimTur_IletisimTuruID");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.KullaniciIletisims)
                    .HasForeignKey(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KullaniciIletisim_dbo.Kullanici_KullaniciID");
            });

            modelBuilder.Entity<KullaniciTip>(entity =>
            {
                entity.ToTable("KullaniciTip");

                entity.Property(e => e.KullaniciTipId).HasColumnName("KullaniciTipID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tip)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<KurumsalIhale>(entity =>
            {
                entity.ToTable("KurumsalIhale");

                entity.HasIndex(e => e.IhaleId, "IX_IhaleID");

                entity.Property(e => e.KurumsalIhaleId).HasColumnName("KurumsalIhaleID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.IhaleId).HasColumnName("IhaleID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Ihale)
                    .WithMany(p => p.KurumsalIhales)
                    .HasForeignKey(d => d.IhaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KurumsalIhale_dbo.Ihale_IhaleID");
            });

            modelBuilder.Entity<KurumsalKullanici>(entity =>
            {
                entity.ToTable("KurumsalKullanici");

                entity.HasIndex(e => e.FirmaId, "IX_FirmaID");

                entity.HasIndex(e => e.KullaniciId, "IX_KullaniciID");

                entity.Property(e => e.KurumsalKullaniciId).HasColumnName("KurumsalKullaniciID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Firma)
                    .WithMany(p => p.KurumsalKullanicis)
                    .HasForeignKey(d => d.FirmaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KurumsalKullanici_dbo.Firma_FirmaID");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.KurumsalKullanicis)
                    .HasForeignKey(d => d.KullaniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.KurumsalKullanici_dbo.Kullanici_KullaniciID");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("Log");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.LogTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<LogError>(entity =>
            {
                entity.ToTable("LogError");

                entity.Property(e => e.LogErrorId).HasColumnName("LogErrorID");

                entity.Property(e => e.LogTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<Marka>(entity =>
            {
                entity.ToTable("Marka");

                entity.Property(e => e.MarkaId).HasColumnName("MarkaID");

                entity.Property(e => e.Ad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Ozellik>(entity =>
            {
                entity.ToTable("Ozellik");

                entity.Property(e => e.OzellikId).HasColumnName("OzellikID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OzellikAd).IsRequired();
            });

            modelBuilder.Entity<OzellikBilgi>(entity =>
            {
                entity.ToTable("OzellikBilgi");

                entity.HasIndex(e => e.OzellikId, "IX_OzellikID");

                entity.Property(e => e.OzellikBilgiId).HasColumnName("OzellikBilgiID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OzellikDetay).IsRequired();

                entity.Property(e => e.OzellikId).HasColumnName("OzellikID");

                entity.HasOne(d => d.Ozellik)
                    .WithMany(p => p.OzellikBilgis)
                    .HasForeignKey(d => d.OzellikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.OzellikBilgi_dbo.Ozellik_OzellikID");
            });

            modelBuilder.Entity<Paket>(entity =>
            {
                entity.ToTable("Paket");

                entity.Property(e => e.PaketId).HasColumnName("PaketID");

                entity.Property(e => e.Ad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("Rol");

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.Property(e => e.Ad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RolYetki>(entity =>
            {
                entity.ToTable("RolYetki");

                entity.HasIndex(e => e.RolId, "IX_RolID");

                entity.HasIndex(e => e.SayfaId, "IX_SayfaID");

                entity.HasIndex(e => e.YetkiId, "IX_YetkiID");

                entity.Property(e => e.RolYetkiId).HasColumnName("RolYetkiID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RolId).HasColumnName("RolID");

                entity.Property(e => e.SayfaId).HasColumnName("SayfaID");

                entity.Property(e => e.YetkiId).HasColumnName("YetkiID");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.RolYetkis)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RolYetki_dbo.Rol_RolID");

                entity.HasOne(d => d.Sayfa)
                    .WithMany(p => p.RolYetkis)
                    .HasForeignKey(d => d.SayfaId)
                    .HasConstraintName("FK_dbo.RolYetki_dbo.Sayfa_SayfaID");

                entity.HasOne(d => d.Yetki)
                    .WithMany(p => p.RolYetkis)
                    .HasForeignKey(d => d.YetkiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RolYetki_dbo.Yetki_YetkiID");
            });

            modelBuilder.Entity<Sayfa>(entity =>
            {
                entity.ToTable("Sayfa");

                entity.Property(e => e.SayfaId).HasColumnName("SayfaID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SayfaAdi).IsRequired();
            });

            modelBuilder.Entity<Sehir>(entity =>
            {
                entity.ToTable("Sehir");

                entity.Property(e => e.SehirId).HasColumnName("SehirID");

                entity.Property(e => e.Ad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SehirIlce>(entity =>
            {
                entity.ToTable("SehirIlce");

                entity.HasIndex(e => e.IlceId, "IX_IlceID");

                entity.HasIndex(e => e.SehirId, "IX_SehirID");

                entity.Property(e => e.SehirIlceId).HasColumnName("SehirIlceID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IlceId).HasColumnName("IlceID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SehirId).HasColumnName("SehirID");

                entity.HasOne(d => d.Ilce)
                    .WithMany(p => p.SehirIlces)
                    .HasForeignKey(d => d.IlceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SehirIlce_dbo.Ilce_IlceID");

                entity.HasOne(d => d.Sehir)
                    .WithMany(p => p.SehirIlces)
                    .HasForeignKey(d => d.SehirId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SehirIlce_dbo.Sehir_SehirID");
            });

            modelBuilder.Entity<Statu>(entity =>
            {
                entity.ToTable("Statu");

                entity.Property(e => e.StatuId).HasColumnName("StatuID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StatuAd).IsRequired();
            });

            modelBuilder.Entity<Stok>(entity =>
            {
                entity.ToTable("Stok");

                entity.HasIndex(e => e.FirmaId, "IX_FirmaID");

                entity.Property(e => e.StokId).HasColumnName("StokID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FirmaId).HasColumnName("FirmaID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Firma)
                    .WithMany(p => p.Stoks)
                    .HasForeignKey(d => d.FirmaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Stok_dbo.Firma_FirmaID");
            });

            modelBuilder.Entity<TramerDetay>(entity =>
            {
                entity.ToTable("TramerDetay");

                entity.Property(e => e.TramerDetayId).HasColumnName("TramerDetayID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TramerDurum).IsRequired();
            });

            modelBuilder.Entity<Yetki>(entity =>
            {
                entity.ToTable("Yetki");

                entity.Property(e => e.YetkiId).HasColumnName("YetkiID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.YetkiAciklama).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
