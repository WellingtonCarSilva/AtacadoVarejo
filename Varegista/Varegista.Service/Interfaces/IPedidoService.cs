using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Varegista.Dominio.Models;

namespace Varegista.Service.Interfaces
{
    public interface IPedidoService
    {
        Task SolicitaOrcamentoAsync(Orcamento orcamento);
        Task ConfirmaPedidoAsync(Guid id);
        Task CancelaPedidoAsync(Guid id);
    }
}
