using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GXC_API.Models
{
    public partial class GXCContext : DbContext
    {
        public GXCContext()
        {
        }

        public GXCContext(DbContextOptions<GXCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Libro> Libro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libro>(entity =>
            {
                entity.ToTable("LIBRO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Autor)
                    .IsRequired()
                    .HasColumnName("AUTOR")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FechaPublicacion)
                    .HasColumnName("FECHA_PUBLICACION")
                    .HasColumnType("date");

                entity.Property(e => e.NombreLibro)
                    .IsRequired()
                    .HasColumnName("NOMBRE_LIBRO")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroEjemplares).HasColumnName("NUMERO_EJEMPLARES");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
