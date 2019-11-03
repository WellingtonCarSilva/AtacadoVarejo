using Atacadista.Dominio.Model;
using Atacadista.Service.Interfaces;
using Atacadista.WebApi.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Atacadista.WebApi.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidoService pedidoService;
        private readonly IMapper mapper;

        public PedidosController(IPedidoService pedidoService, IMapper mapper)
        {
            this.pedidoService = pedidoService ?? throw new ArgumentNullException(nameof(pedidoService));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpPost("orcamento")]
        [ProducesResponseType(typeof(Guid), 200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> PostAsync(PedidoPost pedidoPost)
        {
            var orcamento = mapper.Map<Orcamento>(pedidoPost);
            orcamento.Id = Guid.NewGuid();

            await pedidoService.SolicitaOrcamentoAsync(orcamento);

            return Ok(orcamento.Id);
        }

        [HttpPatch("{id}/cancela")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult CancelaPedido(Guid id)
        {
            return Ok();
        }

        [HttpPatch("{id}/confirma")]
        public IActionResult ConfirmaPedido(Guid id)
        {
            pedidoService.AtualizaStatusPedidoAsync(new Pedido
            {
                Id = id,
                Status = Atacadista.Dominio.Model.StatusPedido.Solicitado
            });

            return Ok();
        }

        [HttpPatch("{id}/status")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult AtualizaStatus([FromRoute]Guid id, [FromBody]StatusPatch statusPatch)
        {
            pedidoService.AtualizaStatusPedidoAsync(new Pedido
            {
                Id = id,
                Status = (Atacadista.Dominio.Model.StatusPedido)statusPatch.StatusPedido
            });

            return Ok();
        }
    }
}