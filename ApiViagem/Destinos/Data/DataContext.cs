using Destinos.Model;
using Microsoft.EntityFrameworkCore;

namespace Destinos.Data
{

    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Destino> Destinos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Destino>().HasData(
                new Destino { Id = 1, Nome = "Jericoacoara", Estado = "Ceará", Pais ="Brasil", destinoUrl = "https://images.app.goo.gl/ABgHR8ke9GDL989LA", Valor ="R$ 659,00"},
                new Destino { Id = 2, Nome = "Cancún", Estado = "-----", Pais ="México", destinoUrl = "https://images.app.goo.gl/ivU6g68fYRVsVg4j8", Valor ="R$ 2.000,00"}
            );
        }

    }

}
