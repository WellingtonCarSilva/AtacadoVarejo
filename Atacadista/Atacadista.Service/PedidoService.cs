using System;
using System.Threading.Tasks;
using Atacadista.Dominio.Model;
using Atacadista.Service.Interfaces;
using Atacadista.VaregistaAdapter.Interfaces;

namespace Atacadista.Service
{
    public class PedidoService : IPedidoService
    {
        private readonly IVaregistaAdapter varegistaAdapter;

        public PedidoService(IVaregistaAdapter varegistaAdapter)
        {
            this.varegistaAdapter = varegistaAdapter 
                ?? throw new ArgumentNullException(nameof(varegistaAdapter));
        }

        public async Task<Pedido> AtualizaStatusPedidoAsync(Pedido pedido)
        {
            await varegistaAdapter.NotificaStatusAsync(pedido.Id, pedido.Status);
            return pedido;
        }

        public async Task<Orcamento> SolicitaOrcamentoAsync(Orcamento orcamento)
        {
            foreach(var item in orcamento.Pedidos)
            {
                orcamento.Valor += item.Quantidade * (new Random().Next(1, 300) * 1.33);
            }

            await varegistaAdapter.SolicitaOrcamentoAsync(orcamento);
            return orcamento;
        }
    }
}
