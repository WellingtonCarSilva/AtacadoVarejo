namespace Varegista.WebApi.Dto
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
