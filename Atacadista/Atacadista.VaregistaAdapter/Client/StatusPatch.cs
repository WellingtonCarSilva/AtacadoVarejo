namespace Atacadista.VaregistaAdapter.Client
{
    public class StatusPatch
    {
        public StatusPedido Status { get; set; }
    }
    public enum StatusPedido
    {
        Solicitado,
        Fabricando,
        Despachado
    }
}
