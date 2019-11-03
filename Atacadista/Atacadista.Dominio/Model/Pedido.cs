using System;
using System.Collections.Generic;
using System.Text;

namespace Atacadista.Dominio.Model
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public int CodigoProduto { get; set; }
        public int Quantidade { get; set; }
        public string Observacao { get; set; }
        public StatusPedido Status { get; set; }
    }

    public enum StatusPedido
    {
        Solicitado,
        Fabricando,
        Despachado
    }
}
