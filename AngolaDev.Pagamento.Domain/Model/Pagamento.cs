namespace AngolaDev.Pagamentos.Model
{
    public class Pagamento
    {
        public Guid Id { get; set; }
        public Guid PedidoId { get; set; }
        public decimal Valor { get; set; }
    }
}
