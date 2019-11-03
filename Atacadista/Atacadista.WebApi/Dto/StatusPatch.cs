using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atacadista.WebApi.Dto
{
    public class StatusPatch
    {
        public StatusPedido StatusPedido { get; set; }
    }
    public enum StatusPedido
    {
        Solicitado,
        Fabricando,
        Despachado
    }
}
