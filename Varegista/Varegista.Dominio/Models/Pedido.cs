using System;
using System.Collections.Generic;
using System.Text;

namespace Varegista.Dominio.Models
{
    public class Pedido
    {
        public int CodigoProduto { get; set; }
        public int Quantidade { get; set; }
        public string Observacao { get; set; }
    }
}
