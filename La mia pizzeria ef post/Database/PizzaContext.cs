using Microsoft.EntityFrameworkCore;
using NetCore_01.Models;

namespace La_mia_pizzeria_ef_post.Database {
    public class PizzaContext : DbContext {

        public DbSet<Pizza> Pizze { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=MiaPizzeriaEF;" +
            "Integrated Security=True;TrustServerCertificate=True");
        }

    }
}
