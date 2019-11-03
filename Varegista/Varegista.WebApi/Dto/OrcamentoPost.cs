using System;

namespace Varegista.WebApi.Dto
{
    public class OrcamentoPost
    {
        public decimal Valor { get; set; }
        public DateTimeOffset DataRealizacao { get; set; }
    }
}
