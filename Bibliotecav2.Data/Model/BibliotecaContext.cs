using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bibliotecav2.Data.Model;

public partial class BibliotecaContext : DbContext
{
    public BibliotecaContext()
    {
        
    }
    
    public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Genero> Generos { get; set; }

    public virtual DbSet<Libro> Libros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=WINAPBXO5P5WNQL\\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genero>(entity =>
        {
            entity.ToTable("Genero");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Libro>(entity =>
        {
            entity.ToTable("Libro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Annio).HasColumnType("date");
            entity.Property(e => e.Autor).HasMaxLength(50);
            entity.Property(e => e.NombreLibro).HasMaxLength(50);

            entity.HasOne(d => d.Genero).WithMany(p => p.Libros)
                .HasForeignKey(d => d.GeneroId)
                .HasConstraintName("FK__Libro__GeneroId__286302EC");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
