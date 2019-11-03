using Atacadista.Dominio.Model;
using System.Threading.Tasks;

namespace Atacadista.Service.Interfaces
{
    public interface IPedidoService
    {
        Task<Orcamento> SolicitaOrcamentoAsync(Orcamento orcamento);

        Task<Pedido> AtualizaStatusPedidoAsync(Pedido pedido);
    }
}
