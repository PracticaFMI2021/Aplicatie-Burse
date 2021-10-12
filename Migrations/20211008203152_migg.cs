using System;
using System.Collections;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Test.Migrations
{
    public partial class migg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "comisie",
                columns: table => new
                {
                    cod_comisie = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    nume = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("comisie_pkey", x => x.cod_comisie);
                });

            migrationBuilder.CreateTable(
                name: "criteriu",
                columns: table => new
                {
                    cod_criteriu = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    descriere = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("criteriu_pkey", x => x.cod_criteriu);
                });

            migrationBuilder.CreateTable(
                name: "specializare",
                columns: table => new
                {
                    acronim = table.Column<string>(type: "text", nullable: false),
                    nume = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    domeniu = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    program_studii = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    nr_studenti = table.Column<int>(type: "integer", nullable: true),
                    nr_promovati = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("specializare_pkey", x => x.acronim);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bursa",
                columns: table => new
                {
                    cod = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    tip = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    data_limita_solicitare = table.Column<DateTime>(type: "date", nullable: true),
                    data_limita_recenzie = table.Column<DateTime>(type: "date", nullable: true),
                    data_limita_contestatie = table.Column<DateTime>(type: "date", nullable: true),
                    data_inceput = table.Column<DateTime>(type: "date", nullable: true),
                    data_final = table.Column<DateTime>(type: "date", nullable: true),
                    descriere = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    suma = table.Column<double>(type: "double precision", nullable: true),
                    buget = table.Column<double>(type: "double precision", nullable: true),
                    nr_burse = table.Column<int>(type: "integer", nullable: true),
                    cod_comisie = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("bursa_pkey", x => x.cod);
                    table.ForeignKey(
                        name: "bursa_cod_comisie_fkey",
                        column: x => x.cod_comisie,
                        principalTable: "comisie",
                        principalColumn: "cod_comisie",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "membru",
                columns: table => new
                {
                    email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    nume = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    prenume = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    functie = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    cod_comisie = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("membru_pkey", x => x.email);
                    table.ForeignKey(
                        name: "membru_cod_comisie_fkey",
                        column: x => x.cod_comisie,
                        principalTable: "comisie",
                        principalColumn: "cod_comisie",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "student",
                columns: table => new
                {
                    cod_matricol = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    nume = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    initiala_tata = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: true),
                    prenume = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: true),
                    an_curent = table.Column<int>(type: "integer", nullable: true),
                    grupa_curenta = table.Column<int>(type: "integer", nullable: true),
                    acronim = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("student_pkey", x => x.cod_matricol);
                    table.ForeignKey(
                        name: "student_acronim_fkey",
                        column: x => x.acronim,
                        principalTable: "specializare",
                        principalColumn: "acronim",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "acorda",
                columns: table => new
                {
                    cod_criteriu = table.Column<string>(type: "character varying(30)", nullable: false),
                    cod_bursa = table.Column<string>(type: "character varying(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("acorda_pkey", x => new { x.cod_criteriu, x.cod_bursa });
                    table.ForeignKey(
                        name: "acorda_cod_bursa_fkey",
                        column: x => x.cod_bursa,
                        principalTable: "bursa",
                        principalColumn: "cod",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "acorda_cod_criteriu_fkey",
                        column: x => x.cod_criteriu,
                        principalTable: "criteriu",
                        principalColumn: "cod_criteriu",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "beneficiaza",
                columns: table => new
                {
                    cod_matricol = table.Column<string>(type: "text", nullable: false),
                    cod_bursa = table.Column<string>(type: "character varying(30)", nullable: false),
                    data_validare = table.Column<DateTime>(type: "date", nullable: true),
                    nume_fisier_decl_acceptare = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    cale_fisier = table.Column<BitArray>(type: "bit varying(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("beneficiaza_pkey", x => new { x.cod_matricol, x.cod_bursa });
                    table.ForeignKey(
                        name: "beneficiaza_cod_bursa_fkey",
                        column: x => x.cod_bursa,
                        principalTable: "bursa",
                        principalColumn: "cod",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "beneficiaza_cod_matricol_fkey",
                        column: x => x.cod_matricol,
                        principalTable: "student",
                        principalColumn: "cod_matricol",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "completate",
                columns: table => new
                {
                    cod_matricol = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    an_inmatriculare = table.Column<int>(type: "integer", nullable: true),
                    venit_lunar_membru = table.Column<int>(type: "integer", nullable: true),
                    venit_lunar_membru_secretar = table.Column<int>(type: "integer", nullable: true),
                    contributii_stiintifice = table.Column<BitArray>(type: "bit(1)", nullable: true),
                    diplome_premii = table.Column<BitArray>(type: "bit(1)", nullable: true),
                    acord_gdpr = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    nume_arhiva_docs_sociala = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    cale_arhiva = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: true),
                    tip_arhiva = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    cnp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    alte_detalii = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: true),
                    iban = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    nume_fisier_extras_cont = table.Column<string>(type: "character varying(45)", maxLength: 45, nullable: true),
                    cale_extras_cont = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("completate_pkey", x => x.cod_matricol);
                    table.ForeignKey(
                        name: "completate_cod_matricol_fkey",
                        column: x => x.cod_matricol,
                        principalTable: "student",
                        principalColumn: "cod_matricol",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "contesta",
                columns: table => new
                {
                    cod_matricol = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    cod_bursa = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    data_contestatie = table.Column<DateTime>(type: "date", nullable: true),
                    motiv = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    status = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    observatii_sef_comisie = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("contesta_pkey", x => new { x.cod_matricol, x.cod_bursa });
                    table.ForeignKey(
                        name: "contesta_cod_bursa_fkey",
                        column: x => x.cod_bursa,
                        principalTable: "bursa",
                        principalColumn: "cod",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "contesta_cod_matricol_fkey",
                        column: x => x.cod_matricol,
                        principalTable: "student",
                        principalColumn: "cod_matricol",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "import_secretar",
                columns: table => new
                {
                    cod_matricol = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    medie_gen_an_anterior = table.Column<double>(type: "double precision", nullable: true),
                    medie_gen_sem_anterior = table.Column<double>(type: "double precision", nullable: true),
                    medie_admitere = table.Column<double>(type: "double precision", nullable: true),
                    medie_bac = table.Column<double>(type: "double precision", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("import_secretar_pkey", x => x.cod_matricol);
                    table.ForeignKey(
                        name: "import_secretar_cod_matricol_fkey",
                        column: x => x.cod_matricol,
                        principalTable: "student",
                        principalColumn: "cod_matricol",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "solicitare",
                columns: table => new
                {
                    cod_matricol = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    cod_bursa = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    data_solicitare = table.Column<DateTime>(type: "date", nullable: true),
                    data_ultimei_modificari = table.Column<DateTime>(type: "date", nullable: true),
                    status = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    observatii_secretar = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    observatii_sef_comisie = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    data_ultimei_recenzii_sef = table.Column<DateTime>(type: "timestamp without time zone", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("solicitare_pkey", x => new { x.cod_matricol, x.cod_bursa });
                    table.ForeignKey(
                        name: "solicitare_cod_bursa_fkey",
                        column: x => x.cod_bursa,
                        principalTable: "bursa",
                        principalColumn: "cod",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "solicitare_cod_matricol_fkey",
                        column: x => x.cod_matricol,
                        principalTable: "student",
                        principalColumn: "cod_matricol",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "info_evaluare_solicitare",
                columns: table => new
                {
                    cod_matricol = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    cod_bursa = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    observatii = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    data_ultimei_recenzii = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("info_evaluare_solicitare_pkey", x => new { x.cod_matricol, x.cod_bursa, x.email });
                    table.ForeignKey(
                        name: "info_evaluare_solicitare_cod_matricol_cod_bursa_fkey",
                        columns: x => new { x.cod_matricol, x.cod_bursa },
                        principalTable: "solicitare",
                        principalColumns: new[] { "cod_matricol", "cod_bursa" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "info_evaluare_solicitare_email_fkey",
                        column: x => x.email,
                        principalTable: "membru",
                        principalColumn: "email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_acorda_cod_bursa",
                table: "acorda",
                column: "cod_bursa");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_beneficiaza_cod_bursa",
                table: "beneficiaza",
                column: "cod_bursa");

            migrationBuilder.CreateIndex(
                name: "IX_bursa_cod_comisie",
                table: "bursa",
                column: "cod_comisie");

            migrationBuilder.CreateIndex(
                name: "IX_contesta_cod_bursa",
                table: "contesta",
                column: "cod_bursa");

            migrationBuilder.CreateIndex(
                name: "IX_info_evaluare_solicitare_email",
                table: "info_evaluare_solicitare",
                column: "email");

            migrationBuilder.CreateIndex(
                name: "IX_membru_cod_comisie",
                table: "membru",
                column: "cod_comisie");

            migrationBuilder.CreateIndex(
                name: "IX_solicitare_cod_bursa",
                table: "solicitare",
                column: "cod_bursa");

            migrationBuilder.CreateIndex(
                name: "IX_student_acronim",
                table: "student",
                column: "acronim");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "acorda");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "beneficiaza");

            migrationBuilder.DropTable(
                name: "completate");

            migrationBuilder.DropTable(
                name: "contesta");

            migrationBuilder.DropTable(
                name: "import_secretar");

            migrationBuilder.DropTable(
                name: "info_evaluare_solicitare");

            migrationBuilder.DropTable(
                name: "criteriu");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "solicitare");

            migrationBuilder.DropTable(
                name: "membru");

            migrationBuilder.DropTable(
                name: "bursa");

            migrationBuilder.DropTable(
                name: "student");

            migrationBuilder.DropTable(
                name: "comisie");

            migrationBuilder.DropTable(
                name: "specializare");
        }
    }
}
