using Microsoft.EntityFrameworkCore;
using System;
using Entidades;

namespace WebApplication1.Controllers
{
    public class TareasDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source =tareas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .ToTable("Usuarios");
            modelBuilder.Entity<Tarea>()
                .ToTable("Tareas");
            modelBuilder.Entity<Recurso>()
                .ToTable("Recursos");
            modelBuilder.Entity<Detalle>()
                .ToTable("Detalles");
            modelBuilder.Entity<Rol>()
                .ToTable("Roles");
            modelBuilder.Entity<TipoTarea>()
                .ToTable("TipoTareas");
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<TipoTarea> TipoTareas { get; set; }
    }
}
