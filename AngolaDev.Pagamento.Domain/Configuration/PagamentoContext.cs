using AngolaDev.Pagamentos.Model;
using Microsoft.EntityFrameworkCore;

namespace AngolaDev.Pagamentos.Configuration
{
    public class PagamentoContext:DbContext
    {
        public PagamentoContext(DbContextOptions<PagamentoContext> options) : base(options) { }
        public DbSet<Pagamento> Pagamento { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine);
        }
    }
}
