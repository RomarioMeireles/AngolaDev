using AngolaDev.Pedidos.Contracts;
using AngolaDev.Pedidos.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AngolaDev.Pedidos.Configuration
{
    public static class Services
    {
        public static void AddPedidoContext(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<PedidoContext>();
            services.AddDbContext<PedidoContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }

        public static void AddPedidoDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IPedidoContract, PedidoService>();
        }
    }
}
