using System;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
#nullable disable

namespace BurseFMI.dbModels
{
    public partial class BurseFMIContext : IdentityDbContext
    {
        public BurseFMIContext()
        {
        }

        public BurseFMIContext(DbContextOptions<BurseFMIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acordum> Acorda { get; set; }
        public virtual DbSet<Beneficiaza> Beneficiazas { get; set; }
        public virtual DbSet<Bursa> Bursas { get; set; }
        public virtual DbSet<Comisie> Comisies { get; set; }
        public virtual DbSet<Completate> Completates { get; set; }
        public virtual DbSet<Contesta> Contestas { get; set; }
        public virtual DbSet<Criteriu> Criterius { get; set; }
        public virtual DbSet<ImportSecretar> ImportSecretars { get; set; }
        public virtual DbSet<InfoEvaluareSolicitare> InfoEvaluareSolicitares { get; set; }
        public virtual DbSet<Membru> Membrus { get; set; }
        public virtual DbSet<Solicitare> Solicitares { get; set; }
        public virtual DbSet<Specializare> Specializares { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User Id=postgres;Password=123456;Database=Database6;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   base.OnModelCreating(modelBuilder);
            modelBuilder.HasAnnotation("Relational:Collation", "Romanian_Romania.1250");

            modelBuilder.Entity<Acordum>(entity =>
            {
                entity.HasKey(e => new { e.CodCriteriu, e.CodBursa })
                    .HasName("acorda_pkey");

                entity.ToTable("acorda");

                entity.Property(e => e.CodCriteriu)
                    .HasColumnName("cod_criteriu");

                entity.Property(e => e.CodBursa)
                    .HasColumnName("cod_bursa");

                entity.HasOne(d => d.CodBursaNavigation)
                    .WithMany(p => p.Acorda)
                    .HasForeignKey(d => d.CodBursa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("acorda_cod_bursa_fkey");

                entity.HasOne(d => d.CodCriteriuNavigation)
                    .WithMany(p => p.Acorda)
                    .HasForeignKey(d => d.CodCriteriu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("acorda_cod_criteriu_fkey");
            });

            modelBuilder.Entity<Beneficiaza>(entity =>
            {
                entity.HasKey(e => new { e.CodMatricol, e.CodBursa })
                    .HasName("beneficiaza_pkey");

                entity.ToTable("beneficiaza");

                entity.Property(e => e.CodMatricol)
                    .HasColumnName("cod_matricol");

                entity.Property(e => e.CodBursa)
                    .HasColumnName("cod_bursa");

                entity.Property(e => e.CaleFisier)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("cale_fisier");

                entity.Property(e => e.DataValidare)
                    .HasColumnType("date")
                    .HasColumnName("data_validare");

                entity.Property(e => e.NumeFisierDeclAcceptare)
                    .HasMaxLength(50)
                    .HasColumnName("nume_fisier_decl_acceptare");

                entity.HasOne(d => d.CodBursaNavigation)
                    .WithMany(p => p.Beneficiazas)
                    .HasForeignKey(d => d.CodBursa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("beneficiaza_cod_bursa_fkey");

                entity.HasOne(d => d.CodMatricolNavigation)
                    .WithMany(p => p.Beneficiazas)
                    .HasForeignKey(d => d.CodMatricol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("beneficiaza_cod_matricol_fkey");
            });

            modelBuilder.Entity<Bursa>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("bursa_pkey");

                entity.ToTable("bursa");

                entity.Property(e => e.Cod)
                    .HasMaxLength(30)
                    .HasColumnName("cod");
   

                entity.Property(e => e.Buget).HasColumnName("buget");

                entity.Property(e => e.CodComisie)
                    .HasMaxLength(30)
                    .HasColumnName("cod_comisie");

                entity.Property(e => e.DataFinal)
                    .HasColumnType("date")
                    .HasColumnName("data_final");

                entity.Property(e => e.DataInceput)
                    .HasColumnType("date")
                    .HasColumnName("data_inceput");

                entity.Property(e => e.DataLimitaContestatie)
                    .HasColumnType("date")
                    .HasColumnName("data_limita_contestatie");

                entity.Property(e => e.DataLimitaRecenzie)
                    .HasColumnType("date")
                    .HasColumnName("data_limita_recenzie");

                entity.Property(e => e.DataLimitaSolicitare)
                    .HasColumnType("date")
                    .HasColumnName("data_limita_solicitare");

                entity.Property(e => e.Descriere)
                    .HasMaxLength(100)
                    .HasColumnName("descriere");

                entity.Property(e => e.NrBurse).HasColumnName("nr_burse");



                entity.Property(e => e.Suma).HasColumnName("suma");

                entity.Property(e => e.Tip)
                    .HasMaxLength(30)
                    .HasColumnName("tip");

                entity.HasOne(d => d.CodComisieNavigation)
                    .WithMany(p => p.Bursas)
                    .HasForeignKey(d => d.CodComisie)
                    .HasConstraintName("bursa_cod_comisie_fkey");
            });

            modelBuilder.Entity<Comisie>(entity =>
            {
                entity.HasKey(e => e.CodComisie)
                    .HasName("comisie_pkey");

                entity.ToTable("comisie");

                entity.Property(e => e.CodComisie)
                    .HasMaxLength(30)
                    .HasColumnName("cod_comisie");

                entity.Property(e => e.Nume)
                    .HasMaxLength(50)
                    .HasColumnName("nume");
            });

            modelBuilder.Entity<Completate>(entity =>
            {
                entity.HasKey(e => e.CodMatricol)
                    .HasName("completate_pkey");

                entity.ToTable("completate");

                entity.Property(e => e.CodMatricol)
                    .HasMaxLength(30)
                    .HasColumnName("cod_matricol");

                entity.Property(e => e.AcordGdpr)
                    .HasMaxLength(30)
                    .HasColumnName("acord_gdpr");

                entity.Property(e => e.AlteDetalii)
                    .HasMaxLength(120)
                    .HasColumnName("alte_detalii");

                entity.Property(e => e.AnInmatriculare).HasColumnName("an_inmatriculare");

                entity.Property(e => e.CaleArhiva)
                    .HasMaxLength(120)
                    .HasColumnName("cale_arhiva");

                entity.Property(e => e.CaleExtrasCont)
                    .HasMaxLength(80)
                    .HasColumnName("cale_extras_cont");

                entity.Property(e => e.Cnp)
                    .HasMaxLength(15)
                    .HasColumnName("cnp");

                entity.Property(e => e.ContributiiStiintifice)
                    .HasColumnType("bit(1)")
                    .HasColumnName("contributii_stiintifice");

                entity.Property(e => e.DiplomePremii)
                    .HasColumnType("bit(1)")
                    .HasColumnName("diplome_premii");

                

                entity.Property(e => e.Iban)
                    .HasMaxLength(30)
                    .HasColumnName("iban");

                entity.Property(e => e.NumeArhivaDocsSociala)
                    .HasMaxLength(50)
                    .HasColumnName("nume_arhiva_docs_sociala");

                entity.Property(e => e.NumeFisierExtrasCont)
                    .HasMaxLength(45)
                    .HasColumnName("nume_fisier_extras_cont");

                entity.Property(e => e.TipArhiva)
                    .HasMaxLength(30)
                    .HasColumnName("tip_arhiva");

                entity.Property(e => e.VenitLunarMembru).HasColumnName("venit_lunar_membru");

                entity.Property(e => e.VenitLunarMembruSecretar).HasColumnName("venit_lunar_membru_secretar");

                entity.HasOne(d => d.CodMatricolNavigation)
                    .WithOne(p => p.Completate)
                    .HasForeignKey<Completate>(d => d.CodMatricol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("completate_cod_matricol_fkey");
            });

            modelBuilder.Entity<Contesta>(entity =>
            {
                entity.HasKey(e => new { e.CodMatricol, e.CodBursa })
                    .HasName("contesta_pkey");

                entity.ToTable("contesta");

                entity.Property(e => e.CodMatricol)
                    .HasMaxLength(30)
                    .HasColumnName("cod_matricol");

                entity.Property(e => e.CodBursa)
                    .HasMaxLength(30)
                    .HasColumnName("cod_bursa");

                entity.Property(e => e.DataContestatie)
                    .HasColumnType("date")
                    .HasColumnName("data_contestatie");

                entity.Property(e => e.Motiv)
                    .HasMaxLength(100)
                    .HasColumnName("motiv");

                entity.Property(e => e.ObservatiiSefComisie)
                    .HasMaxLength(100)
                    .HasColumnName("observatii_sef_comisie");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .HasColumnName("status");

                entity.HasOne(d => d.CodBursaNavigation)
                    .WithMany(p => p.Contesta)
                    .HasForeignKey(d => d.CodBursa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contesta_cod_bursa_fkey");

                entity.HasOne(d => d.CodMatricolNavigation)
                    .WithMany(p => p.Contestas)
                    .HasForeignKey(d => d.CodMatricol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contesta_cod_matricol_fkey");
            });

            modelBuilder.Entity<Criteriu>(entity =>
            {
                entity.HasKey(e => e.CodCriteriu)
                    .HasName("criteriu_pkey");

                entity.ToTable("criteriu");

                entity.Property(e => e.CodCriteriu)
                    .HasMaxLength(30)
                    .HasColumnName("cod_criteriu");

                entity.Property(e => e.Descriere)
                    .HasMaxLength(120)
                    .HasColumnName("descriere");
            });

            modelBuilder.Entity<ImportSecretar>(entity =>
            {
                entity.HasKey(e => e.CodMatricol)
                    .HasName("import_secretar_pkey");

                entity.ToTable("import_secretar");

                entity.Property(e => e.CodMatricol)
                    .HasMaxLength(30)
                    .HasColumnName("cod_matricol");

                entity.Property(e => e.MedieAdmitere).HasColumnName("medie_admitere");

                entity.Property(e => e.MedieBac).HasColumnName("medie_bac");

                entity.Property(e => e.MedieGenAnAnterior).HasColumnName("medie_gen_an_anterior");

                entity.Property(e => e.MedieGenSemAnterior).HasColumnName("medie_gen_sem_anterior");

                entity.HasOne(d => d.CodMatricolNavigation)
                    .WithOne(p => p.ImportSecretar)
                    .HasForeignKey<ImportSecretar>(d => d.CodMatricol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("import_secretar_cod_matricol_fkey");
            });

            modelBuilder.Entity<InfoEvaluareSolicitare>(entity =>
            {
                entity.HasKey(e => new { e.CodMatricol, e.CodBursa, e.Email })
                    .HasName("info_evaluare_solicitare_pkey");

                entity.ToTable("info_evaluare_solicitare");

                entity.Property(e => e.CodMatricol)
                    .HasMaxLength(30)
                    .HasColumnName("cod_matricol");

                entity.Property(e => e.CodBursa)
                    .HasMaxLength(30)
                    .HasColumnName("cod_bursa");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.DataUltimeiRecenzii)
                    .HasColumnType("date")
                    .HasColumnName("data_ultimei_recenzii");

                entity.Property(e => e.Observatii)
                    .HasMaxLength(100)
                    .HasColumnName("observatii");

                entity.HasOne(d => d.EmailNavigation)
                    .WithMany(p => p.InfoEvaluareSolicitares)
                    .HasForeignKey(d => d.Email)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("info_evaluare_solicitare_email_fkey");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.InfoEvaluareSolicitares)
                    .HasForeignKey(d => new { d.CodMatricol, d.CodBursa })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("info_evaluare_solicitare_cod_matricol_cod_bursa_fkey");
            });

            modelBuilder.Entity<Membru>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("membru_pkey");

                entity.ToTable("membru");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.CodComisie)
                    .HasMaxLength(30)
                    .HasColumnName("cod_comisie");

                entity.Property(e => e.Functie)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("functie");

                entity.Property(e => e.Nume)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nume");

                entity.Property(e => e.Prenume)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("prenume");

                entity.HasOne(d => d.CodComisieNavigation)
                    .WithMany(p => p.Membrus)
                    .HasForeignKey(d => d.CodComisie)
                    .HasConstraintName("membru_cod_comisie_fkey");
            });

            modelBuilder.Entity<Solicitare>(entity =>
            {
                entity.HasKey(e => new { e.CodMatricol, e.CodBursa })
                    .HasName("solicitare_pkey");

                entity.ToTable("solicitare");

                entity.Property(e => e.CodMatricol)
                    .HasMaxLength(30)
                    .HasColumnName("cod_matricol");

                entity.Property(e => e.CodBursa)
                    .HasMaxLength(30)
                    .HasColumnName("cod_bursa");

                entity.Property(e => e.DataSolicitare)
                    .HasColumnType("date")
                    .HasColumnName("data_solicitare");

                entity.Property(e => e.DataUltimeiModificari)
                    .HasColumnType("date")
                    .HasColumnName("data_ultimei_modificari");

                entity.Property(e => e.DataUltimeiRecenziiSef)
                    .HasMaxLength(50)
                    .HasColumnName("data_ultimei_recenzii_sef");

                entity.Property(e => e.ObservatiiSecretar)
                    .HasMaxLength(100)
                    .HasColumnName("observatii_secretar");

                entity.Property(e => e.ObservatiiSefComisie)
                    .HasMaxLength(100)
                    .HasColumnName("observatii_sef_comisie");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .HasColumnName("status");

                entity.HasOne(d => d.CodBursaNavigation)
                    .WithMany(p => p.Solicitares)
                    .HasForeignKey(d => d.CodBursa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("solicitare_cod_bursa_fkey");

                entity.HasOne(d => d.CodMatricolNavigation)
                    .WithMany(p => p.Solicitares)
                    .HasForeignKey(d => d.CodMatricol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("solicitare_cod_matricol_fkey");
            });

            modelBuilder.Entity<Specializare>(entity =>
            {
                entity.HasKey(e => e.Acronim)
                    .HasName("specializare_pkey");

                entity.ToTable("specializare");

                entity.Property(e => e.Acronim)
                    .HasColumnName("acronim");

                entity.Property(e => e.Domeniu)
                    .HasMaxLength(25)
                    .HasColumnName("domeniu");

                entity.Property(e => e.NrPromovati).HasColumnName("nr_promovati");

                entity.Property(e => e.NrStudenti).HasColumnName("nr_studenti");

                entity.Property(e => e.Nume)
                    .HasMaxLength(50)
                    .HasColumnName("nume");

                entity.Property(e => e.ProgramStudii)
                    .HasMaxLength(30)
                    .HasColumnName("program_studii");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");
                entity.HasKey(e => e.CodMatricol)
                    .HasName("student_pkey");

                entity.ToTable("student");

                entity.Property(e => e.CodMatricol)
                    .HasColumnName("cod_matricol");

                entity.Property(e => e.Acronim)
                    .HasColumnName("acronim");

                entity.Property(e => e.AnCurent).HasColumnName("an_curent");

                entity.Property(e => e.GrupaCurenta).HasColumnName("grupa_curenta");

                entity.Property(e => e.InitialaTata)
                    .HasMaxLength(3)
                    .HasColumnName("initiala_tata");

                entity.Property(e => e.Nume)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("nume");

                entity.Property(e => e.Prenume)
                    .HasMaxLength(45)
                    .HasColumnName("prenume");

                entity.HasOne(d => d.AcronimNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Acronim)
                    .HasConstraintName("student_acronim_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
