using Atacadista.VaregistaAdapter.Client;
using Refit;
using System;
using System.Threading.Tasks;

namespace Atacadista.VaregistaAdapter
{
    public interface IVaregista
    {
        [Post("/pedidos/{id}/orcamento")]
        Task OrcamentoAsync([Query]Guid id, [Body] OrcamentoPost orcamentoPost);

        [Patch("/pedidos/{id}/status")]
        Task AtualizaStatusAsync([Query]Guid id, [Body] StatusPatch statusPatch);
    }
}
