using Microsoft.EntityFrameworkCore;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class AppContext : DbContext
    {

        public DbSet<EntidadPersona> Personas { get; set; }
        public DbSet<EntidadVeterinario> Veterinarios { get; set; }
        public DbSet<EntidadCliente> Cliente { get; set; }
        public DbSet<EntidadMascota> Mascota { get; set; }
        public DbSet<EntidadVacuna> Vacuna { get; set; }
        public DbSet<EntidadHistoriaClinico> HistorialClinico { get; set; }
        public DbSet<EntidadCitas> Cita { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =BDVeterinariaGrupo26");
            }



        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntidadMascota>()
           .HasOne(e => e.Veterinario)
            .WithMany(c=> c.listaMascotas)
            .HasForeignKey("IdVeterinario")
            .OnDelete(DeleteBehavior.NoAction);


        }
        

    }
}