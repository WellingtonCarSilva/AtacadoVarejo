using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Varegista.AtacadistaAdapter;
using Varegista.Dominio.Models;
using Varegista.Service.Interfaces;
using Xunit;

namespace Varegista.Service.Testes
{
    public class PedidoServiceTest
    {
        private readonly IPedidoService pedidoService;
        private readonly Mock<IAtacadistaAdapter> atacadistaAdapter;

        public PedidoServiceTest()
        {
            this.atacadistaAdapter = new Mock<IAtacadistaAdapter>();
            this.pedidoService = new PedidoService(atacadistaAdapter.Object);
        }

        [Fact]
        public async Task SolicitaOrcamentoAsync()
        {
            var objetoEsperado = new Orcamento
            {
                Pedidos = new List<Pedido>
                {
                    new Pedido
                    {
                        CodigoProduto = 1,
                        Observacao = "Teste",
                        Quantidade = 2
                    }
                }
            };

            atacadistaAdapter.Setup(a => a.SolicitaOrcamentoAsync(It.IsAny<Orcamento>()))
                .Returns(Task.CompletedTask);

            var objetoRetornado = await pedidoService.SolicitaOrcamentoAsync(objetoEsperado);

            Assert.Collection(objetoEsperado.Pedidos, p =>
            {
                Assert.Equal(p.Observacao, objetoRetornado.Pedidos.FirstOrDefault().Observacao);
                Assert.Equal(p.Quantidade, objetoRetornado.Pedidos.FirstOrDefault().Quantidade);
                Assert.Equal(p.CodigoProduto, objetoRetornado.Pedidos.FirstOrDefault().CodigoProduto);
            });
        }

        [Fact]
        public async Task ConfirmaOrcamentoAsync()
        {
            var idEsperado = Guid.NewGuid(); 

            atacadistaAdapter.Setup(a => a.ConfirmaPedidoAsync(It.IsAny<Guid>()))
                .Returns(Task.CompletedTask);

            var idRetornado = await pedidoService.ConfirmaPedidoAsync(idEsperado);

            Assert.Equal(idEsperado, idRetornado);
        }

        [Fact]
        public async Task CancelaOrcamentoAsync()
        {
            var idEsperado = Guid.NewGuid();

            atacadistaAdapter.Setup(a => a.CancelaPedidoAsync(It.IsAny<Guid>()))
                .Returns(Task.CompletedTask);

            var idRetornado = await pedidoService.CancelaPedidoAsync(idEsperado);

            Assert.Equal(idEsperado, idRetornado);
        }
    }
}
