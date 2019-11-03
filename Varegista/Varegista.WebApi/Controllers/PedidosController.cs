using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Varegista.Dominio.Models;
using Varegista.Service.Interfaces;
using Varegista.WebApi.Dto;

namespace Varegista.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidoService pedidoService;
        private readonly IMapper mapper;

        public PedidosController(IPedidoService pedidoService, IMapper mapper) {
            this.pedidoService = pedidoService ?? throw new ArgumentNullException(nameof(pedidoService));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpPost("{id}/orcamento")]
        public IActionResult SolicitarOrcamentoAsync([FromRoute]Guid id, [FromBody]OrcamentoPost orcamentoPost)
        {
            return Ok();
        }

        [HttpPatch("{id}/status")]
        public IActionResult AtualizaStatus([FromRoute]Guid id, [FromBody]StatusPatch statusPatch)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(PedidoPost pedidoPost)
        {
            var orcamento = mapper.Map<Orcamento>(pedidoPost);

            await pedidoService.SolicitaOrcamentoAsync(orcamento);

            return Ok();
        }

        [HttpPatch("{id}/Confirma")]
        public async Task<IActionResult> ConfirmaPedidoAsync(Guid id)
        {
           await pedidoService.ConfirmaPedidoAsync(id);

            return Ok();
        }

        [HttpPatch("{id}/Cancela")]
        public async Task<IActionResult> CancelaPedidoAsync(Guid id)
        {
            await pedidoService.CancelaPedidoAsync(id);

            return Ok();
        }

    }
}