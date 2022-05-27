using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourismAgency.Services.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DrzavaNU",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrzavaNU", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Grupe2",
                columns: table => new
                {
                    OznakaGrupe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brojslobodnihmjesta = table.Column<int>(name: "broj slobodnih mjesta", type: "int", nullable: true),
                    brojzauzetihmjesta = table.Column<int>(name: "broj zauzetih mjesta", type: "int", nullable: true),
                    vodic_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Korisnik2",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Rezervacija_Id = table.Column<int>(type: "int", nullable: true),
                    Turist_Id = table.Column<int>(type: "int", nullable: true),
                    Vodic_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik2", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LokacijaNU",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Putovanje_Id = table.Column<int>(type: "int", nullable: true),
                    Smjestaj_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LokacijaNU", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Notifikacija2",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Naslov = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    osoba = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Korisnik_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifikacija2", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Plan_Aktivnosti2",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Vrijeme = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Putovanje_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan_Aktivnosti2", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Putovanje2",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Polazak = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SlikaThumb = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Grupa_Id = table.Column<int>(type: "int", nullable: true),
                    Drzava_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Putovanje2", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Smjestaj",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    NazivHotela = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BrojZvijezdica = table.Column<string>(name: "Broj Zvijezdica", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Slika = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smjestaj", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vodic",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    BrojobavljenihZaduzenja = table.Column<int>(name: "Broj obavljenih Zaduzenja", type: "int", nullable: true),
                    BrojZaduzenih = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vodic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Putovanje",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Polazak = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SlikaThumb = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Drzava_Id = table.Column<int>(type: "int", nullable: true),
                    StateMachine = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Putovanje", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Putovanje_Drzava_ID",
                        column: x => x.Drzava_Id,
                        principalTable: "Drzava",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Grupe",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OznakaGrupe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brojslobodnihmjesta = table.Column<int>(name: "broj slobodnih mjesta", type: "int", nullable: true),
                    brojzauzetihmjesta = table.Column<int>(name: "broj zauzetih mjesta", type: "int", nullable: true),
                    vodic_id = table.Column<int>(type: "int", nullable: true),
                    Putovanje_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupe", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Grupe_Putovanje_Putovanje_Id",
                        column: x => x.Putovanje_Id,
                        principalTable: "Putovanje",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Grupe_Vodic_vodic_id",
                        column: x => x.vodic_id,
                        principalTable: "Vodic",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Lokacija",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Putovanje_Id = table.Column<int>(type: "int", nullable: true),
                    Smjestaj_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokacija", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lokacija_Putovanje_PutovanjeId",
                        column: x => x.Putovanje_Id,
                        principalTable: "Putovanje",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Lokacija_Smjestaj_Smjestaj_id",
                        column: x => x.Smjestaj_id,
                        principalTable: "Smjestaj",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Plan_Aktivnosti",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "date", nullable: true),
                    Vrijeme = table.Column<TimeSpan>(type: "time", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Putovanje_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan_Aktivnosti", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PlanAktivnosti_Putovanje_PutovanjeId",
                        column: x => x.Putovanje_ID,
                        principalTable: "Putovanje",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Putovanje_ID = table.Column<int>(type: "int", nullable: true),
                    Brojljudi = table.Column<int>(name: "Broj ljudi", type: "int", nullable: true),
                    Smjestaj_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Putovanje_PutovanjeId",
                        column: x => x.Putovanje_ID,
                        principalTable: "Putovanje",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Rezervacija_Smjestaj_Smjestaj_Id",
                        column: x => x.Smjestaj_Id,
                        principalTable: "Smjestaj",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Turist",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    BrojOdrađenihputovanja = table.Column<int>(name: "Broj Odrađenih putovanja", type: "int", nullable: true),
                    trenutnoputovanje = table.Column<string>(name: "trenutno putovanje", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    popuststatus = table.Column<string>(name: "popust status", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Grupa_Id = table.Column<int>(type: "int", nullable: true),
                    Brojputovanja = table.Column<int>(name: "Broj putovanja", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turist", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Turist_Grupa_Grupa_Id",
                        column: x => x.Grupa_Id,
                        principalTable: "Grupe",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Zaduzenja",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Putovanje_Id = table.Column<int>(type: "int", nullable: true),
                    Vodic_Id = table.Column<int>(type: "int", nullable: true),
                    Grupa_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaduzenja", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Zaduzenja_grupa_Grupa_Id",
                        column: x => x.Grupa_Id,
                        principalTable: "Grupe",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Zaduzenja_Putovanje_PutovanjeId",
                        column: x => x.Putovanje_Id,
                        principalTable: "Putovanje",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Zaduzenja_Vodic_ID",
                        column: x => x.Vodic_Id,
                        principalTable: "Vodic",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Rezervacija_Id = table.Column<int>(type: "int", nullable: true),
                    Turist_Id = table.Column<int>(type: "int", nullable: true),
                    Vodic_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Korisnik_Rezervacija_Rezervacija_Id",
                        column: x => x.Rezervacija_Id,
                        principalTable: "Rezervacija",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Korisnik_Turist_Turist_Id",
                        column: x => x.Turist_Id,
                        principalTable: "Turist",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Korisnik_Vodic_Vodic_Id",
                        column: x => x.Vodic_Id,
                        principalTable: "Vodic",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "KorisniciUloge",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Korisnik_ID = table.Column<int>(type: "int", nullable: false),
                    Uloga_ID = table.Column<int>(type: "int", nullable: false),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciUloge", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Korisnici_ID",
                        column: x => x.Korisnik_ID,
                        principalTable: "Korisnik",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Uloge_ID",
                        column: x => x.Uloga_ID,
                        principalTable: "Uloge",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Notifikacija",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    osoba = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Korisnik_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifikacija", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Notifikacija_Korisnik_Korisnik_Id",
                        column: x => x.Korisnik_Id,
                        principalTable: "Korisnik",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grupe_Putovanje_Id",
                table: "Grupe",
                column: "Putovanje_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Grupe_vodic_id",
                table: "Grupe",
                column: "vodic_id");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_Korisnik_ID",
                table: "KorisniciUloge",
                column: "Korisnik_ID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_Uloga_ID",
                table: "KorisniciUloge",
                column: "Uloga_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_Rezervacija_Id",
                table: "Korisnik",
                column: "Rezervacija_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_Turist_Id",
                table: "Korisnik",
                column: "Turist_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_Vodic_Id",
                table: "Korisnik",
                column: "Vodic_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Lokacija_Putovanje_Id",
                table: "Lokacija",
                column: "Putovanje_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Lokacija_Smjestaj_id",
                table: "Lokacija",
                column: "Smjestaj_id");

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacija_Korisnik_Id",
                table: "Notifikacija",
                column: "Korisnik_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_Aktivnosti_Putovanje_ID",
                table: "Plan_Aktivnosti",
                column: "Putovanje_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Putovanje_Drzava_Id",
                table: "Putovanje",
                column: "Drzava_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_Putovanje_ID",
                table: "Rezervacija",
                column: "Putovanje_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_Smjestaj_Id",
                table: "Rezervacija",
                column: "Smjestaj_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Turist_Grupa_Id",
                table: "Turist",
                column: "Grupa_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Zaduzenja_Grupa_Id",
                table: "Zaduzenja",
                column: "Grupa_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Zaduzenja_Putovanje_Id",
                table: "Zaduzenja",
                column: "Putovanje_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Zaduzenja_Vodic_Id",
                table: "Zaduzenja",
                column: "Vodic_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrzavaNU");

            migrationBuilder.DropTable(
                name: "Grupe2");

            migrationBuilder.DropTable(
                name: "KorisniciUloge");

            migrationBuilder.DropTable(
                name: "Korisnik2");

            migrationBuilder.DropTable(
                name: "Lokacija");

            migrationBuilder.DropTable(
                name: "LokacijaNU");

            migrationBuilder.DropTable(
                name: "Notifikacija");

            migrationBuilder.DropTable(
                name: "Notifikacija2");

            migrationBuilder.DropTable(
                name: "Plan_Aktivnosti");

            migrationBuilder.DropTable(
                name: "Plan_Aktivnosti2");

            migrationBuilder.DropTable(
                name: "Putovanje2");

            migrationBuilder.DropTable(
                name: "Zaduzenja");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Rezervacija");

            migrationBuilder.DropTable(
                name: "Turist");

            migrationBuilder.DropTable(
                name: "Smjestaj");

            migrationBuilder.DropTable(
                name: "Grupe");

            migrationBuilder.DropTable(
                name: "Putovanje");

            migrationBuilder.DropTable(
                name: "Vodic");

            migrationBuilder.DropTable(
                name: "Drzava");
        }
    }
}
