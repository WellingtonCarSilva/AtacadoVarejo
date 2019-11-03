using Atacadista.Dominio.Model;
using System.Threading.Tasks;

namespace Atacadista.Service.Interfaces
{
    public interface IPedidoService
    {
        Task SolicitaOrcamentoAsync(Orcamento orcamento);

        Task AtualizaStatusPedidoAsync(Pedido pedido);
    }
}
