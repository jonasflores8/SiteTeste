namespace SiteTeste.Models
{
	public class Pedido
	{
		public Guid Id { get; set; }
		public DateTime DtPedido { get; set; }
		public bool StatusPedido { get; set; }
		public Guid IdUsuario { get; set; }
		public DateTime DtPagamento { get; set; }
		public Guid Valor { get; set; } 
		public Usuario? Usuario { get; set; } 
	}
}
