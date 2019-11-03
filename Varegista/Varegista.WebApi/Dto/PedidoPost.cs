using System.Collections.Generic;

namespace Varegista.WebApi.Dto
{
    public class PedidoPost
    {
        public IEnumerable<ItemPedidoPost> Pedidos { get; set; }
    }
}
