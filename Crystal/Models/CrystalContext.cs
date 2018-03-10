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
        public virtual DbSet<CuryTablLanguage> CuryTablLanguage { get; set; }
        public virtual DbSet<DbcontentConv> DbcontentConv { get; set; }
        public virtual DbSet<Dbinfo> Dbinfo { get; set; }
        public virtual DbSet<DecrTablLanguage> DecrTablLanguage { get; set; }
        public virtual DbSet<DensTablLanguage> DensTablLanguage { get; set; }
        public virtual DbSet<DielDissLanguage> DielDissLanguage { get; set; }
        public virtual DbSet<DielectrInvariant> DielectrInvariant { get; set; }
        public virtual DbSet<DielectrLanguage> DielectrLanguage { get; set; }
        public virtual DbSet<Elastic1Invariant> Elastic1Invariant { get; set; }
        public virtual DbSet<Elastic1Language> Elastic1Language { get; set; }
        public virtual DbSet<ElemTablInvariant> ElemTablInvariant { get; set; }
        public virtual DbSet<ElemTablLanguage> ElemTablLanguage { get; set; }
        public virtual DbSet<ElemTablNewLanguage> ElemTablNewLanguage { get; set; }
        public virtual DbSet<ElOpTablLanguage> ElOpTablLanguage { get; set; }
        public virtual DbSet<EquationTabl> EquationTabl { get; set; }
        public virtual DbSet<EsOpTablLanguage> EsOpTablLanguage { get; set; }
        public virtual DbSet<GrafTablLanguage> GrafTablLanguage { get; set; }
        public virtual DbSet<HardTablLanguage> HardTablLanguage { get; set; }
        public virtual DbSet<HeadTablConv> HeadTablConv { get; set; }
        public virtual DbSet<HeadTablInvariant> HeadTablInvariant { get; set; }
        public virtual DbSet<HeadTablLanguage> HeadTablLanguage { get; set; }
        public virtual DbSet<HeatExpnLanguage> HeatExpnLanguage { get; set; }
        public virtual DbSet<HeatTablInvariant> HeatTablInvariant { get; set; }
        public virtual DbSet<HeatTablLanguage> HeatTablLanguage { get; set; }
        public virtual DbSet<LastModifiedLanguage> LastModifiedLanguage { get; set; }
        public virtual DbSet<LitrTabl> LitrTabl { get; set; }
        public virtual DbSet<MechTablLanguage> MechTablLanguage { get; set; }
        public virtual DbSet<MnOpTablInvariant> MnOpTablInvariant { get; set; }
        public virtual DbSet<MnOpTablLanguage> MnOpTablLanguage { get; set; }
        public virtual DbSet<ModfTablInvariant> ModfTablInvariant { get; set; }
        public virtual DbSet<ModfTablLanguage> ModfTablLanguage { get; set; }
        public virtual DbSet<NlOpTablLanguage> NlOpTablLanguage { get; set; }
        public virtual DbSet<PlavTablLanguage> PlavTablLanguage { get; set; }
        public virtual DbSet<PropertiesComplexLanguage> PropertiesComplexLanguage { get; set; }
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

            modelBuilder.Entity<CuryTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.CuryTemp, e.ErrCury, e.Oboztran, e.Bknumber })
                    .HasName("U_CuryTabl")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CuryTemp).HasColumnType("numeric(8, 4)");

                entity.Property(e => e.ErrCury).HasColumnType("numeric(8, 5)");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Oboztran)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.CuryTablLanguage)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_CuryTabl2");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.CuryTablLanguage)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CuryTabl");
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

            modelBuilder.Entity<DecrTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.Nzv, e.Uzv, e.WaveType, e.WaveSpeed, e.Decrement, e.DecrFreq, e.Bknumber })
                    .HasName("U_DecrTabl")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DecrFreq).HasColumnType("numeric(10, 4)");

                entity.Property(e => e.Decrement).HasColumnType("numeric(10, 6)");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nzv)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Uzv)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WaveSpeed).HasColumnType("numeric(10, 5)");

                entity.Property(e => e.WaveType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.DecrTablLanguage)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_DecrTabl2");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.DecrTablLanguage)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DecrTabl");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.DecrTablLanguage)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_DecrTabl_SingTabl");
            });

            modelBuilder.Entity<DensTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.Density, e.ErrDens, e.Bknumber, e.MethodD1 })
                    .HasName("U_DensTabl")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Density).HasColumnType("numeric(8, 6)");

                entity.Property(e => e.ErrDens).HasColumnType("numeric(8, 7)");

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

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.DensTablLanguage)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_DensTabl2");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.DensTablLanguage)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DensTabl");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.DensTablLanguage)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_DensTabl_SingTabl");
            });

            modelBuilder.Entity<DielDissLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.FreqDiss, e.Temper3, e.TangName, e.TangentD, e.ErrDiss, e.Bknumber, e.MethodY1 })
                    .HasName("U_DielDiss")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrDiss).HasColumnType("numeric(9, 8)");

                entity.Property(e => e.FreqDiss).HasColumnType("numeric(12, 6)");

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
                    .HasComputedColumnSql("(left([MethodY],50))");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TangName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TangentD).HasColumnType("numeric(9, 7)");

                entity.Property(e => e.Temper3)
                    .HasColumnName("Temper_3")
                    .HasColumnType("numeric(8, 4)");

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.DielDissLanguage)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_DielDiss2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.DielDissLanguage)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_DielDiss");
            });

            modelBuilder.Entity<DielectrInvariant>(entity =>
            {
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

                entity.Property(e => e.Temper2)
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
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nazbparam)
                    .HasMaxLength(2)
                    .IsUnicode(false);

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

                entity.HasOne(d => d.ElemTabl)
                    .WithMany(p => p.ElemTablLanguage)
                    .HasForeignKey(d => d.ElemTablId)
                    .HasConstraintName("FK_ElemTablLanguage_ElemTablInvariant");
            });

            modelBuilder.Entity<ElemTablNewLanguage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aerr).HasColumnName("AErr");

                entity.Property(e => e.Berr).HasColumnName("BErr");

                entity.Property(e => e.Cerr).HasColumnName("CErr");

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

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.ElemTablNewLanguage)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_ElemTablNew2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.ElemTablNewLanguage)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_ElemTablNew");
            });

            modelBuilder.Entity<ElOpTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.WvLeng, e.ZnN1, e.R, e.ErrR, e.Bknumber, e.MethodR1 })
                    .HasName("U_ElOpTabl")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrR).HasColumnType("numeric(14, 8)");

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
                    .HasComputedColumnSql("(left([MethodR],50))");

                entity.Property(e => e.R).HasColumnType("numeric(14, 7)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.WvLeng).HasColumnType("numeric(10, 8)");

                entity.Property(e => e.ZnN1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.ElOpTablLanguage)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_ElOpTabl2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.ElOpTablLanguage)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_ElOpTabl");
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

            modelBuilder.Entity<EsOpTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.LengWave, e.ZnP, e.P, e.ErrP, e.Bknumber, e.MethodP1 })
                    .HasName("U_EsOpTabl")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrP).HasColumnType("numeric(9, 7)");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LengWave).HasColumnType("numeric(12, 8)");

                entity.Property(e => e.MethodP)
                    .HasMaxLength(1999)
                    .IsUnicode(false);

                entity.Property(e => e.MethodP1)
                    .HasColumnName("__MethodP")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodP],50))");

                entity.Property(e => e.P).HasColumnType("numeric(8, 6)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ZnP)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.EsOpTablLanguage)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_EsOpTabl2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.EsOpTablLanguage)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_EsOpTabl");
            });

            modelBuilder.Entity<GrafTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.NompClue, e.NameGraf })
                    .HasName("U_GrafTabl")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NameGraf)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NompClue).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Signatur)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.GrafTablLanguage)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GrafTabl");
            });

            modelBuilder.Entity<HardTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.Hard1, e.Hard2, e.ErrHard, e.Mohs, e.ErrMohs, e.Bknumber, e.MethodH1 })
                    .HasName("U_HardTabl")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrHard).HasColumnType("numeric(10, 6)");

                entity.Property(e => e.ErrMohs).HasColumnType("numeric(10, 7)");

                entity.Property(e => e.Hard1).HasColumnType("numeric(10, 5)");

                entity.Property(e => e.Hard2).HasColumnType("numeric(10, 5)");

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

                entity.Property(e => e.Mohs).HasColumnType("numeric(10, 6)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.HardTablLanguage)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_HardTabl2");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.HardTablLanguage)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HardTabl");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.HardTablLanguage)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_HardTabl_SingTabl");
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

                entity.Property(e => e.HeadClue).ValueGeneratedNever();

                entity.Property(e => e.Class).HasDefaultValueSql("((0))");

                entity.Property(e => e.Help)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<HeadTablLanguage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Expert)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.HeadTablId).HasColumnName("HeadTablID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.System)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.HasOne(d => d.HeadTabl)
                    .WithMany(p => p.HeadTablLanguage)
                    .HasForeignKey(d => d.HeadTablId)
                    .HasConstraintName("FK_HeadTablLanguage_HeadTablInvariant");
            });

            modelBuilder.Entity<HeatExpnLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.DataType, e.Temper1, e.Temper2, e.Znak1, e.S11, e.ErrHexp, e.Bknumber, e.MethodEx1 })
                    .HasName("U_HeatExpn")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DataType).HasDefaultValueSql("(0)");

                entity.Property(e => e.ErrHexp)
                    .HasColumnName("ErrHExp")
                    .HasColumnType("numeric(9, 7)");

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
                    .HasComputedColumnSql("(left([MethodEx],50))");

                entity.Property(e => e.S11).HasColumnType("numeric(11, 6)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Temper1)
                    .HasColumnName("Temper_1")
                    .HasColumnType("numeric(8, 4)");

                entity.Property(e => e.Temper2)
                    .HasColumnName("Temper_2")
                    .HasColumnType("numeric(8, 4)");

                entity.Property(e => e.Znak1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.HeatExpnLanguage)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_HeatExpn2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.HeatExpnLanguage)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_HeatExpn");
            });

            modelBuilder.Entity<HeatTablInvariant>(entity =>
            {
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

            modelBuilder.Entity<LastModifiedLanguage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Text)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LitrTabl>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.Bknumber })
                    .HasName("U_LitrTabl")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.LitrTabl)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LitrTabl");
            });

            modelBuilder.Entity<MechTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.Bknumber, e.FreqCons, e.Temper, e.ZnK, e.K, e.ErrK, e.MethodK1 })
                    .HasName("U_MechTabl")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrK).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.FreqCons).HasColumnType("numeric(12, 6)");

                entity.Property(e => e.K).HasColumnType("numeric(8, 5)");

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
                    .HasComputedColumnSql("(left([MethodK],50))");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Temper).HasColumnType("numeric(8, 4)");

                entity.Property(e => e.ZnK)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.MechTablLanguage)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_MechTabl2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.MechTablLanguage)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_MechTabl");
            });

            modelBuilder.Entity<MnOpTablInvariant>(entity =>
            {
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
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrSupr).HasColumnType("numeric(8, 5)");

                entity.Property(e => e.PointGrp)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Sp2)
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

            modelBuilder.Entity<NlOpTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.SingCode, e.Lyambda, e.ZnR, e.Rij, e.ErrRij, e.Bknumber, e.MethodR1 })
                    .HasName("U_NlOpTabl")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrRij).HasColumnType("numeric(14, 8)");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lyambda).HasColumnType("numeric(10, 8)");

                entity.Property(e => e.MethodR)
                    .HasMaxLength(1999)
                    .IsUnicode(false);

                entity.Property(e => e.MethodR1)
                    .HasColumnName("__MethodR")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(left([MethodR],50))");

                entity.Property(e => e.Rij).HasColumnType("numeric(14, 7)");

                entity.Property(e => e.SingCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ZnR)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.NlOpTablLanguage)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_NlOpTabl2");

                entity.HasOne(d => d.SingTabl)
                    .WithMany(p => p.NlOpTablLanguage)
                    .HasForeignKey(d => new { d.HeadClue, d.SingCode })
                    .HasConstraintName("FK_NlOpTabl");
            });

            modelBuilder.Entity<PlavTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.PlavType, e.PlavTemp, e.ErrPlav, e.Bknumber })
                    .HasName("U_PlavTabl")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrPlav).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PlavTemp).HasColumnType("numeric(9, 5)");

                entity.Property(e => e.PlavType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.PlavTablLanguage)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_PlavTabl2");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.PlavTablLanguage)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlavTabl");
            });

            modelBuilder.Entity<PropertiesComplexLanguage>(entity =>
            {
                entity.HasKey(e => e.Nomprop);

                entity.ToTable("Properties_ComplexLanguage");

                entity.Property(e => e.Nomprop)
                    .HasColumnName("NOMPROP")
                    .ValueGeneratedNever();

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

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
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PropertiesLanguage>(entity =>
            {
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
                entity.HasKey(e => e.HeadClue);

                entity.Property(e => e.HeadClue).ValueGeneratedNever();

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Referat).HasColumnType("text");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithOne(p => p.RefrTablLanguage)
                    .HasForeignKey<RefrTablLanguage>(d => d.HeadClue)
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
                entity.HasIndex(e => new { e.HeadClue, e.ElemNumb, e.MinValue, e.MaxValue })
                    .HasName("U_SistTabl")
                    .IsUnique();

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

            modelBuilder.Entity<SuspTablLanguage>(entity =>
            {
                entity.HasIndex(e => new { e.HeadClue, e.Temper, e.SuspName, e.Suspense, e.ErrSusp, e.Bknumber, e.MethodS1 })
                    .HasName("U_SuspTabl")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrSusp).HasColumnType("numeric(10, 9)");

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
                    .HasComputedColumnSql("(left([MethodS],50))");

                entity.Property(e => e.SuspName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Suspense).HasColumnType("numeric(10, 7)");

                entity.Property(e => e.Temper).HasColumnType("numeric(8, 4)");

                entity.HasOne(d => d.BknumberNavigation)
                    .WithMany(p => p.SuspTablLanguage)
                    .HasForeignKey(d => d.Bknumber)
                    .HasConstraintName("FK_SuspTabl2");

                entity.HasOne(d => d.HeadClueNavigation)
                    .WithMany(p => p.SuspTablLanguage)
                    .HasForeignKey(d => d.HeadClue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SuspTabl");
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
                entity.HasIndex(e => new { e.HeadClue, e.Leftwave, e.Rightwave, e.Bknumber })
                    .HasName("U_WavePure")
                    .IsUnique();

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
