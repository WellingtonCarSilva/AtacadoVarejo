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

        public async Task<Guid> CancelaPedidoAsync(Guid id)
        {
            await atacadistaAdapter.CancelaPedidoAsync(id);
            return id;
        }

        public async Task<Guid> ConfirmaPedidoAsync(Guid id)
        {
            await atacadistaAdapter.ConfirmaPedidoAsync(id);
            return id;
        }

        public async Task<Orcamento> SolicitaOrcamentoAsync(Orcamento orcamento)
        {
            await atacadistaAdapter.SolicitaOrcamentoAsync(orcamento);

            return orcamento;
        }
    }
}
