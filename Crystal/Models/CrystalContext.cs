using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Crystal.Models
{
    public partial class CrystalContext : DbContext
    {
        public virtual DbSet<HeadTablInvariant> HeadTablInvariant { get; set; }
        public virtual DbSet<HeadTablLanguage> HeadTablLanguage { get; set; }

        public CrystalContext(DbContextOptions<CrystalContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
        }
    }
}