using AngolaDev.Pagamentos.Contracts;
using AngolaDev.Pagamentos.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AngolaDev.Pagamentos.Configuration
{
    public static class Service
    {
        public static void AddPagamentoContext(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<PedidoContext>();
            services.AddDbContext<PagamentoContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }

        public static void AddPagamentoDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IPagamentoContract, PagamentoService>();
        }
    }
}
