using AngolaDev.Pagamentos.Model;

namespace AngolaDev.Pagamentos.Contracts
{
    public interface IPagamentoContract
    {
        Task RegistarPagamento(Pagamento pagamento);
        Task<IEnumerable<Pagamento>> ObterPagamentos();
    }
}
