using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MCreditos.Models;

public partial class MicroCreditosContext : DbContext
{
    public MicroCreditosContext()
    {
    }

    public MicroCreditosContext(DbContextOptions<MicroCreditosContext> options)
        : base(options)
    {
    }

    public static IEnumerable<object> pago { get; internal set; }
    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {


        /* #warning  To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                => optionsBuilder.UseSqlServer("server=localhost; database=MicroCreditos; integrated security=true; TrustServerCertificate=True");*/
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pagos__3214EC07CCB82A30");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(6, 2)");

            entity.HasOne(d => d.Persona).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.PersonaId)
                .HasConstraintName("FK_Pagos_Personas");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Personas__3214EC07AF5F61F8");

            entity.Property(e => e.ApellidoMaterno).HasMaxLength(50);
            entity.Property(e => e.ApellidoPaterno).HasMaxLength(50);
            entity.Property(e => e.CantidadPrestada).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FechaPrestamo).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.Telefono).HasMaxLength(32);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
