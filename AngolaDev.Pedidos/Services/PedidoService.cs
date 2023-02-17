using AngolaDev.Pagamentos.Contracts;
using AngolaDev.Pagamentos.Model;
using AngolaDev.Pedidos.Configuration;
using AngolaDev.Pedidos.Contracts;
using AngolaDev.Pedidos.Model;
using Microsoft.EntityFrameworkCore;

namespace AngolaDev.Pedidos.Services
{
    public class PedidoService : IPedidoContract
    {
        private readonly PedidoContext _context;
        private readonly IPagamentoContract _pagamentoContract;

        public PedidoService(PedidoContext context, IPagamentoContract pagamentoContract)
        {
            _context = context;
            _pagamentoContract = pagamentoContract;
        }

        public Task Adicionar(Pedido pedido)
        {
            _context.Add(pedido);
            _context.SaveChanges();

            var pagamento = new Pagamento()
            {
                Id = Guid.NewGuid(),
                PedidoId = pedido.Id,
                Valor = pedido.Valor
            };

            _pagamentoContract.RegistarPagamento(pagamento);

            return  Task.CompletedTask;
        }

        public async Task<IEnumerable<Pedido>> ObterTodos()
        {
            return await _context.Pedido.ToListAsync();
        }
    }
}
