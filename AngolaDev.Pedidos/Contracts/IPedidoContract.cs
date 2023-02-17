using AngolaDev.Pedidos.Model;

namespace AngolaDev.Pedidos.Contracts
{
    public interface IPedidoContract
    {
        Task Adicionar(Pedido pedido);
        Task<IEnumerable<Pedido>> ObterTodos();
    }
}
