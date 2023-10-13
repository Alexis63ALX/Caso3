﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Caso3.Models;

public partial class Parcial20230220100619Context : DbContext
{
    public Parcial20230220100619Context()
    {
    }

    public Parcial20230220100619Context(DbContextOptions<Parcial20230220100619Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Country> Country { get; set; }

    public virtual DbSet<Territory> Territory { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WS2300149;Database=Parcial20230220100619;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.IdCountry);

            entity.Property(e => e.IdCountry)
                .ValueGeneratedNever()
                .HasColumnName("Id_Country");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<Territory>(entity =>
        {
            entity.HasKey(e => e.IdTerritory);

            entity.Property(e => e.IdTerritory)
                .ValueGeneratedNever()
                .HasColumnName("Id_Territory");
            entity.Property(e => e.Area).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.Population)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    internal Task GetAll()
    {
        throw new NotImplementedException();
    }

    internal Task GetById(int id)
    {
        throw new NotImplementedException();
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
