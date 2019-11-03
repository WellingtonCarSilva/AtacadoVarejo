using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Varegista.Dominio.Models;

namespace Varegista.AtacadistaAdapter
{
    public interface IAtacadistaAdapter
    {
        Task SolicitaOrcamentoAsync(Orcamento orcamento);
        Task ConfirmaPedidoAsync(Guid id);
        Task CancelaPedidoAsync(Guid id);
    }
}
