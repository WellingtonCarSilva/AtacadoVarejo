using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Varegista.AtacadistaAdapter.Client;

namespace Varegista.AtacadistaAdapter
{
    public interface IAtacadista
    {
        [Post("/api/pedidos/orcamento")]
        Task PedidoAsync([Body] PedidoPost pedidoPost);

        [Patch("/api/pedidos/{id}/Confirma")]
        Task ConfirmaPedidoAsync([Query] Guid id);

        [Patch("/api/pedidos/{id}/Cancela")]
        Task CancelaPedidoAsync([Query] Guid id);
    }
}
