using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
#nullable disable

namespace Test.Models
{
    public partial class dbburseContext : IdentityDbContext
    {
        public dbburseContext()
        {
        }

        public dbburseContext(DbContextOptions<dbburseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acordum> Acorda { get; set; }
        public virtual DbSet<Beneficiaza> Beneficiazas { get; set; }
        public virtual DbSet<BuildVersion> BuildVersions { get; set; }
        public virtual DbSet<Bursa> Bursas { get; set; }
        public virtual DbSet<Comisie> Comisies { get; set; }
        public virtual DbSet<Completate> Completates { get; set; }
        public virtual DbSet<Contestum> Contesta { get; set; }
        public virtual DbSet<Criteriu> Criterius { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<ImportSecretar> ImportSecretars { get; set; }
        public virtual DbSet<InfoEvaluareSolicitare> InfoEvaluareSolicitares { get; set; }
        public virtual DbSet<Membru> Membrus { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductDescription> ProductDescriptions { get; set; }
        public virtual DbSet<ProductModel> ProductModels { get; set; }
        public virtual DbSet<ProductModelProductDescription> ProductModelProductDescriptions { get; set; }
        public virtual DbSet<Solicitare> Solicitares { get; set; }
        public virtual DbSet<Specializare> Specializares { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User Id=postgres;Password=123456;Database=Database;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   base.OnModelCreating(modelBuilder);
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Acordum>(entity =>
            {
                entity.HasKey(e => new { e.CodCriteriu, e.CodBursa })
                    .HasName("PK__acorda__B16E864A1BE68AF3");

                entity.ToTable("acorda");

                entity.HasIndex(e => e.CodBursa, "IX_acorda_cod_bursa");

                entity.Property(e => e.CodCriteriu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_criteriu")
                    .IsFixedLength(true);

                entity.Property(e => e.CodBursa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_bursa")
                    .IsFixedLength(true);

                entity.HasOne(d => d.CodBursaNavigation)
                    .WithMany(p => p.Acorda)
                    .HasForeignKey(d => d.CodBursa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__acorda__cod_burs__4D2A7347");

                entity.HasOne(d => d.CodCriteriuNavigation)
                    .WithMany(p => p.Acorda)
                    .HasForeignKey(d => d.CodCriteriu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__acorda__cod_crit__4C364F0E");
            });

            modelBuilder.Entity<Beneficiaza>(entity =>
            {
                entity.HasKey(e => new { e.CodMatricol, e.CodBursa })
                    .HasName("PK__benefici__E37498F6180C6922");

                entity.ToTable("beneficiaza");

                entity.HasIndex(e => e.CodBursa, "IX_beneficiaza_cod_bursa");

                entity.Property(e => e.CodMatricol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_matricol")
                    .IsFixedLength(true);

                entity.Property(e => e.CodBursa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_bursa")
                    .IsFixedLength(true);

                entity.Property(e => e.CaleFisier)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("cale_fisier")
                    .IsFixedLength(true);

                entity.Property(e => e.DataValidare)
                    .HasColumnType("date")
                    .HasColumnName("data_validare");

                entity.Property(e => e.NumeFisierDeclAcceptare)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nume_fisier_decl_acceptare")
                    .IsFixedLength(true);

                entity.HasOne(d => d.CodBursaNavigation)
                    .WithMany(p => p.Beneficiazas)
                    .HasForeignKey(d => d.CodBursa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__beneficia__cod_b__477199F1");

                entity.HasOne(d => d.CodMatricolNavigation)
                    .WithMany(p => p.Beneficiazas)
                    .HasForeignKey(d => d.CodMatricol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__beneficia__cod_m__467D75B8");
            });

            modelBuilder.Entity<BuildVersion>(entity =>
            {
                entity.HasKey(e => e.SystemInformationId)
                    .HasName("PK__BuildVer__35E58ECAEA11E762");

                entity.ToTable("BuildVersion");

                entity.Property(e => e.SystemInformationId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SystemInformationID");

                entity.Property(e => e.DatabaseVersion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("Database Version");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VersionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Bursa>(entity =>
            {
                entity.HasKey(e => e.Cod)
                    .HasName("PK__bursa__D8360F7B97AA5FA8");

                entity.ToTable("bursa");

                entity.HasIndex(e => e.CodComisie, "IX_bursa_cod_comisie");

                entity.Property(e => e.Cod)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod")
                    .IsFixedLength(true);

                entity.Property(e => e.Buget).HasColumnName("buget");

                entity.Property(e => e.CodComisie)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_comisie")
                    .IsFixedLength(true);

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
                    .IsUnicode(false)
                    .HasColumnName("descriere")
                    .IsFixedLength(true);

                entity.Property(e => e.NrBurse).HasColumnName("nr_burse");

                entity.Property(e => e.Nume)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nume")
                    .IsFixedLength(true);

                entity.Property(e => e.Suma).HasColumnName("suma");

                entity.Property(e => e.Tip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tip")
                    .IsFixedLength(true);

                entity.HasOne(d => d.CodComisieNavigation)
                    .WithMany(p => p.Bursas)
                    .HasForeignKey(d => d.CodComisie)
                    .HasConstraintName("FK__bursa__cod_comis__382F5661");
            });

            modelBuilder.Entity<Comisie>(entity =>
            {
                entity.HasKey(e => e.CodComisie)
                    .HasName("PK__comisie__FDEE057845701161");

                entity.ToTable("comisie");

                entity.Property(e => e.CodComisie)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_comisie")
                    .IsFixedLength(true);

                entity.Property(e => e.Nume)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nume")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Completate>(entity =>
            {
                entity.HasKey(e => e.CodMatricol)
                    .HasName("PK__completa__C12AE967814B174E");

                entity.ToTable("completate");

                entity.Property(e => e.CodMatricol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_matricol")
                    .IsFixedLength(true);

                entity.Property(e => e.AcordGdpr).HasColumnName("acord_GDPR");

                entity.Property(e => e.AlteDetalii)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("alte_detalii")
                    .IsFixedLength(true);

                entity.Property(e => e.AnInmatriculare).HasColumnName("an_inmatriculare");

                entity.Property(e => e.CaleArhiva)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("cale_arhiva")
                    .IsFixedLength(true);

                entity.Property(e => e.CaleExtrasCont)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("cale_extras_cont")
                    .IsFixedLength(true);

                entity.Property(e => e.Cnp)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CNP")
                    .IsFixedLength(true);

                entity.Property(e => e.ContributiiStiintifice).HasColumnName("contributii_stiintifice");

                entity.Property(e => e.DiplomePremii).HasColumnName("diplome_premii");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength(true);

                entity.Property(e => e.Iban)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IBAN")
                    .IsFixedLength(true);

                entity.Property(e => e.NumeArhivaDocsSociala)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nume_arhiva_docs_sociala")
                    .IsFixedLength(true);

                entity.Property(e => e.NumeFisierExtrasCont)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("nume_fisier_extras_cont")
                    .IsFixedLength(true);

                entity.Property(e => e.TipArhiva)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tip_arhiva")
                    .IsFixedLength(true);

                entity.Property(e => e.VenitLunarMembru).HasColumnName("venit_lunar_membru");

                entity.Property(e => e.VenitLunarMembruSecretar).HasColumnName("venit_lunar_membru_secretar");

                entity.HasOne(d => d.CodMatricolNavigation)
                    .WithOne(p => p.Completate)
                    .HasForeignKey<Completate>(d => d.CodMatricol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__completat__cod_m__2EA5EC27");
            });

            modelBuilder.Entity<Contestum>(entity =>
            {
                entity.HasKey(e => new { e.CodMatricol, e.CodBursa })
                    .HasName("PK__contesta__E37498F662D002AE");

                entity.ToTable("contesta");

                entity.HasIndex(e => e.CodBursa, "IX_contesta_cod_bursa");

                entity.Property(e => e.CodMatricol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_matricol")
                    .IsFixedLength(true);

                entity.Property(e => e.CodBursa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_bursa")
                    .IsFixedLength(true);

                entity.Property(e => e.DataContestatie)
                    .HasColumnType("date")
                    .HasColumnName("data_contestatie");

                entity.Property(e => e.Motiv)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("motiv")
                    .IsFixedLength(true);

                entity.Property(e => e.ObservatiiSefComisie)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("observatii_sef_comisie")
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.HasOne(d => d.CodBursaNavigation)
                    .WithMany(p => p.Contesta)
                    .HasForeignKey(d => d.CodBursa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__contesta__cod_bu__43A1090D");

                entity.HasOne(d => d.CodMatricolNavigation)
                    .WithMany(p => p.Contesta)
                    .HasForeignKey(d => d.CodMatricol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__contesta__cod_ma__42ACE4D4");
            });

            modelBuilder.Entity<Criteriu>(entity =>
            {
                entity.HasKey(e => e.CodCriteriu)
                    .HasName("PK__criteriu__9330F7DB33FA8114");

                entity.ToTable("criteriu");

                entity.Property(e => e.CodCriteriu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_criteriu")
                    .IsFixedLength(true);

                entity.Property(e => e.Descriere)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("descriere")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.ToTable("ErrorLog");

                entity.Property(e => e.ErrorLogId).HasColumnName("ErrorLogID");

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.ErrorProcedure).HasMaxLength(126);

                entity.Property(e => e.ErrorTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<ImportSecretar>(entity =>
            {
                entity.HasKey(e => e.CodMatricol)
                    .HasName("PK__import_s__C12AE96711F793F6");

                entity.ToTable("import_secretar");

                entity.Property(e => e.CodMatricol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_matricol")
                    .IsFixedLength(true);

                entity.Property(e => e.MedieAdmitere).HasColumnName("medie_admitere");

                entity.Property(e => e.MedieBac).HasColumnName("medie_bac");

                entity.Property(e => e.MedieGenAnAnterior).HasColumnName("medie_gen_an_anterior");

                entity.Property(e => e.MedieGenSemAnterior).HasColumnName("medie_gen_sem_anterior");

                entity.HasOne(d => d.CodMatricolNavigation)
                    .WithOne(p => p.ImportSecretar)
                    .HasForeignKey<ImportSecretar>(d => d.CodMatricol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__import_se__cod_m__2BC97F7C");
            });

            modelBuilder.Entity<InfoEvaluareSolicitare>(entity =>
            {
                entity.HasKey(e => new { e.CodMatricol, e.CodBursa, e.Email })
                    .HasName("PK__info_eva__87DFF697CCA56484");

                entity.ToTable("info_evaluare_solicitare");

                entity.HasIndex(e => e.Email, "IX_info_evaluare_solicitare_email");

                entity.Property(e => e.CodMatricol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_matricol")
                    .IsFixedLength(true);

                entity.Property(e => e.CodBursa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_bursa")
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength(true);

                entity.Property(e => e.DataUltimeiRecenzii)
                    .HasColumnType("date")
                    .HasColumnName("data_ultimei_recenzii");

                entity.Property(e => e.Observatii)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("observatii")
                    .IsFixedLength(true);

                entity.HasOne(d => d.EmailNavigation)
                    .WithMany(p => p.InfoEvaluareSolicitares)
                    .HasForeignKey(d => d.Email)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__info_eval__email__3FD07829");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.InfoEvaluareSolicitares)
                    .HasForeignKey(d => new { d.CodMatricol, d.CodBursa })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__info_evaluare_so__3EDC53F0");
            });

            modelBuilder.Entity<Membru>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("PK__membru__AB6E616506D0B07A");

                entity.ToTable("membru");

                entity.HasIndex(e => e.CodComisie, "IX_membru_cod_comisie");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .IsFixedLength(true);

                entity.Property(e => e.CodComisie)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_comisie")
                    .IsFixedLength(true);

                entity.Property(e => e.Functie)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("functie")
                    .IsFixedLength(true);

                entity.Property(e => e.Nume)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nume")
                    .IsFixedLength(true);

                entity.Property(e => e.Prenume)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prenume")
                    .IsFixedLength(true);

                entity.HasOne(d => d.CodComisieNavigation)
                    .WithMany(p => p.Membrus)
                    .HasForeignKey(d => d.CodComisie)
                    .HasConstraintName("FK__membru__cod_comi__3552E9B6");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product", "SalesLT");

                entity.HasIndex(e => e.Name, "AK_Product_Name")
                    .IsUnique();

                entity.HasIndex(e => e.ProductNumber, "AK_Product_ProductNumber")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid, "AK_Product_rowguid")
                    .IsUnique();

                entity.HasIndex(e => e.ProductCategoryId, "IX_Product_ProductCategoryID");

                entity.HasIndex(e => e.ProductModelId, "IX_Product_ProductModelID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Color).HasMaxLength(15);

                entity.Property(e => e.DiscontinuedDate).HasColumnType("datetime");

                entity.Property(e => e.ListPrice).HasColumnType("money");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.ProductModelId).HasColumnName("ProductModelID");

                entity.Property(e => e.ProductNumber)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SellEndDate).HasColumnType("datetime");

                entity.Property(e => e.SellStartDate).HasColumnType("datetime");

                entity.Property(e => e.Size).HasMaxLength(5);

                entity.Property(e => e.StandardCost).HasColumnType("money");

                entity.Property(e => e.ThumbnailPhotoFileName).HasMaxLength(50);

                entity.Property(e => e.Weight).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductCategoryId);

                entity.HasOne(d => d.ProductModel)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductModelId);
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("ProductCategory", "SalesLT");

                entity.HasIndex(e => e.Name, "AK_ProductCategory_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid, "AK_ProductCategory_rowguid")
                    .IsUnique();

                entity.HasIndex(e => e.ParentProductCategoryId, "IX_ProductCategory_ParentProductCategoryID");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ParentProductCategoryId).HasColumnName("ParentProductCategoryID");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.ParentProductCategory)
                    .WithMany(p => p.InverseParentProductCategory)
                    .HasForeignKey(d => d.ParentProductCategoryId)
                    .HasConstraintName("FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID");
            });

            modelBuilder.Entity<ProductDescription>(entity =>
            {
                entity.ToTable("ProductDescription", "SalesLT");

                entity.HasIndex(e => e.Rowguid, "AK_ProductDescription_rowguid")
                    .IsUnique();

                entity.Property(e => e.ProductDescriptionId).HasColumnName("ProductDescriptionID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<ProductModel>(entity =>
            {
                entity.ToTable("ProductModel", "SalesLT");

                entity.HasIndex(e => e.Name, "AK_ProductModel_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid, "AK_ProductModel_rowguid")
                    .IsUnique();

                entity.Property(e => e.ProductModelId).HasColumnName("ProductModelID");

                entity.Property(e => e.CatalogDescription).HasColumnType("xml");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<ProductModelProductDescription>(entity =>
            {
                entity.HasKey(e => new { e.ProductModelId, e.ProductDescriptionId, e.Culture })
                    .HasName("PK_ProductModelProductDescription_ProductModelID_ProductDescriptionID_Culture");

                entity.ToTable("ProductModelProductDescription", "SalesLT");

                entity.HasIndex(e => e.Rowguid, "AK_ProductModelProductDescription_rowguid")
                    .IsUnique();

                entity.HasIndex(e => e.ProductDescriptionId, "IX_ProductModelProductDescription_ProductDescriptionID");

                entity.Property(e => e.ProductModelId).HasColumnName("ProductModelID");

                entity.Property(e => e.ProductDescriptionId).HasColumnName("ProductDescriptionID");

                entity.Property(e => e.Culture)
                    .HasMaxLength(6)
                    .IsFixedLength(true);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.ProductDescription)
                    .WithMany(p => p.ProductModelProductDescriptions)
                    .HasForeignKey(d => d.ProductDescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ProductModel)
                    .WithMany(p => p.ProductModelProductDescriptions)
                    .HasForeignKey(d => d.ProductModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Solicitare>(entity =>
            {
                entity.HasKey(e => new { e.CodMatricol, e.CodBursa })
                    .HasName("PK__solicita__E37498F6DBA45F27");

                entity.ToTable("solicitare");

                entity.HasIndex(e => e.CodBursa, "IX_solicitare_cod_bursa");

                entity.Property(e => e.CodMatricol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_matricol")
                    .IsFixedLength(true);

                entity.Property(e => e.CodBursa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_bursa")
                    .IsFixedLength(true);

                entity.Property(e => e.DataSolicitare)
                    .HasColumnType("date")
                    .HasColumnName("data_solicitare");

                entity.Property(e => e.DataUltimeiModificari)
                    .HasColumnType("date")
                    .HasColumnName("data_ultimei_modificari");

                entity.Property(e => e.DataUltimeiRecenziiSef)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("data_ultimei_recenzii_sef")
                    .IsFixedLength(true);

                entity.Property(e => e.ObservatiiSecretar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("observatii_secretar")
                    .IsFixedLength(true);

                entity.Property(e => e.ObservatiiSefComisie)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("observatii_sef_comisie")
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.HasOne(d => d.CodBursaNavigation)
                    .WithMany(p => p.Solicitares)
                    .HasForeignKey(d => d.CodBursa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__solicitar__cod_b__3BFFE745");

                entity.HasOne(d => d.CodMatricolNavigation)
                    .WithMany(p => p.Solicitares)
                    .HasForeignKey(d => d.CodMatricol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__solicitar__cod_m__3B0BC30C");
            });

            modelBuilder.Entity<Specializare>(entity =>
            {
                entity.HasKey(e => e.Acronim)
                    .HasName("PK__speciali__81793F94B22021E6");

                entity.ToTable("specializare");

                entity.Property(e => e.Acronim)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("acronim")
                    .IsFixedLength(true);

                entity.Property(e => e.Domeniu)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("domeniu")
                    .IsFixedLength(true);

                entity.Property(e => e.NrPromovati).HasColumnName("nr_promovati");

                entity.Property(e => e.NrStudenti).HasColumnName("nr_studenti");

                entity.Property(e => e.Nume)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nume")
                    .IsFixedLength(true);

                entity.Property(e => e.ProgramStudii)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("program_studii")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.CodMatricol)
                    .HasName("PK__student__C12AE96765A0D0D9");

                entity.ToTable("student");

                entity.HasIndex(e => e.Acronim, "IX_student_acronim");

                entity.Property(e => e.CodMatricol)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod_matricol")
                    .IsFixedLength(true);

                entity.Property(e => e.Acronim)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("acronim")
                    .IsFixedLength(true);

                entity.Property(e => e.AnCurent).HasColumnName("an_curent");

                entity.Property(e => e.GrupaCurenta).HasColumnName("grupa_curenta");

                entity.Property(e => e.InitialaTata)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("initiala_tata")
                    .IsFixedLength(true);

                entity.Property(e => e.Nume)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nume")
                    .IsFixedLength(true);

                entity.Property(e => e.Prenume)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("prenume")
                    .IsFixedLength(true);

                entity.HasOne(d => d.AcronimNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Acronim)
                    .HasConstraintName("FK__student__acronim__28ED12D1");
            });

            modelBuilder.HasSequence<int>("SalesOrderNumber", "SalesLT");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
