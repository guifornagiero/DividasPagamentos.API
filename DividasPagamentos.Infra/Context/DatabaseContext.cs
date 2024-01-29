using DividasPagamentos.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DividasPagamentos.Infra.Context
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=DividasPagamentos;User ID=sa;Password=#sa123456;Trusted_Connection=False; TrustServerCertificate=True;");
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
