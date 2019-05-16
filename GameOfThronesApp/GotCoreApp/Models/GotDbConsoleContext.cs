using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GotCoreApp.Models
{
    public partial class GotDbConsoleContext : DbContext
    {
        public GotDbConsoleContext()
        {
        }

        public GotDbConsoleContext(DbContextOptions<GotDbConsoleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bolumlers> Bolumlers { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<Ratings> Ratings { get; set; }
        //public virtual DbSet<Seasons> Seasons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MSI\\MSSQLSERVER14;Database=GotDbConsole;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bolumlers>(entity =>
            {
                entity.Property(e => e.ImdbId).HasColumnName("imdbID");

                entity.Property(e => e.ImdbRating).HasColumnName("imdbRating");

                entity.Property(e => e.ImdbVotes).HasColumnName("imdbVotes");

                entity.Property(e => e.SeriesId).HasColumnName("seriesID");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey });

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Ratings>(entity =>
            {
                entity.HasIndex(e => e.BolumlerId)
                    .HasName("IX_Bolumler_Id");

                entity.Property(e => e.BolumlerId).HasColumnName("Bolumler_Id");

                entity.HasOne(d => d.Bolumler)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.BolumlerId)
                    .HasConstraintName("FK_dbo.Ratings_dbo.Bolumlers_Bolumler_Id");
            });
        }
    }
}
