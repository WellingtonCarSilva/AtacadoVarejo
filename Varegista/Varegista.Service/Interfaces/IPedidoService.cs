using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Varegista.Dominio.Models;

namespace Varegista.Service.Interfaces
{
    public interface IPedidoService
    {
        Task<Orcamento> SolicitaOrcamentoAsync(Orcamento orcamento);
        Task<Guid> ConfirmaPedidoAsync(Guid id);
        Task<Guid> CancelaPedidoAsync(Guid id);
    }
}
