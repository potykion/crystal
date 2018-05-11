using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Crystal.Models
{
    public partial class CrystalContext : DbContext
    {
        public virtual DbSet<AcOpTablInvariant> AcOpTablInvariant { get; set; }
        public virtual DbSet<AcOpTablLanguage> AcOpTablLanguage { get; set; }
        public virtual DbSet<BibliogrInvariant> BibliogrInvariant { get; set; }
        public virtual DbSet<BibliogrLanguage> BibliogrLanguage { get; set; }
        public virtual DbSet<ConstSelInvariant> ConstSelInvariant { get; set; }
        public virtual DbSet<ConstSelLanguage> ConstSelLanguage { get; set; }
        public virtual DbSet<CuryTablInvariant> CuryTablInvariant { get; set; }
        public virtual DbSet<CuryTablLanguage> CuryTablLanguage { get; set; }
        public virtual DbSet<DbcontentConv> DbcontentConv { get; set; }
        public virtual DbSet<Dbinfo> Dbinfo { get; set; }
        public virtual DbSet<DecrTablInvariant> DecrTablInvariant { get; set; }
        public virtual DbSet<DecrTablLanguage> DecrTablLanguage { get; set; }
        public virtual DbSet<DensTablInvariant> DensTablInvariant { get; set; }
        public virtual DbSet<DensTablLanguage> DensTablLanguage { get; set; }
        public virtual DbSet<DielDissInvariant> DielDissInvariant { get; set; }
        public virtual DbSet<DielDissLanguage> DielDissLanguage { get; set; }
        public virtual DbSet<DielectrInvariant> DielectrInvariant { get; set; }
        public virtual DbSet<DielectrLanguage> DielectrLanguage { get; set; }
        public virtual DbSet<Elastic1Invariant> Elastic1Invariant { get; set; }
        public virtual DbSet<Elastic1Language> Elastic1Language { get; set; }
        public virtual DbSet<ElemTablInvariant> ElemTablInvariant { get; set; }
        public virtual DbSet<ElemTablLanguage> ElemTablLanguage { get; set; }
        public virtual DbSet<ElemTablNewInvariant> ElemTablNewInvariant { get; set; }
        public virtual DbSet<ElemTablNewLanguage> ElemTablNewLanguage { get; set; }
        public virtual DbSet<ElOpTablInvariant> ElOpTablInvariant { get; set; }
        public virtual DbSet<ElOpTablLanguage> ElOpTablLanguage { get; set; }
        public virtual DbSet<EquationTabl> EquationTabl { get; set; }
        public virtual DbSet<EsOpTablInvariant> EsOpTablInvariant { get; set; }
        public virtual DbSet<EsOpTablLanguage> EsOpTablLanguage { get; set; }
        public virtual DbSet<GrafTablInvariant> GrafTablInvariant { get; set; }
        public virtual DbSet<GrafTablLanguage> GrafTablLanguage { get; set; }
        public virtual DbSet<HardTablInvariant> HardTablInvariant { get; set; }
        public virtual DbSet<HardTablLanguage> HardTablLanguage { get; set; }
        public virtual DbSet<HeadTablConv> HeadTablConv { get; set; }
        public virtual DbSet<HeadTablInvariant> HeadTablInvariant { get; set; }
        public virtual DbSet<HeadTablLanguage> HeadTablLanguage { get; set; }
        public virtual DbSet<HeatExpnInvariant> HeatExpnInvariant { get; set; }
        public virtual DbSet<HeatExpnLanguage> HeatExpnLanguage { get; set; }
        public virtual DbSet<HeatTablInvariant> HeatTablInvariant { get; set; }
        public virtual DbSet<HeatTablLanguage> HeatTablLanguage { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<LastModifiedInvariant> LastModifiedInvariant { get; set; }
        public virtual DbSet<LastModifiedLanguage> LastModifiedLanguage { get; set; }
        public virtual DbSet<LitrTabl> LitrTabl { get; set; }
        public virtual DbSet<MechTablInvariant> MechTablInvariant { get; set; }
        public virtual DbSet<MechTablLanguage> MechTablLanguage { get; set; }
        public virtual DbSet<MnOpTablInvariant> MnOpTablInvariant { get; set; }
        public virtual DbSet<MnOpTablLanguage> MnOpTablLanguage { get; set; }
        public virtual DbSet<ModfTablInvariant> ModfTablInvariant { get; set; }
        public virtual DbSet<ModfTablLanguage> ModfTablLanguage { get; set; }
        public virtual DbSet<NlOpTablInvariant> NlOpTablInvariant { get; set; }
        public virtual DbSet<NlOpTablLanguage> NlOpTablLanguage { get; set; }
        public virtual DbSet<PlavTablInvariant> PlavTablInvariant { get; set; }
        public virtual DbSet<PlavTablLanguage> PlavTablLanguage { get; set; }
        public virtual DbSet<PropertiesComplex> PropertiesComplex { get; set; }
        public virtual DbSet<PropertiesConv> PropertiesConv { get; set; }
        public virtual DbSet<PropertiesInvariant> PropertiesInvariant { get; set; }
        public virtual DbSet<PropertiesLanguage> PropertiesLanguage { get; set; }
        public virtual DbSet<PzElTablInvariant> PzElTablInvariant { get; set; }
        public virtual DbSet<PzElTablLanguage> PzElTablLanguage { get; set; }
        public virtual DbSet<RefrcIndInvariant> RefrcIndInvariant { get; set; }
        public virtual DbSet<RefrcIndLanguage> RefrcIndLanguage { get; set; }
        public virtual DbSet<RefrTablLanguage> RefrTablLanguage { get; set; }
        public virtual DbSet<SingTabl> SingTabl { get; set; }
        public virtual DbSet<SistTabl> SistTabl { get; set; }
        public virtual DbSet<SuspTablInvariant> SuspTablInvariant { get; set; }
        public virtual DbSet<SuspTablLanguage> SuspTablLanguage { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersInfo> UsersInfo { get; set; }
        public virtual DbSet<Wavepure> Wavepure { get; set; }

        public CrystalContext(DbContextOptions<CrystalContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcOpTablInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.WaveLeng, e.Nzv, e.M1, e.M2, e.M3, e.Bknumber })
                    .HasName("U_AcOpTablInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.M1).HasColumnType("numeric(10, 5)");

                entity.Property(e => e.M2).HasColumnType("numeric(10, 5)");

                entity.Property(e => e.M3).HasColumnType("numeric(10, 5)");

                entity.Property(e => e.Nzv)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.WaveLeng).HasColumnType("numeric(10, 8)");

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.AcOpTablInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_AcOpTabl2");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.AcOpTablInvariant)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AcOpTabl");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.AcOpTablInvariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_AcopTabl_SingTabl");
            });

            modelBuilder.Entity<AcOpTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.AcOpTablId, e.LanguageId, e.E, e.Nsv, e.Uzv })
                    .HasName("U_AcOpTablLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcOpTablId).HasColumnName("AcOpTablID");

                entity.Property(e => e.E)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nsv)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Uzv)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.AcOpTabl)
                    .WithMany(p => p.AcOpTablLanguage)
                    .HasForeignKey(d => d.AcOpTablId)
                    .HasConstraintName("FK_AcOpTablLanguage_AcOpTablInvariant");
            });

            modelBuilder.Entity<BibliogrInvariant>(entity =>
            {
                entity.HasKey(e => e.Bknumber);

                entity.Property(e => e.Bknumber).ValueGeneratedNever();

                entity.Property(e => e.Doi)
                    .HasColumnName("DOI")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BibliogrLanguage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Authors)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BibliogrId).HasColumnName("BibliogrID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Source)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bibliogr)
                    .WithMany(p => p.BibliogrLanguage)
                    .HasForeignKey(d => d.BibliogrId)
                    .HasConstraintName("FK_BibliogrLanguage_BibliogrInvariant");
            });

            modelBuilder.Entity<ConstSelInvariant>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Equation)
                    .HasMaxLength(1999)
                    .IsUnicode(false);

                entity.Property(e => e.NazvSel)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ZnachSel).HasColumnType("numeric(28, 10)");

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.ConstSelInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_ConstSel2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.ConstSelInvariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_ConstSel");
            });

            modelBuilder.Entity<ConstSelLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.ConstSelId, e.LanguageId, e.Measure })
                    .HasName("U_ConstSelLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConstSelId).HasColumnName("ConstSelID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Measure)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.ConstSel)
                    .WithMany(p => p.ConstSelLanguage)
                    .HasForeignKey(d => d.ConstSelId)
                    .HasConstraintName("FK_ConstSelLanguage_ConstSelInvariant");
            });

            modelBuilder.Entity<CuryTablInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.CuryTemp, e.ErrCury, e.Bknumber })
                    .HasName("U_CuryTablInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CuryTemp).HasColumnType("numeric(8, 4)");

                entity.Property(e => e.ErrCury).HasColumnType("numeric(8, 5)");

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.CuryTablInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_CuryTabl2");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.CuryTablInvariant)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CuryTabl");
            });

            modelBuilder.Entity<CuryTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.CuryTablId, e.LanguageId, e.Oboztran })
                    .HasName("U_CuryTablLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CuryTablId).HasColumnName("CuryTablID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Oboztran)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CuryTabl)
                    .WithMany(p => p.CuryTablLanguage)
                    .HasForeignKey(d => d.CuryTablId)
                    .HasConstraintName("FK_CuryTablLanguage_CuryTablInvariant");
            });

            modelBuilder.Entity<DbcontentConv>(entity =>
            {
                entity.HasKey(e => new { e.HeadClue, e.Nomprop });

                entity.ToTable("_DBContentConv");

                entity.Property(e => e.Nomprop).HasColumnName("NOMPROP");

                entity.Property(e => e.UpdateStatus).HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<Dbinfo>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("_DBInfo");

                entity.Property(e => e.Name)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DbgateUrl)
                    .IsRequired()
                    .HasColumnName("DBGateURL")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dburl)
                    .IsRequired()
                    .HasColumnName("DBURL")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmailManager)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ru')");

                entity.Property(e => e.UpdateStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.WwwtemplatePage)
                    .IsRequired()
                    .HasColumnName("WWWTemplatePage")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DecrTablInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.WaveSpeed, e.Decrement, e.DecrFreq, e.Bknumber })
                    .HasName("U_DecrTablInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DecrFreq).HasColumnType("numeric(10, 4)");

                entity.Property(e => e.Decrement).HasColumnType("numeric(10, 6)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.WaveSpeed).HasColumnType("numeric(10, 5)");

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.DecrTablInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_DecrTabl2");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.DecrTablInvariant)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DecrTabl");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.DecrTablInvariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_DecrTabl_SingTabl");
            });

            modelBuilder.Entity<DecrTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.DecrTablId, e.LanguageId, e.Nzv, e.Uzv, e.WaveType })
                    .HasName("U_DecrTablLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DecrTablId).HasColumnName("DecrTablID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nzv)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Uzv)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WaveType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.DecrTabl)
                    .WithMany(p => p.DecrTablLanguage)
                    .HasForeignKey(d => d.DecrTablId)
                    .HasConstraintName("FK_DecrTablLanguage_DecrTablInvariant");
            });

            modelBuilder.Entity<DensTablInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.Density, e.ErrDens, e.Bknumber })
                    .HasName("U_DensTablInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Density).HasColumnType("numeric(8, 6)");

                entity.Property(e => e.ErrDens).HasColumnType("numeric(8, 7)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.DensTablInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_DensTabl2");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.DensTablInvariant)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DensTabl");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.DensTablInvariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_DensTabl_SingTabl");
            });

            modelBuilder.Entity<DensTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.DensTablId, e.LanguageId, e.MethodD1 })
                    .HasName("U_DensTablLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DensTablId).HasColumnName("DensTablID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MethodD)
                    .HasMaxLength(1999)
                    .IsUnicode(false);

                entity.Property(e => e.MethodD1)
                    .HasColumnName("__MethodD")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodD],(50)))");

                entity.HasOne(d => d.DensTabl)
                    .WithMany(p => p.DensTablLanguage)
                    .HasForeignKey(d => d.DensTablId)
                    .HasConstraintName("FK_DensTablLanguage_DensTablInvariant");
            });

            modelBuilder.Entity<DielDissInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.FreqDiss, Temper3 = e.Temper_3, e.TangentD, e.ErrDiss, e.Bknumber })
                    .HasName("U_DielDissInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrDiss).HasColumnType("numeric(9, 8)");

                entity.Property(e => e.FreqDiss).HasColumnType("numeric(12, 6)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TangentD).HasColumnType("numeric(9, 7)");

                entity.Property(e => e.Temper_3)
                    .HasColumnName("Temper_3")
                    .HasColumnType("numeric(8, 4)");

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.DielDissInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_DielDiss2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.DielDissInvariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_DielDiss");
            });

            modelBuilder.Entity<DielDissLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.DielDissId, e.LanguageId, e.TangName, e.MethodY1 })
                    .HasName("U_DielDissLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DielDissId).HasColumnName("DielDissID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MethodY)
                    .HasMaxLength(1999)
                    .IsUnicode(false);

                entity.Property(e => e.MethodY1)
                    .HasColumnName("__MethodY")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodY],(50)))");

                entity.Property(e => e.TangName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.DielDiss)
                    .WithMany(p => p.DielDissLanguage)
                    .HasForeignKey(d => d.DielDissId)
                    .HasConstraintName("FK_DielDissLanguage_DielDissInvariant");
            });

            modelBuilder.Entity<DielectrInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.FreqDiel, Temper2 = e.Temper_2, e.Constant, e.Diel, e.ErrY, e.Bknumber })
                    .HasName("U_DielectrInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Constant)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Diel).HasColumnType("numeric(12, 6)");

                entity.Property(e => e.ErrY).HasColumnType("numeric(12, 7)");

                entity.Property(e => e.FreqDiel).HasColumnType("numeric(18, 6)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Temper_2)
                    .HasColumnName("Temper_2")
                    .HasColumnType("numeric(8, 4)");

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.DielectrInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_Dielectr2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.DielectrInvariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_Dielectr");
            });

            modelBuilder.Entity<DielectrLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.DielectrId, e.LanguageId, e.Znak, e.MethodY1 })
                    .HasName("U_DielectrLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DielectrId).HasColumnName("DielectrID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MethodY)
                    .HasMaxLength(1999)
                    .IsUnicode(false);

                entity.Property(e => e.MethodY1)
                    .HasColumnName("__MethodY")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodY],(50)))");

                entity.Property(e => e.Znak)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dielectr)
                    .WithMany(p => p.DielectrLanguage)
                    .HasForeignKey(d => d.DielectrId)
                    .HasConstraintName("FK_DielectrLanguage_DielectrInvariant");
            });

            modelBuilder.Entity<Elastic1Invariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.TemperEl, e.CondClu1, e.E1, e.ErrE, e.Bknumber })
                    .HasName("U_Elastic1Invariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CondClu1)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.E1).HasColumnType("numeric(13, 6)");

                entity.Property(e => e.ErrE).HasColumnType("numeric(9, 7)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TemperEl).HasColumnType("numeric(8, 4)");

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.Elastic1Invariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_Elastic12");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.Elastic1Invariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_Elastic1");
            });

            modelBuilder.Entity<Elastic1Language>(entity =>
            {
                entity.HasIndex(e => new { e.Elastic1Id, e.LanguageId, e.ZnE, e.MethodE1 })
                    .HasName("U_Elastic1Language")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Elastic1Id).HasColumnName("Elastic1ID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MethodE)
                    .HasMaxLength(1999)
                    .IsUnicode(false);

                entity.Property(e => e.MethodE1)
                    .HasColumnName("__MethodE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodE],(50)))");

                entity.Property(e => e.ZnE)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Elastic1)
                    .WithMany(p => p.Elastic1Language)
                    .HasForeignKey(d => d.Elastic1Id)
                    .HasConstraintName("FK_Elastic1Language_Elastic1Invariant");
            });

            modelBuilder.Entity<ElemTablInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.Znparam, e.Errparam, e.NazvAngl, e.ZnAngle, e.ErrAngl, e.Bknumber })
                    .HasName("U_ElemTablInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NazvAngl)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.ElemTablInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_ElemTabl2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.ElemTablInvariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_ElemTabl");
            });

            modelBuilder.Entity<ElemTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.ElemTablId, e.LanguageId, e.Nazbparam, e.MethodP1 })
                    .HasName("U_ElemTablLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ElemTablId).HasColumnName("ElemTablID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MethodP)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.MethodP1)
                    .HasColumnName("__MethodP")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodP],(50)))");

                entity.Property(e => e.Nazbparam)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.ElemTabl)
                    .WithMany(p => p.ElemTablLanguage)
                    .HasForeignKey(d => d.ElemTablId)
                    .HasConstraintName("FK_ElemTablLanguage_ElemTablInvariant");
            });

            modelBuilder.Entity<ElemTablNewInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.A, e.Aerr, e.B, e.Berr, e.C, e.Cerr, e.Alpha, e.AlphaErr, e.Beta, e.BetaErr, e.Gamma, e.GammaErr, e.Bknumber })
                    .HasName("U_ElemTablNewInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aerr).HasColumnName("AErr");

                entity.Property(e => e.Berr).HasColumnName("BErr");

                entity.Property(e => e.Cerr).HasColumnName("CErr");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.ElemTablNewInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_ElemTablNew2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.ElemTablNewInvariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_ElemTablNew");
            });

            modelBuilder.Entity<ElemTablNewLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.ElemTablNewId, e.LanguageId, e.MethodP1 })
                    .HasName("U_ElemTablNewLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ElemTablNewId).HasColumnName("ElemTablNewID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MethodP)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.MethodP1)
                    .HasColumnName("__MethodP")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodP],(50)))");

                entity.HasOne(d => d.ElemTablNew)
                    .WithMany(p => p.ElemTablNewLanguage)
                    .HasForeignKey(d => d.ElemTablNewId)
                    .HasConstraintName("FK_ElemTablNewLanguage_ElemTablNewInvariant");
            });

            modelBuilder.Entity<ElOpTablInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.WvLeng, e.R, e.ErrR, e.Bknumber })
                    .HasName("U_ElOpTablInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrR).HasColumnType("numeric(14, 8)");

                entity.Property(e => e.R).HasColumnType("numeric(14, 7)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.WvLeng).HasColumnType("numeric(10, 8)");

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.ElOpTablInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_ElOpTabl2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.ElOpTablInvariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_ElOpTabl");
            });

            modelBuilder.Entity<ElOpTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.ElOpTablId, e.LanguageId, e.ZnN1, e.MethodR1 })
                    .HasName("U_ElOpTablLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ElOpTablId).HasColumnName("ElOpTablID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MethodR)
                    .HasMaxLength(1999)
                    .IsUnicode(false);

                entity.Property(e => e.MethodR1)
                    .HasColumnName("__MethodR")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodR],(50)))");

                entity.Property(e => e.ZnN1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ElOpTabl)
                    .WithMany(p => p.ElOpTablLanguage)
                    .HasForeignKey(d => d.ElOpTablId)
                    .HasConstraintName("FK_ElOpTablLanguage_ElOpTablInvariant");
            });

            modelBuilder.Entity<EquationTabl>(entity =>
            {
                entity.HasKey(e => e.EquationId);

                entity.Property(e => e.EquationId)
                    .HasColumnName("EquationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.EquationCoefficientsJs)
                    .IsRequired()
                    .HasColumnName("EquationCoefficientsJS")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EquationHtml)
                    .IsRequired()
                    .HasColumnName("EquationHTML")
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EquationJs)
                    .IsRequired()
                    .HasColumnName("EquationJS")
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EquationName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nomprop).HasColumnName("NOMPROP");

                entity.Property(e => e.SingCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Xaxis)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.Xmax).HasDefaultValueSql("((100))");

                entity.Property(e => e.Xmeasure)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Xmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.Xml).HasColumnType("xml");

                entity.Property(e => e.Yaxis)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Ymeasure)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.EquationTabl)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_EquationTabl_Bibliogr");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.EquationTabl)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EquationTabl_HeadTabl");

                entity.HasOne(d => d.NompropNavigation)
                    .WithMany(p => p.EquationTabl)
                    .HasForeignKey(d => d.Nomprop)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EquationTabl_Properties");
            });

            modelBuilder.Entity<EsOpTablInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.LengWave, e.P, e.ErrP, e.Bknumber })
                    .HasName("U_EsOpTablInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrP).HasColumnType("numeric(9, 7)");

                entity.Property(e => e.LengWave).HasColumnType("numeric(12, 8)");

                entity.Property(e => e.P).HasColumnType("numeric(8, 6)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.EsOpTablInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_EsOpTabl2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.EsOpTablInvariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_EsOpTabl");
            });

            modelBuilder.Entity<EsOpTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.EsOpTablId, e.LanguageId, e.ZnP, e.MethodP1 })
                    .HasName("U_EsOpTablLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EsOpTablId).HasColumnName("EsOpTablID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MethodP)
                    .HasMaxLength(1999)
                    .IsUnicode(false);

                entity.Property(e => e.MethodP1)
                    .HasColumnName("__MethodP")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodP],(50)))");

                entity.Property(e => e.ZnP)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.EsOpTabl)
                    .WithMany(p => p.EsOpTablLanguage)
                    .HasForeignKey(d => d.EsOpTablId)
                    .HasConstraintName("FK_EsOpTablLanguage_EsOpTablInvariant");
            });

            modelBuilder.Entity<GrafTablInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.NompClue })
                    .HasName("U_GrafTablInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NompClue).HasColumnType("numeric(2, 0)");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.GrafTablInvariant)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrafTabl");
            });

            modelBuilder.Entity<GrafTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.GrafTablId, e.LanguageId, e.NameGraf, e.Signatur1 })
                    .HasName("U_GrafTablLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GrafTablId).HasColumnName("GrafTablID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NameGraf)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Signatur)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.Signatur1)
                    .HasColumnName("__Signatur")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([Signatur],(50)))");

                entity.HasOne(d => d.GrafTabl)
                    .WithMany(p => p.GrafTablLanguage)
                    .HasForeignKey(d => d.GrafTablId)
                    .HasConstraintName("FK_GrafTablLanguage_GrafTablInvariant");
            });

            modelBuilder.Entity<HardTablInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.Hard1, e.Hard2, e.ErrHard, e.Mohs, e.ErrMohs, e.Bknumber })
                    .HasName("U_HardTablInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrHard).HasColumnType("numeric(10, 6)");

                entity.Property(e => e.ErrMohs).HasColumnType("numeric(10, 7)");

                entity.Property(e => e.Hard1).HasColumnType("numeric(10, 5)");

                entity.Property(e => e.Hard2).HasColumnType("numeric(10, 5)");

                entity.Property(e => e.Mohs).HasColumnType("numeric(10, 6)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.HardTablInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_HardTabl2");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.HardTablInvariant)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HardTabl");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.HardTablInvariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_HardTabl_SingTabl");
            });

            modelBuilder.Entity<HardTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.HardTablId, e.LanguageId, e.MethodH1 })
                    .HasName("U_HardTablLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HardTablId).HasColumnName("HardTablID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MethodH)
                    .HasMaxLength(1999)
                    .IsUnicode(false);

                entity.Property(e => e.MethodH1)
                    .HasColumnName("__MethodH")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodH],(50)))");

                entity.HasOne(d => d.HardTabl)
                    .WithMany(p => p.HardTablLanguage)
                    .HasForeignKey(d => d.HardTablId)
                    .HasConstraintName("FK_HardTablLanguage_HardTablInvariant");
            });

            modelBuilder.Entity<HeadTablConv>(entity =>
            {
                entity.HasKey(e => e.HeadClue);

                entity.ToTable("_HeadTablConv");

                entity.Property(e => e.HeadClue).ValueGeneratedNever();

                entity.Property(e => e.Expert)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Help)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.System)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateStatus).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<HeadTablInvariant>(entity =>
            {
                entity.HasKey(e => e.HeadClue);

                entity.HasIndex(e => new { e.System, e.Help, e.Class })
                    .HasName("U_HeadTablInvariant")
                    .IsUnique();

                entity.Property(e => e.HeadClue).ValueGeneratedNever();

                entity.Property(e => e.Class).HasDefaultValueSql("((0))");

                entity.Property(e => e.Help)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.System)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SystemUrl)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(replace(replace([System],'<sub>',''),'</sub>',''))");
            });

            modelBuilder.Entity<HeadTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.HeadTablId, e.LanguageId, e.Expert })
                    .HasName("U_HeadTablLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Expert)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.HeadTablId).HasColumnName("HeadTablID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.HeadTabl)
                    .WithMany(p => p.HeadTablLanguage)
                    .HasForeignKey(d => d.HeadTablId)
                    .HasConstraintName("FK_HeadTablLanguage_HeadTablInvariant");
            });

            modelBuilder.Entity<HeatExpnInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.DataType, Temper1 = e.Temper_1, Temper2 = e.Temper_2, e.S11, ErrHexp = e.ErrHExp, e.Bknumber })
                    .HasName("U_HeatExpnInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DataType).HasDefaultValueSql("(0)");

                entity.Property(e => e.ErrHExp)
                    .HasColumnName("ErrHExp")
                    .HasColumnType("numeric(9, 7)");

                entity.Property(e => e.S11).HasColumnType("numeric(11, 6)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Temper_1)
                    .HasColumnName("Temper_1")
                    .HasColumnType("numeric(8, 4)");

                entity.Property(e => e.Temper_2)
                    .HasColumnName("Temper_2")
                    .HasColumnType("numeric(8, 4)");

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.HeatExpnInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_HeatExpn2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.HeatExpnInvariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_HeatExpn");
            });

            modelBuilder.Entity<HeatExpnLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.HeatExpnId, e.LanguageId, e.Znak1, e.MethodEx1 })
                    .HasName("U_HeatExpnLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HeatExpnId).HasColumnName("HeatExpnID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MethodEx)
                    .HasMaxLength(1999)
                    .IsUnicode(false);

                entity.Property(e => e.MethodEx1)
                    .HasColumnName("__MethodEx")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodEx],(50)))");

                entity.Property(e => e.Znak1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.HeatExpn)
                    .WithMany(p => p.HeatExpnLanguage)
                    .HasForeignKey(d => d.HeatExpnId)
                    .HasConstraintName("FK_HeatExpnLanguage_HeatExpnInvariant");
            });

            modelBuilder.Entity<HeatTablInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.Temperat, e.ZnC, e.C, e.ErrC, e.Bknumber })
                    .HasName("U_HeatTablInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.C).HasColumnType("numeric(10, 5)");

                entity.Property(e => e.ErrC).HasColumnType("numeric(10, 6)");

                entity.Property(e => e.Temperat).HasColumnType("numeric(8, 4)");

                entity.Property(e => e.ZnC)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.HeatTablInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_HeatTabl2");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.HeatTablInvariant)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HeatTabl");
            });

            modelBuilder.Entity<HeatTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.HeatTablId, e.LanguageId, e.MethodC1 })
                    .HasName("U_HeatTablLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HeatTablId).HasColumnName("HeatTablID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MethodC)
                    .HasMaxLength(1999)
                    .IsUnicode(false);

                entity.Property(e => e.MethodC1)
                    .HasColumnName("__MethodC")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodC],(50)))");

                entity.HasOne(d => d.HeatTabl)
                    .WithMany(p => p.HeatTablLanguage)
                    .HasForeignKey(d => d.HeatTablId)
                    .HasConstraintName("FK_HeatTablLanguage_HeatTablInvariant");
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LastModifiedInvariant>(entity =>
            {
                entity.HasIndex(e => e.LastModified)
                    .HasName("U_LastModifiedInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LastModifiedLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.LastModifiedId, e.LanguageId, e.Text })
                    .HasName("U_LastModifiedLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModifiedId).HasColumnName("LastModifiedID");

                entity.Property(e => e.Text)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.LastModified)
                    .WithMany(p => p.LastModifiedLanguage)
                    .HasForeignKey(d => d.LastModifiedId)
                    .HasConstraintName("FK_LastModifiedLanguage_LastModifiedInvariant");
            });

            modelBuilder.Entity<LitrTabl>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.LitrTabl)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LitrTabl");
            });

            modelBuilder.Entity<MechTablInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.Bknumber, e.FreqCons, e.Temper, e.K, e.ErrK })
                    .HasName("U_MechTablInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrK).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.FreqCons).HasColumnType("numeric(12, 6)");

                entity.Property(e => e.K).HasColumnType("numeric(8, 5)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Temper).HasColumnType("numeric(8, 4)");

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.MechTablInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_MechTabl2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.MechTablInvariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_MechTabl");
            });

            modelBuilder.Entity<MechTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.MechTablId, e.LanguageId, e.ZnK, e.MethodK1 })
                    .HasName("U_MechTablLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MechTablId).HasColumnName("MechTablID");

                entity.Property(e => e.MethodK)
                    .HasMaxLength(1999)
                    .IsUnicode(false);

                entity.Property(e => e.MethodK1)
                    .HasColumnName("__MethodK")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodK],(50)))");

                entity.Property(e => e.ZnK)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MechTabl)
                    .WithMany(p => p.MechTablLanguage)
                    .HasForeignKey(d => d.MechTablId)
                    .HasConstraintName("FK_MechTablLanguage_MechTablInvariant");
            });

            modelBuilder.Entity<MnOpTablInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.Lyambda, e.Nw, e.N2w, e.Znakcon, e.K, e.ErrKj, e.Bknumber })
                    .HasName("U_MnOpTablInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrKj).HasColumnType("numeric(8, 7)");

                entity.Property(e => e.K).HasColumnType("numeric(8, 6)");

                entity.Property(e => e.Lyambda).HasColumnType("numeric(10, 8)");

                entity.Property(e => e.N2w).HasColumnType("numeric(8, 6)");

                entity.Property(e => e.Nw).HasColumnType("numeric(8, 6)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Znakcon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.MnOpTablInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_MnOpTabl2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.MnOpTablInvariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_MnOpTabl");
            });

            modelBuilder.Entity<MnOpTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.MnOpTablId, e.LanguageId, e.MethodK1 })
                    .HasName("U_MnOpTablLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MethodK)
                    .HasMaxLength(1999)
                    .IsUnicode(false);

                entity.Property(e => e.MethodK1)
                    .HasColumnName("__MethodK")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodK],(50)))");

                entity.Property(e => e.MnOpTablId).HasColumnName("MnOpTablID");

                entity.HasOne(d => d.MnOpTabl)
                    .WithMany(p => p.MnOpTablLanguage)
                    .HasForeignKey(d => d.MnOpTablId)
                    .HasConstraintName("FK_MnOpTablLanguage_MnOpTablInvariant");
            });

            modelBuilder.Entity<ModfTablInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.SuprTemp, Sp2 = e.SP2, e.ErrSupr, e.PointGrp, e.Z, e.Bknumber })
                    .HasName("U_ModfTablInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrSupr).HasColumnType("numeric(8, 5)");

                entity.Property(e => e.PointGrp)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SP2)
                    .HasColumnName("SP2")
                    .HasColumnType("numeric(8, 4)");

                entity.Property(e => e.SuprTemp).HasColumnType("numeric(8, 4)");

                entity.Property(e => e.Z).HasColumnType("numeric(5, 3)");

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.ModfTablInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_ModfTabl2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.ModfTablInvariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_ModfTabl");
            });

            modelBuilder.Entity<ModfTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.ModfTablId, e.LanguageId, e.SpaceGrp })
                    .HasName("U_ModfTablLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModfTablId).HasColumnName("ModfTablID");

                entity.Property(e => e.SpaceGrp)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModfTabl)
                    .WithMany(p => p.ModfTablLanguage)
                    .HasForeignKey(d => d.ModfTablId)
                    .HasConstraintName("FK_ModfTablLanguage_ModfTablInvariant");
            });

            modelBuilder.Entity<NlOpTablInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.Lyambda, e.Rij, e.ErrRij, e.Bknumber })
                    .HasName("U_NlOpTablInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrRij).HasColumnType("numeric(14, 8)");

                entity.Property(e => e.Lyambda).HasColumnType("numeric(10, 8)");

                entity.Property(e => e.Rij).HasColumnType("numeric(14, 7)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.NlOpTablInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_NlOpTabl2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.NlOpTablInvariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_NlOpTabl");
            });

            modelBuilder.Entity<NlOpTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.NlOpTablId, e.LanguageId, e.ZnR, e.MethodR1 })
                    .HasName("U_NlOpTablLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MethodR)
                    .HasMaxLength(1999)
                    .IsUnicode(false);

                entity.Property(e => e.MethodR1)
                    .HasColumnName("__MethodR")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodR],(50)))");

                entity.Property(e => e.NlOpTablId).HasColumnName("NlOpTablID");

                entity.Property(e => e.ZnR)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.NlOpTabl)
                    .WithMany(p => p.NlOpTablLanguage)
                    .HasForeignKey(d => d.NlOpTablId)
                    .HasConstraintName("FK_NlOpTablLanguage_NlOpTablInvariant");
            });

            modelBuilder.Entity<PlavTablInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.PlavTemp, e.ErrPlav, e.Bknumber })
                    .HasName("U_PlavTablInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrPlav).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.PlavTemp).HasColumnType("numeric(9, 5)");

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.PlavTablInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_PlavTabl2");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.PlavTablInvariant)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlavTabl");
            });

            modelBuilder.Entity<PlavTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.PlavTablId, e.LanguageId, e.PlavType })
                    .HasName("U_PlavTablLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PlavTablId).HasColumnName("PlavTablID");

                entity.Property(e => e.PlavType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.PlavTabl)
                    .WithMany(p => p.PlavTablLanguage)
                    .HasForeignKey(d => d.PlavTablId)
                    .HasConstraintName("FK_PlavTablLanguage_PlavTablInvariant");
            });

            modelBuilder.Entity<PropertiesComplex>(entity =>
            {
                entity.HasKey(e => e.Nomprop);

                entity.ToTable("Properties_Complex");

                entity.Property(e => e.Nomprop)
                    .HasColumnName("NOMPROP")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nazvprop)
                    .HasColumnName("NAZVPROP")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PropertiesConv>(entity =>
            {
                entity.HasKey(e => e.Nomprop);

                entity.ToTable("_PropertiesConv");

                entity.Property(e => e.Nomprop)
                    .HasColumnName("NOMPROP")
                    .ValueGeneratedNever();

                entity.Property(e => e.Html)
                    .HasColumnName("HTML")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nazvprop)
                    .HasColumnName("NAZVPROP")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateStatus).HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<PropertiesInvariant>(entity =>
            {
                entity.HasKey(e => e.Nomprop);

                entity.HasIndex(e => new { e.Html, e.TableName })
                    .HasName("U_PropertiesInvariant")
                    .IsUnique();

                entity.Property(e => e.Nomprop)
                    .HasColumnName("NOMPROP")
                    .ValueGeneratedNever();

                entity.Property(e => e.Html)
                    .HasColumnName("HTML")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TableNameUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PropertiesLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.PropertiesId, e.LanguageId, e.Nazvprop })
                    .HasName("U_PropertiesLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nazvprop)
                    .HasColumnName("NAZVPROP")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PropertiesId).HasColumnName("PropertiesID");

                entity.HasOne(d => d.Properties)
                    .WithMany(p => p.PropertiesLanguage)
                    .HasForeignKey(d => d.PropertiesId)
                    .HasConstraintName("FK_PropertiesLanguage_PropertiesInvariant");
            });

            modelBuilder.Entity<PzElTablInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.FreqPzEl, e.ConstD, e.D, e.ErrD, e.Bknumber })
                    .HasName("U_PzElTablInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConstD)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.D).HasColumnType("numeric(12, 6)");

                entity.Property(e => e.ErrD).HasColumnType("numeric(12, 7)");

                entity.Property(e => e.FreqPzEl).HasColumnType("numeric(12, 6)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.PzElTablInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_PzElTabl2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.PzElTablInvariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_PzElTabl");
            });

            modelBuilder.Entity<PzElTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.PzElTablId, e.LanguageId, e.MethodPz1 })
                    .HasName("U_PzElTablLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MethodPz)
                    .HasMaxLength(1999)
                    .IsUnicode(false);

                entity.Property(e => e.MethodPz1)
                    .HasColumnName("__MethodPz")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodPz],(50)))");

                entity.Property(e => e.PzElTablId).HasColumnName("PzElTablID");

                entity.HasOne(d => d.PzElTabl)
                    .WithMany(p => p.PzElTablLanguage)
                    .HasForeignKey(d => d.PzElTablId)
                    .HasConstraintName("FK_PzElTablLanguage_PzElTablInvariant");
            });

            modelBuilder.Entity<RefrcIndInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.Temper, e.WaveLeng, e.NazbIndx, e.ZnachInd, e.ErrIndex, e.Bknumber })
                    .HasName("U_RefrcIndInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrIndex).HasColumnType("numeric(10, 9)");

                entity.Property(e => e.NazbIndx)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Temper).HasColumnType("numeric(8, 4)");

                entity.Property(e => e.WaveLeng).HasColumnType("numeric(12, 8)");

                entity.Property(e => e.ZnachInd).HasColumnType("numeric(10, 8)");

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.RefrcIndInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_RefrcInd2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.RefrcIndInvariant)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_RefrcInd");
            });

            modelBuilder.Entity<RefrcIndLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.RefrcIndId, e.LanguageId, e.MethodIn1 })
                    .HasName("U_RefrcIndLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MethodIn)
                    .HasMaxLength(1999)
                    .IsUnicode(false);

                entity.Property(e => e.MethodIn1)
                    .HasColumnName("__MethodIn")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodIn],(50)))");

                entity.Property(e => e.RefrcIndId).HasColumnName("RefrcIndID");

                entity.HasOne(d => d.RefrcInd)
                    .WithMany(p => p.RefrcIndLanguage)
                    .HasForeignKey(d => d.RefrcIndId)
                    .HasConstraintName("FK_RefrcIndLanguage_RefrcIndInvariant");
            });

            modelBuilder.Entity<RefrTablLanguage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Referat).HasColumnType("text");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.RefrTablLanguage)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefrTabl");
            });

            modelBuilder.Entity<SingTabl>(entity =>
            {
                entity.HasKey(e => new { e.HeadClue, e.SingType });

                entity.Property(e => e.SingType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SingClue).HasColumnType("numeric(4, 0)");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.SingTabl)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SingTabl");
            });

            modelBuilder.Entity<SistTabl>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ElemNumb)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MaxValue).HasColumnType("numeric(10, 5)");

                entity.Property(e => e.MinValue).HasColumnType("numeric(10, 5)");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.SistTabl)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SistTabl");
            });

            modelBuilder.Entity<SuspTablInvariant>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.Temper, e.Suspense, e.ErrSusp, e.Bknumber })
                    .HasName("U_SuspTablInvariant")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrSusp).HasColumnType("numeric(10, 9)");

                entity.Property(e => e.Suspense).HasColumnType("numeric(10, 7)");

                entity.Property(e => e.Temper).HasColumnType("numeric(8, 4)");

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.SuspTablInvariant)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_SuspTabl2");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.SuspTablInvariant)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SuspTabl");
            });

            modelBuilder.Entity<SuspTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.SuspTablId, e.LanguageId, e.SuspName, e.MethodS1 })
                    .HasName("U_SuspTablLanguage")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MethodS)
                    .HasMaxLength(1999)
                    .IsUnicode(false);

                entity.Property(e => e.MethodS1)
                    .HasColumnName("__MethodS")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodS],(50)))");

                entity.Property(e => e.SuspName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuspTablId).HasColumnName("SuspTablID");

                entity.HasOne(d => d.SuspTabl)
                    .WithMany(p => p.SuspTablLanguage)
                    .HasForeignKey(d => d.SuspTablId)
                    .HasConstraintName("FK_SuspTablLanguage_SuspTablInvariant");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Login);

                entity.HasIndex(e => e.UserId)
                    .IsUnique();

                entity.Property(e => e.Login)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessIp)
                    .HasColumnName("AccessIP")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AccessMode).HasDefaultValueSql("(1)");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('unknown')");

                entity.Property(e => e.LastIp)
                    .IsRequired()
                    .HasColumnName("LastIP")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NULL')");

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.Licence).HasColumnType("datetime");

                entity.Property(e => e.LoginCount).HasDefaultValueSql("(0)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<UsersInfo>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("_UsersInfo");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessMode).HasDefaultValueSql("(1)");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateStatus).HasDefaultValueSql("(1)");
            });

            modelBuilder.Entity<Wavepure>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Leftwave).HasColumnType("numeric(8, 5)");

                entity.Property(e => e.Rightwave).HasColumnType("numeric(8, 5)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.Wavepure)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_Wavepure2");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.Wavepure)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Wavepure");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.Wavepure)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_Wavepure_SingTabl");
            });
        }
    }
}
