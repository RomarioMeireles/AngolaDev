namespace AngolaDev.Pedidos.Model
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public string Cliente { get; set; }
        public decimal Valor { get; set; }
    }
}
