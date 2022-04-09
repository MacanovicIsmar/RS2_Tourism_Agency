using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TourismAgency.Services.Database
{
    public partial class Rs2_SeminarskiContext : DbContext
    {
        public Rs2_SeminarskiContext()
        {
        }

        public Rs2_SeminarskiContext(DbContextOptions<Rs2_SeminarskiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Drzava> Drzavas { get; set; } = null!;
        public virtual DbSet<Grupe> Grupe { get; set; } = null!;
        public virtual DbSet<Korisnik> Korisniks { get; set; } = null!;
        public virtual DbSet<Lokacija> Lokacijas { get; set; } = null!;
        public virtual DbSet<Notifikacija> Notifikacijas { get; set; } = null!;
        public virtual DbSet<PlanAktivnosti> PlanAktivnostis { get; set; } = null!;
        public virtual DbSet<Putovanje> Putovanja { get; set; } = null!;
        public virtual DbSet<Rezervacija> Rezervacijas { get; set; } = null!;
        public virtual DbSet<Smjestaj> Smjestajs { get; set; } = null!;
        public virtual DbSet<Turist> Turists { get; set; } = null!;
        public virtual DbSet<Vodic> Vodics { get; set; } = null!;
        public virtual DbSet<Zaduzenja> Zaduzenjas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost,1433; Initial Catalog=Rs2_Seminarski; user=sa;Password=Pa774499");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drzava>(entity =>
            {
                entity.ToTable("Drzava");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Naziv).HasMaxLength(255);
            });

            modelBuilder.Entity<Grupe>(entity =>
            {
                entity.ToTable("Grupe");

                entity.HasIndex(e => e.VodicId, "UQ__Grupe__CE11CD4759CBFB0A")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BrojSlobodnihMjesta).HasColumnName("broj slobodnih mjesta");

                entity.Property(e => e.BrojZauzetihMjesta).HasColumnName("broj zauzetih mjesta");

                entity.Property(e => e.VodicId).HasColumnName("vodic_id");

                entity.HasOne(d => d.Vodic)
                    .WithOne(p => p.Grupe)
                    .HasForeignKey<Grupe>(d => d.VodicId);
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.ToTable("Korisnik");

                entity.HasIndex(e => e.TuristId, "UQ__Korisnik__16654C48EB1922D2")
                    .IsUnique();

                entity.HasIndex(e => e.RezervacijaId, "UQ__Korisnik__7A26123DD3CDCA67")
                    .IsUnique();

                entity.HasIndex(e => e.VodicId, "UQ__Korisnik__DF7CE45CD9031731")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Ime).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.Prezime).HasMaxLength(255);

                entity.Property(e => e.RezervacijaId).HasColumnName("Rezervacija_Id");

                entity.Property(e => e.Role).HasMaxLength(255);

                entity.Property(e => e.TuristId).HasColumnName("Turist_Id");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VodicId).HasColumnName("Vodic_Id");

                entity.HasOne(d => d.Rezervacija)
                    .WithOne(p => p.Korisnik)
                    .HasForeignKey<Korisnik>(d => d.RezervacijaId);

                entity.HasOne(d => d.Turist)
                    .WithOne(p => p.Korisnik)
                    .HasForeignKey<Korisnik>(d => d.TuristId);

                entity.HasOne(d => d.Vodic)
                    .WithOne(p => p.Korisnik)
                    .HasForeignKey<Korisnik>(d => d.VodicId);
            });

            modelBuilder.Entity<Lokacija>(entity =>
            {
                entity.ToTable("Lokacija");

                entity.HasIndex(e => e.SmjestajId, "UQ__Lokacija__2A84F991220BB24D")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Adresa).HasMaxLength(255);

                entity.Property(e => e.PutovanjeId).HasColumnName("Putovanje_Id");

                entity.Property(e => e.SmjestajId).HasColumnName("Smjestaj_id");

                entity.HasOne(d => d.Putovanje)
                    .WithMany(p => p.Lokacijas)
                    .HasForeignKey(d => d.PutovanjeId)
                    .HasConstraintName("FK_Lokacija_Putovanje_PutovanjeId");

                entity.HasOne(d => d.Smjestaj)
                    .WithOne(p => p.Lokacija)
                    .HasForeignKey<Lokacija>(d => d.SmjestajId);
            });

            modelBuilder.Entity<Notifikacija>(entity =>
            {
                entity.ToTable("Notifikacija");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.KorisnikId).HasColumnName("Korisnik_Id");

                entity.Property(e => e.Naslov).HasMaxLength(255);

                entity.Property(e => e.Opis).HasMaxLength(255);

                entity.Property(e => e.Osoba)
                    .HasMaxLength(255)
                    .HasColumnName("osoba");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Notifikacijas)
                    .HasForeignKey(d => d.KorisnikId);
            });

            modelBuilder.Entity<PlanAktivnosti>(entity =>
            {
                entity.ToTable("Plan_Aktivnosti");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Datum).HasMaxLength(255);

                entity.Property(e => e.Opis).HasMaxLength(255);

                entity.Property(e => e.PutovanjeId).HasColumnName("Putovanje_ID");

                entity.Property(e => e.Vrijeme).HasMaxLength(255);

                entity.HasOne(d => d.Putovanje)
                    .WithMany(p => p.PlanAktivnostis)
                    .HasForeignKey(d => d.PutovanjeId)
                    .HasConstraintName("FK_PlanAktivnosti_Putovanje_PutovanjeId");
            });

            modelBuilder.Entity<Putovanje>(entity =>
            {
                entity.ToTable("Putovanje");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DrzavaId).HasColumnName("Drzava_Id");

                entity.Property(e => e.GrupaId).HasColumnName("Grupa_Id");

                entity.Property(e => e.Naziv).HasMaxLength(255);

                entity.Property(e => e.Opis).HasMaxLength(255);

                entity.Property(e => e.Polazak).HasMaxLength(255);

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Putovanjes)
                    .HasForeignKey(d => d.DrzavaId)
                    .HasConstraintName("FK_Putovanje_Drzava_ID");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Putovanje)
                    .HasForeignKey<Putovanje>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Putovanje_Grupe_Grupa_Id");
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.ToTable("Rezervacija");

                entity.HasIndex(e => e.SmjestajId, "UQ__Rezervac__2A85E589320D8FF1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BrojLjudi).HasColumnName("Broj ljudi");

                entity.Property(e => e.Naziv).HasMaxLength(255);

                entity.Property(e => e.PutovanjeId).HasColumnName("Putovanje_ID");

                entity.Property(e => e.SmjestajId).HasColumnName("Smjestaj_Id");

                entity.HasOne(d => d.Putovanje)
                    .WithMany(p => p.Rezervacijas)
                    .HasForeignKey(d => d.PutovanjeId)
                    .HasConstraintName("FK_Rezervacija_Putovanje_PutovanjeId");

                entity.HasOne(d => d.Smjestaj)
                    .WithOne(p => p.Rezervacija)
                    .HasForeignKey<Rezervacija>(d => d.SmjestajId);
            });

            modelBuilder.Entity<Smjestaj>(entity =>
            {
                entity.ToTable("Smjestaj");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Adresa).HasMaxLength(255);

                entity.Property(e => e.BrojZvijezdica)
                    .HasMaxLength(255)
                    .HasColumnName("Broj Zvijezdica");

                entity.Property(e => e.NazivHotela).HasMaxLength(255);

                entity.Property(e => e.Slika).HasMaxLength(255);
            });

            modelBuilder.Entity<Turist>(entity =>
            {
                entity.ToTable("Turist");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BrojOdrađenihPutovanja).HasColumnName("Broj Odrađenih putovanja");

                entity.Property(e => e.BrojPutovanja).HasColumnName("Broj putovanja");

                entity.Property(e => e.GrupaId).HasColumnName("Grupa_Id");

                entity.Property(e => e.PopustStatus)
                    .HasMaxLength(255)
                    .HasColumnName("popust status");

                entity.Property(e => e.TrenutnoPutovanje)
                    .HasMaxLength(255)
                    .HasColumnName("trenutno putovanje");

                entity.HasOne(d => d.Grupa)
                    .WithMany(p => p.Turists)
                    .HasForeignKey(d => d.GrupaId)
                    .HasConstraintName("FK_Turist_Grupa_Grupa_Id");
            });

            modelBuilder.Entity<Vodic>(entity =>
            {
                entity.ToTable("Vodic");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BrojObavljenihZaduzenja).HasColumnName("Broj obavljenih Zaduzenja");
            });

            modelBuilder.Entity<Zaduzenja>(entity =>
            {
                entity.ToTable("Zaduzenja");

                entity.HasIndex(e => e.GrupaId, "UQ__Zaduzenj__3DCC9895385A36F9")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.GrupaId).HasColumnName("Grupa_Id");

                entity.Property(e => e.Naziv).HasMaxLength(255);

                entity.Property(e => e.PutovanjeId).HasColumnName("Putovanje_Id");

                entity.Property(e => e.VodicId).HasColumnName("Vodic_Id");

                entity.HasOne(d => d.Grupa)
                    .WithOne(p => p.Zaduzenja)
                    .HasForeignKey<Zaduzenja>(d => d.GrupaId)
                    .HasConstraintName("FK_Zaduzenja_grupa_Grupa_Id");

                entity.HasOne(d => d.Putovanje)
                    .WithMany(p => p.Zaduzenjas)
                    .HasForeignKey(d => d.PutovanjeId)
                    .HasConstraintName("FK_Zaduzenja_Putovanje_PutovanjeId");

                entity.HasOne(d => d.Vodic)
                    .WithMany(p => p.Zaduzenjas)
                    .HasForeignKey(d => d.VodicId)
                    .HasConstraintName("FK_Zaduzenja_Vodic_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
