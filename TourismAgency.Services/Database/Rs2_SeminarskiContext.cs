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
        public virtual DbSet<DrzavaNu> DrzavaNus { get; set; } = null!;
        public virtual DbSet<Grupe> Grupes { get; set; } = null!;
        public virtual DbSet<Grupe2> Grupe2s { get; set; } = null!;
        public virtual DbSet<KorisniciUloge> KorisniciUloges { get; set; } = null!;
        public virtual DbSet<Korisnik> Korisniks { get; set; } = null!;
        public virtual DbSet<Korisnik2> Korisnik2s { get; set; } = null!;
        public virtual DbSet<Lokacija> Lokacijas { get; set; } = null!;
        public virtual DbSet<LokacijaNu> LokacijaNus { get; set; } = null!;
        public virtual DbSet<Notifikacija> Notifikacijas { get; set; } = null!;
        public virtual DbSet<Notifikacija2> Notifikacija2s { get; set; } = null!;
        public virtual DbSet<PlanAktivnosti> PlanAktivnostis { get; set; } = null!;
        public virtual DbSet<Putovanje> Putovanjes { get; set; } = null!;
        public virtual DbSet<Putovanje2> Putovanje2s { get; set; } = null!;
        public virtual DbSet<Rezervacija> Rezervacijas { get; set; } = null!;
        public virtual DbSet<Smjestaj> Smjestajs { get; set; } = null!;
        public virtual DbSet<Turist> Turists { get; set; } = null!;
        public virtual DbSet<Uloge> Uloges { get; set; } = null!;
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

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Naziv).HasMaxLength(255);
            });

            modelBuilder.Entity<DrzavaNu>(entity =>
            {
                entity.ToTable("DrzavaNU");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Naziv).HasMaxLength(255);
            });

            modelBuilder.Entity<Grupe>(entity =>
            {
                entity.ToTable("Grupe");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrojSlobodnihMjesta).HasColumnName("broj slobodnih mjesta");

                entity.Property(e => e.BrojZauzetihMjesta).HasColumnName("broj zauzetih mjesta");

                entity.Property(e => e.PutovanjeId).HasColumnName("Putovanje_Id");

                entity.Property(e => e.VodicId).HasColumnName("vodic_id");

                entity.HasOne(d => d.Putovanje)
                    .WithMany(p => p.Grupes)
                    .HasForeignKey(d => d.PutovanjeId);

                entity.HasOne(d => d.Vodic)
                    .WithMany(p => p.Grupes)
                    .HasForeignKey(d => d.VodicId);
            });

            modelBuilder.Entity<Grupe2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Grupe2");

                entity.Property(e => e.BrojSlobodnihMjesta).HasColumnName("broj slobodnih mjesta");

                entity.Property(e => e.BrojZauzetihMjesta).HasColumnName("broj zauzetih mjesta");

                entity.Property(e => e.VodicId).HasColumnName("vodic_id");
            });

            modelBuilder.Entity<KorisniciUloge>(entity =>
            {
                entity.ToTable("KorisniciUloge");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");

                entity.Property(e => e.KorisnikId).HasColumnName("Korisnik_ID");

                entity.Property(e => e.UlogaId).HasColumnName("Uloga_ID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisniciUloges)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisniciUloge_Korisnici_ID");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisniciUloges)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisniciUloge_Uloge_ID");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.ToTable("Korisnik");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Ime).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.PasswordSalt).HasMaxLength(255);

                entity.Property(e => e.Prezime).HasMaxLength(255);

                entity.Property(e => e.RezervacijaId).HasColumnName("Rezervacija_Id");

                entity.Property(e => e.Role).HasMaxLength(255);

                entity.Property(e => e.Telefon).HasMaxLength(255);

                entity.Property(e => e.TuristId).HasColumnName("Turist_Id");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VodicId).HasColumnName("Vodic_Id");

                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.Korisniks)
                    .HasForeignKey(d => d.RezervacijaId);

                entity.HasOne(d => d.Turist)
                    .WithMany(p => p.Korisniks)
                    .HasForeignKey(d => d.TuristId);

                entity.HasOne(d => d.Vodic)
                    .WithMany(p => p.Korisniks)
                    .HasForeignKey(d => d.VodicId);
            });

            modelBuilder.Entity<Korisnik2>(entity =>
            {
                entity.ToTable("Korisnik2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Ime).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.PasswordSalt).HasMaxLength(255);

                entity.Property(e => e.Prezime).HasMaxLength(255);

                entity.Property(e => e.RezervacijaId).HasColumnName("Rezervacija_Id");

                entity.Property(e => e.Role).HasMaxLength(255);

                entity.Property(e => e.Telefon).HasMaxLength(255);

                entity.Property(e => e.TuristId).HasColumnName("Turist_Id");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VodicId).HasColumnName("Vodic_Id");
            });

            modelBuilder.Entity<Lokacija>(entity =>
            {
                entity.ToTable("Lokacija");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adresa).HasMaxLength(255);

                entity.Property(e => e.PutovanjeId).HasColumnName("Putovanje_Id");

                entity.Property(e => e.SmjestajId).HasColumnName("Smjestaj_id");

                entity.HasOne(d => d.Putovanje)
                    .WithMany(p => p.Lokacijas)
                    .HasForeignKey(d => d.PutovanjeId)
                    .HasConstraintName("FK_Lokacija_Putovanje_PutovanjeId");

                entity.HasOne(d => d.Smjestaj)
                    .WithMany(p => p.Lokacijas)
                    .HasForeignKey(d => d.SmjestajId);
            });

            modelBuilder.Entity<LokacijaNu>(entity =>
            {
                entity.ToTable("LokacijaNU");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Adresa).HasMaxLength(255);

                entity.Property(e => e.PutovanjeId).HasColumnName("Putovanje_Id");

                entity.Property(e => e.SmjestajId).HasColumnName("Smjestaj_id");
            });

            modelBuilder.Entity<Notifikacija>(entity =>
            {
                entity.ToTable("Notifikacija");

                entity.Property(e => e.Id).HasColumnName("ID");

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

            modelBuilder.Entity<Notifikacija2>(entity =>
            {
                entity.ToTable("Notifikacija2");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.KorisnikId).HasColumnName("Korisnik_Id");

                entity.Property(e => e.Naslov).HasMaxLength(255);

                entity.Property(e => e.Opis).HasMaxLength(255);

                entity.Property(e => e.Osoba)
                    .HasMaxLength(255)
                    .HasColumnName("osoba");
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

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DrzavaId).HasColumnName("Drzava_Id");

                entity.Property(e => e.Naziv).HasMaxLength(255);

                entity.Property(e => e.Opis).HasMaxLength(255);

                entity.Property(e => e.Polazak).HasMaxLength(255);

                entity.Property(e => e.StateMachine).HasMaxLength(255);

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Putovanjes)
                    .HasForeignKey(d => d.DrzavaId)
                    .HasConstraintName("FK_Putovanje_Drzava_ID");
            });

            modelBuilder.Entity<Putovanje2>(entity =>
            {
                entity.ToTable("Putovanje2");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DrzavaId).HasColumnName("Drzava_Id");

                entity.Property(e => e.GrupaId).HasColumnName("Grupa_Id");

                entity.Property(e => e.Naziv).HasMaxLength(255);

                entity.Property(e => e.Opis).HasMaxLength(255);

                entity.Property(e => e.Polazak).HasMaxLength(255);
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.ToTable("Rezervacija");

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
                    .WithMany(p => p.Rezervacijas)
                    .HasForeignKey(d => d.SmjestajId);
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

            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.ToTable("Uloge");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Naziv).HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(200);
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

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.GrupaId).HasColumnName("Grupa_Id");

                entity.Property(e => e.Naziv).HasMaxLength(255);

                entity.Property(e => e.PutovanjeId).HasColumnName("Putovanje_Id");

                entity.Property(e => e.VodicId).HasColumnName("Vodic_Id");

                entity.HasOne(d => d.Grupa)
                    .WithMany(p => p.Zaduzenjas)
                    .HasForeignKey(d => d.GrupaId)
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
