using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Top2000Project.Models
{
    public partial class db_a74225_top2000Context : DbContext
    {
        public db_a74225_top2000Context()
        {
        }

        public db_a74225_top2000Context(DbContextOptions<db_a74225_top2000Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Artiest> Artiests { get; set; }
        public virtual DbSet<Lijst> Lijsts { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<Top2000Jaar> Top2000Jaars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=SQL5104.site4now.net;Database=db_a74225_top2000;User Id=db_a74225_top2000_admin;Password=Password#12345;Trusted_Connection=True;Integrated Security=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Artiest>(entity =>
            {
                entity.ToTable("Artiest");

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("naam");
            });

            modelBuilder.Entity<Lijst>(entity =>
            {
                entity.HasKey(e => new { e.Songid, e.Top2000jaar });

                entity.ToTable("Lijst");

                entity.Property(e => e.Songid).HasColumnName("songid");

                entity.Property(e => e.Top2000jaar).HasColumnName("top2000jaar");

                entity.Property(e => e.Positie).HasColumnName("positie");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.Lijsts)
                    .HasForeignKey(d => d.Songid)
                    .HasConstraintName("FK_Lijst_Song");

                entity.HasOne(d => d.Top2000jaarNavigation)
                    .WithMany(p => p.Lijsts)
                    .HasForeignKey(d => d.Top2000jaar)
                    .HasConstraintName("FK_Lijst_Top2000Jaar");
            });

            modelBuilder.Entity<Song>(entity =>
            {
                entity.ToTable("Song");

                entity.Property(e => e.Songid).HasColumnName("songid");

                entity.Property(e => e.Artiestid).HasColumnName("artiestid");

                entity.Property(e => e.Jaar).HasColumnName("jaar");

                entity.Property(e => e.Titel)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("titel");

                entity.HasOne(d => d.Artiest)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.Artiestid)
                    .HasConstraintName("FK_Song_Artiest");
            });

            modelBuilder.Entity<Top2000Jaar>(entity =>
            {
                entity.HasKey(e => e.Jaar);

                entity.ToTable("Top2000Jaar");

                entity.Property(e => e.Jaar).ValueGeneratedNever();

                entity.Property(e => e.Titel)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasComputedColumnSql("('De TOP 2000 van '+CONVERT([char](5),[Jaar]))", false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
