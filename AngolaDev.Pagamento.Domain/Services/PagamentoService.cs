using AngolaDev.Pagamentos.Configuration;
using AngolaDev.Pagamentos.Contracts;
using AngolaDev.Pagamentos.Model;
using Microsoft.EntityFrameworkCore;

namespace AngolaDev.Pagamentos.Services
{
    public class PagamentoService : IPagamentoContract
    {
        private readonly PagamentoContext _context;

        public PagamentoService(PagamentoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pagamento>> ObterPagamentos()
        {
            return await _context.Pagamento.ToListAsync();
        }

        public Task RegistarPagamento(Pagamento pagamento)
        {
            _context.Add(pagamento);
            _context.SaveChanges();

            return Task.CompletedTask;
        }
    }
}
