using Atacadista.Dominio.Model;
using Atacadista.VaregistaAdapter.Interfaces;
using System;
using System.Threading.Tasks;

namespace Atacadista.VaregistaAdapter
{
    public class VaregistaAdapter : IVaregistaAdapter
    {
        private readonly IVaregista varegista;

        public VaregistaAdapter(IVaregista varegista)
        {
            this.varegista = varegista ?? throw new ArgumentNullException(nameof(varegista));
        }

        public async Task NotificaStatusAsync(Guid id, StatusPedido status)
        {
            await varegista.AtualizaStatusAsync(id, new Client.StatusPatch
            {
                Status = (Client.StatusPedido)status
            });
        }

        public async Task SolicitaOrcamentoAsync(Orcamento orcamento)
        {
            await varegista.OrcamentoAsync(orcamento.Id, new Client.OrcamentoPost
            {
                DataRealizacao = DateTime.Now,
                Valor = orcamento.Valor
            });
        }
    }
}
