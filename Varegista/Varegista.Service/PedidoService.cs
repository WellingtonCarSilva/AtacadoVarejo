using System;
using System.Threading.Tasks;
using Varegista.AtacadistaAdapter;
using Varegista.Dominio.Models;
using Varegista.Service.Interfaces;

namespace Varegista.Service
{
    public class PedidoService : IPedidoService
    {
        private readonly IAtacadistaAdapter atacadistaAdapter;

        public PedidoService(IAtacadistaAdapter atacadistaAdapter)
        {
            this.atacadistaAdapter = atacadistaAdapter ?? throw new ArgumentNullException(nameof(atacadistaAdapter));
        }

        public async Task CancelaPedidoAsync(Guid id)
        {
            await atacadistaAdapter.CancelaPedidoAsync(id);
        }

        public async Task ConfirmaPedidoAsync(Guid id)
        {
            await atacadistaAdapter.ConfirmaPedidoAsync(id);
        }

        public async Task SolicitaOrcamentoAsync(Orcamento orcamento)
        {
            await atacadistaAdapter.SolicitaOrcamentoAsync(orcamento);
        }
    }
}
