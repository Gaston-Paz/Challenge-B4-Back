using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Backend.Models
{
    public partial class BackendContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public BackendContext(DbContextOptions<BackendContext> options, IConfiguration configuration)
            : base(options)
        {

            _configuration = configuration;

        }

        public virtual DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => new { e.Id });

                entity.Property(e => e.Nombres)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("Nombres");

                entity.Property(e => e.Apellidos)
                      .HasMaxLength(50)
                      .IsUnicode(false)
                      .IsRequired()
                      .HasColumnName("Apellidos");

                entity.Property(e => e.FechaNacimiento)
                        .HasColumnType("date")
                        .HasColumnName("FechaNacimiento");

                entity.Property(e => e.Cuit)
                      .HasMaxLength(15)
                      .IsUnicode(false)
                      .IsRequired()
                      .HasColumnName("Cuit");

                entity.Property(e => e.Domicilio)
                      .HasMaxLength(250)
                      .IsUnicode(false)
                      .HasColumnName("Domicilio");

                entity.Property(e => e.Celular)
                      .HasMaxLength(50)
                      .IsUnicode(false)
                      .IsRequired()
                      .HasColumnName("Celular");

                entity.Property(e => e.Email)
                      .HasMaxLength(250)
                      .IsUnicode(false)
                      .IsRequired()
                      .HasColumnName("Email");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
