using System.Collections.Generic;

namespace Varegista.Dominio.Models
{
    public class Orcamento
    {
        public IEnumerable<Pedido> Pedidos { get; set; }
    }
}
