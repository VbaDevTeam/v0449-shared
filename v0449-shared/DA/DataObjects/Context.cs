﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
//using MySql.EntityFrameworkCore;
using MySql.EntityFrameworkCore;

#nullable disable

namespace v0449_shared
{
  public partial class Context : DbContext
  {
      // string myConnDb = "server=mysqlsrv;port=3306;user=root;password=mysqlpwd;database=0449-dbHP";
      string myConnDb = "";
    public Context()
    {
    }

    public Context(string strConnDb)
    {
      myConnDb = strConnDb;
    }
    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Confapp> Confapps
    {
      get; set;
    }


    public virtual DbSet<Reportheader> Reportheaders
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
        entity.Property(e => e.RhDateStart).HasColumnName("rhDateStart");


        entity.Property(e => e.RhNomeProva)
            .IsRequired()
            .HasMaxLength(200)
            .HasColumnName("rhNomeProva");

        entity.Property(e => e.RhSerialiItems)
            .IsRequired()
            .HasMaxLength(255)
            .HasColumnName("rhSerialiItems");

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
