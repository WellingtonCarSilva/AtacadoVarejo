using System.Collections.Generic;

namespace Atacadista.WebApi.Dto
{
    public class PedidoPost
    {
        public IEnumerable<ItemPedidoPost> Pedidos { get; set; }
    }
}
