using Atacadista.Dominio.Model;
using System;
using System.Threading.Tasks;

namespace Atacadista.VaregistaAdapter.Interfaces
{
    public interface IVaregistaAdapter
    {
        Task SolicitaOrcamentoAsync(Orcamento orcamento);

        Task NotificaStatusAsync(Guid id, StatusPedido status);
    }
}
