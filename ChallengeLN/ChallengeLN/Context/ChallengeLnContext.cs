using ChallengeLN.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeLN.Context;

public partial class ChallengeLnContext : DbContext
{
    public ChallengeLnContext()
    {
    }

    public ChallengeLnContext(DbContextOptions<ChallengeLnContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contacto> Contactos { get; set; }

    public virtual DbSet<Domicilio> Domicilios { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contacto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contacto__3214EC274B87E835");

            entity.ToTable("Contacto");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Empresa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
            entity.Property(e => e.Imagen)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Telefono)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");

            modelBuilder.Entity<Contacto>()
            .HasOne(c => c.Domicilio)
            .WithOne(d => d.Contacto)
            .HasForeignKey<Contacto>(c => c.DomicilioId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_Contacto_Domicilio");
        });

        modelBuilder.Entity<Domicilio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Domicilio__3214EC27BCC346F7");
            entity.ToTable("Domicilio");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
