using System;
using System.Collections.Generic;
using System.Text;

namespace Atacadista.Dominio.Model
{
    public class Orcamento
    {
        public Guid Id { get; set; }
        public IEnumerable<Pedido> Pedidos { get; set; }
        public double Valor { get; set; }
        public DateTimeOffset DataRealizacao { get; set; }
        public int Status { get; set; }
    }
}
