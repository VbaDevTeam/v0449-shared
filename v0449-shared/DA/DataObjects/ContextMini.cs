using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
//using MySql.EntityFrameworkCore;
using VbaLib;

#nullable disable

namespace v0449_shared
{
  public partial class ContextMini : DbContext
  {

    string myConnDb = "server=mysqlsrv;port=3306;user=root;password=mysqlpwd;database=0449-dbHP";

    public ContextMini()
    {
    }

    public ContextMini(string strConnDb)
    {
      myConnDb = strConnDb;
    }

    public ContextMini(DbContextOptions<Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Confapp> Confapps
    {
      get; set;
    }

    public virtual DbSet<Eventlog> Eventlogs
    {
      get; set;
    }
    public virtual DbSet<Reportbody> Reportbodies
    {
      get; set;
    }
    public virtual DbSet<Reportheader> Reportheaders
    {
      get; set;
    }
    public virtual DbSet<S7evtlog> S7evtlogs
    {
      get; set;
    }
    public virtual DbSet<Tblcodicidisegni> Tblcodicidisegnis
    {
      get; set;
    }
    public virtual DbSet<Utenti> Utentis
    {
      get; set;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        optionsBuilder.UseMySQL(myConnDb);
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Confapp>(entity => {
        entity.HasKey(e => e.CaId)
            .HasName("PRIMARY");

        entity.ToTable("confapp");

        entity.Property(e => e.CaId)
            .HasColumnType("int unsigned")
            .HasColumnName("caId");

        entity.Property(e => e.CaAuth)
            .IsRequired()
            .HasMaxLength(45)
            .HasColumnName("caAuth")
            .HasDefaultValueSql("''");

        entity.Property(e => e.CaConfigData)
            .IsRequired()
            .HasColumnType("longtext")
            .HasColumnName("caConfigData");

        entity.Property(e => e.CaDate)
            .HasColumnName("caDate")
            .HasDefaultValueSql("'0000-00-00 00:00:00'");

        entity.Property(e => e.CaEngine)
            .IsRequired()
            .HasMaxLength(45)
            .HasColumnName("caEngine")
            .HasDefaultValueSql("''");

        entity.Property(e => e.CaGbx)
            .IsRequired()
            .HasMaxLength(45)
            .HasColumnName("caGbx")
            .HasDefaultValueSql("''");

        entity.Property(e => e.CaSetNo)
            .HasColumnType("int unsigned")
            .HasColumnName("caSetNo");

        entity.Property(e => e.CaType)
            .IsRequired()
            .HasMaxLength(45)
            .HasColumnName("caType")
            .HasDefaultValueSql("''");
      });

     modelBuilder.Entity<Eventlog>(entity => {
        entity.HasKey(e => e.EventId)
            .HasName("PRIMARY");

        entity.ToTable("eventlog");

        entity.HasComment("Storicizzazione eventi sistema");

        entity.Property(e => e.EventId)
            .HasColumnType("int unsigned")
            .HasColumnName("eventId");

        entity.Property(e => e.Attivazione)
            .HasColumnType("tinyint")
            .HasColumnName("attivazione");

        entity.Property(e => e.CodiceEvento)
            .HasColumnType("int unsigned")
            .HasColumnName("codiceEvento");

        entity.Property(e => e.DescrEvento)
            .IsRequired()
            .HasColumnName("descrEvento");

        entity.Property(e => e.Info)
            .IsRequired()
            .HasColumnName("info");

        entity.Property(e => e.IstanteEvento)
            .HasColumnName("istanteEvento")
            .HasDefaultValueSql("'2000-01-01 00:00:00'");

        entity.Property(e => e.TipoEvento)
            .IsRequired()
            .HasMaxLength(45)
            .HasColumnName("tipoEvento")
            .HasDefaultValueSql("''");
      });

      modelBuilder.Entity<Reportbody>(entity => {
        entity.HasKey(e => e.RbId)
            .HasName("PRIMARY");

        entity.ToTable("reportbody");

        entity.Property(e => e.RbId)
            .HasColumnType("int unsigned")
            .HasColumnName("rbId");

        entity.Property(e => e.RbAngolo).HasColumnName("rbAngolo");

        entity.Property(e => e.RbAngoloMax).HasColumnName("rbAngoloMax");

        entity.Property(e => e.RbAngoloMin).HasColumnName("rbAngoloMin");

        entity.Property(e => e.RbDurata).HasColumnName("rbDurata");

        entity.Property(e => e.RbEsito)
            .IsRequired()
            .HasMaxLength(45)
            .HasColumnName("rbEsito");

        entity.Property(e => e.RbFase)
            .HasColumnType("int unsigned")
            .HasColumnName("rbFase");

        entity.Property(e => e.RbGiriMotore).HasColumnName("rbGiriMotore");

        entity.Property(e => e.RbGiriPompa).HasColumnName("rbGiriPompa");

        entity.Property(e => e.RbGiriPompaMax).HasColumnName("rbGiriPompaMax");

        entity.Property(e => e.RbGiriPompaMin).HasColumnName("rbGiriPompaMin");

        entity.Property(e => e.RbPortata).HasColumnName("rbPortata");

        entity.Property(e => e.RbPortataMax).HasColumnName("rbPortataMax");

        entity.Property(e => e.RbPortataMin).HasColumnName("rbPortataMin");

        entity.Property(e => e.RbPressAsp).HasColumnName("rbPressAsp");

        entity.Property(e => e.RbPressDiff).HasColumnName("rbPressDiff");

        entity.Property(e => e.RbPressDiffMax).HasColumnName("rbPressDiffMax");

        entity.Property(e => e.RbPressDiffMin).HasColumnName("rbPressDiffMin");

        entity.Property(e => e.RbPressMan).HasColumnName("rbPressMan");

        entity.Property(e => e.RbRhId)
            .HasColumnType("int unsigned")
            .HasColumnName("rbRhId");

        entity.Property(e => e.RbTempFluido).HasColumnName("rbTempFluido");

        entity.Property(e => e.RbTempFluidoMax).HasColumnName("rbTempFluidoMax");

        entity.Property(e => e.RbTempFluidoMin).HasColumnName("rbTempFluidoMin");
      });

      modelBuilder.Entity<Reportheader>(entity => {
        entity.HasKey(e => e.RhId)
            .HasName("PRIMARY");

        entity.ToTable("reportheader");

        entity.Property(e => e.RhId)
            .HasColumnType("int unsigned")
            .HasColumnName("rhId");


        entity.Property(e => e.RhCdId)
            .HasColumnType("int unsigned")
            .HasColumnName("rhCdId");

        entity.Property(e => e.RhCdCaSetNo)
            .HasColumnType("int unsigned")
            .HasColumnName("rhCdCaSetNo");

        entity.Property(e => e.RhState)
            .HasColumnType("int unsigned")
            .HasColumnName("rhState");

        entity.Property(e => e.RhCodiceUtente)
              .HasColumnType("int unsigned")
              .HasColumnName("rhCodiceUtente");

        entity.Property(e => e.RhDate).HasColumnName("rhDate");

        entity.Property(e => e.RhNomeProva)
            .IsRequired()
            .HasMaxLength(200)
            .HasColumnName("rhNomeProva");

        entity.Property(e => e.RhSerialiItems)
            .IsRequired()
            .HasMaxLength(255)
            .HasColumnName("rhSerialiItems");

      });

      modelBuilder.Entity<S7evtlog>(entity => {
        entity.HasKey(e => e.EventId)
            .HasName("PRIMARY");

        entity.ToTable("s7evtlog");

        entity.HasComment("Storicizzazione eventi sistema");

        entity.Property(e => e.EventId)
            .HasColumnType("int unsigned")
            .HasColumnName("eventId");

        entity.Property(e => e.Attivazione).HasColumnName("attivazione");

        entity.Property(e => e.CodiceEvento)
            .HasColumnType("int unsigned")
            .HasColumnName("codiceEvento");

        entity.Property(e => e.DescrEvento)
            .IsRequired()
            .HasColumnName("descrEvento");

        entity.Property(e => e.Info)
            .IsRequired()
            .HasColumnName("info");

        entity.Property(e => e.IstanteEvento)
            .HasColumnName("istanteEvento")
            .HasDefaultValueSql("'2000-01-01 00:00:00'");

        entity.Property(e => e.TipoEvento)
            .IsRequired()
            .HasMaxLength(45)
            .HasColumnName("tipoEvento")
            .HasDefaultValueSql("''");
      });

      modelBuilder.Entity<Tblcodicidisegni>(entity => {
        entity.HasKey(e => e.CdId)
            .HasName("PRIMARY");

        entity.ToTable("tblcodicidisegni");

        entity.Property(e => e.CdId).HasColumnName("cdId");

        entity.Property(e => e.CdDescr)
            .HasMaxLength(45)
            .HasColumnName("cdDescr");

        entity.Property(e => e.CdName)
            .IsRequired()
            .HasMaxLength(45)
            .HasColumnName("cdName");

        entity.Property(e => e.CdLoops)
              .IsRequired()
              .HasColumnName("cdLoops");

        entity.Property(e => e.CdValid)
              .HasColumnName("cdValid")
              .HasDefaultValueSql("'1'");
      });

      modelBuilder.Entity<Utenti>(entity => {
        entity.HasKey(e => e.CodiceUtente)
            .HasName("PRIMARY");

        entity.ToTable("utenti");

        entity.Property(e => e.CodiceUtente).HasColumnType("int unsigned");

        entity.Property(e => e.Amministratore).HasColumnType("int unsigned");

        entity.Property(e => e.Cognome)
            .IsRequired()
            .HasMaxLength(45)
            .HasDefaultValueSql("''");

        entity.Property(e => e.Diritti).HasColumnType("int unsigned");

        entity.Property(e => e.EMail)
            .IsRequired()
            .HasMaxLength(45)
            .HasColumnName("eMail");

        entity.Property(e => e.Nome)
            .IsRequired()
            .HasMaxLength(45)
            .HasDefaultValueSql("''");

        entity.Property(e => e.Password)
            .IsRequired()
            .HasMaxLength(45)
            .HasDefaultValueSql("''");

        entity.Property(e => e.UserName)
            .IsRequired()
            .HasMaxLength(25)
            .HasDefaultValueSql("''");
      });

      OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
  }
}
