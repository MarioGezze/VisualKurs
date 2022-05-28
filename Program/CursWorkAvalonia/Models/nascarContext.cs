using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CursWorkAvalonia
{
    public partial class nascarContext : DbContext
    {
        public nascarContext()
        {
        }

        public nascarContext(DbContextOptions<nascarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Gender> Genders { get; set; } = null!;
        public virtual DbSet<Car> Car { get; set; } = null!;
        public virtual DbSet<Driver> Driver { get; set; } = null!;
        public virtual DbSet<Tournament> Tournaments { get; set; } = null!;
        public virtual DbSet<Team> Team { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source=C:/Users/mario/Desktop/VisualRGR-main/PROJECT/CursWorkAvalonia/Models/rgr.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("gender");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("car");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DriverId).HasColumnName("Driver");

                entity.Property(e => e.ChassisId).HasColumnName("chassis_id");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.Car)
                    .HasForeignKey(d => d.DriverId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Chassis)
                    .WithMany(p => p.Car)
                    .HasForeignKey(d => d.ChassisId)
                    .OnDelete(DeleteBehavior.Cascade);
            });


            modelBuilder.Entity<Driver>(entity =>
            {
                entity.ToTable("driver");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.CountryId).HasColumnName("country_id");



                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Driver)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.SetNull);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Driver)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<Tournament>(entity =>
            {
                entity.ToTable("tournament");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("event_name");

                entity.Property(e => e.Time).HasColumnName("date");

            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("team");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CarId).HasColumnName("car");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.TournamentId).HasColumnName("tournament");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Team)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.Cascade);



                entity.HasOne(d => d.Tournament)
                    .WithMany(p => p.Team)
                    .HasForeignKey(d => d.TournamentId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
