using AngolaDev.Pedidos.Model;
using Microsoft.EntityFrameworkCore;

namespace AngolaDev.Pedidos.Configuration
{
    public class PedidoContext:DbContext
    {
        public PedidoContext(DbContextOptions<PedidoContext> options):base(options){}
        public DbSet<Pedido> Pedido { get; set; }


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
