using Microsoft.EntityFrameworkCore;
using POO_BLAZOR.Models;
using System.Runtime.ConstrainedExecution;

namespace POO_BLAZOR.Data
{
    public class AppDbContext : DbContext
    {
        // Construtor que recebe as opções do DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet para a entidade Veiculo
        public DbSet<Veiculo> Veiculos { get; set; } = null!;

        // DbSet para a entidade MarcaVeiculo (adicionar se necessário)
        public DbSet<Cor> Cores { get; set; } = null!;

        // DbSet para a entidade Cor (adicionar se necessário)
        public DbSet<Marca> Marcas { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
         
        }
    }
}
