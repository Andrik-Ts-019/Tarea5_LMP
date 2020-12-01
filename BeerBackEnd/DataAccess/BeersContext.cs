using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BeerBackEnd.DataAccess
{
    public partial class BeersContext : DbContext
    {
        public BeersContext()
        {
        }

        public BeersContext(DbContextOptions<BeersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Beer> Beer { get; set; }
        public virtual DbSet<Food> Food { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-1AE7SOS\\SQLEXPRESS;Database=Beers;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beer>(entity =>
            {
                entity.ToTable("beer");

                entity.HasIndex(e => e.Name)
                    .HasName("UQ__beer__72E12F1BA7F8E698")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Abv).HasColumnName("abv");

                entity.Property(e => e.AttenuationLevel).HasColumnName("attenuation_level");

                entity.Property(e => e.BrewersTips)
                    .HasColumnName("brewers_tips")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContributedBy)
                    .HasColumnName("contributed_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ebc).HasColumnName("ebc");

                entity.Property(e => e.FirstBrewed)
                    .HasColumnName("first_brewed")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Ibu).HasColumnName("ibu");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ph).HasColumnName("ph");

                entity.Property(e => e.Srm).HasColumnName("srm");

                entity.Property(e => e.Tagline)
                    .HasColumnName("tagline")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TargetFg).HasColumnName("target_fg");

                entity.Property(e => e.TargetOg).HasColumnName("target_og");
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.ToTable("food");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FoodPairing)
                    .HasColumnName("food_pairing")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdBeer).HasColumnName("idBeer");

                entity.HasOne(d => d.IdBeerNavigation)
                    .WithMany(p => p.Food)
                    .HasForeignKey(d => d.IdBeer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__food__idBeer__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
