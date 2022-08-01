using System.ComponentModel.DataAnnotations;

namespace SiteTeste.Models
{
	public class ItemPedido
	{
		[Key]
		public Guid Id { get; set; }
		public Guid ProdutoId { get; set; }
		public Guid PedidoId { get; set; }
		public virtual Produto? Produto { get; set; }
		public virtual Pedido? Pedido { get; set; }

	}
}
