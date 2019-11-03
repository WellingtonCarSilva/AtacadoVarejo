using AutoMapper;
using System;
using System.Threading.Tasks;
using Varegista.AtacadistaAdapter.Client;
using Varegista.Dominio.Models;

namespace Varegista.AtacadistaAdapter
{
    public class AtacadistaAdapter : IAtacadistaAdapter
    {
        private readonly IAtacadista atacadista;
        private readonly IMapper mapper;

        public AtacadistaAdapter(IAtacadista atacadista, IMapper mapper)
        {
            this.atacadista = atacadista ?? throw new ArgumentNullException(nameof(atacadista));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task CancelaPedidoAsync(Guid id)
        {
            await atacadista.CancelaPedidoAsync(id);
        }

        public async Task ConfirmaPedidoAsync(Guid id)
        {
            await atacadista.ConfirmaPedidoAsync(id);
        }

        public async Task SolicitaOrcamentoAsync(Orcamento orcamento)
        {
            var pedidos = mapper.Map<PedidoPost>(orcamento);

            await atacadista.PedidoAsync(pedidos);
        }
    }
}
