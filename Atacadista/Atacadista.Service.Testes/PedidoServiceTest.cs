using Atacadista.Dominio.Model;
using Atacadista.Service.Interfaces;
using Atacadista.VaregistaAdapter.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Atacadista.Service.Testes
{
    public class PedidoServiceTest
    {
        private readonly IPedidoService pedidoService;
        private readonly Mock<IVaregistaAdapter> varegistaAdapter;
        public PedidoServiceTest()
        {
            varegistaAdapter = new Mock<IVaregistaAdapter>();
            pedidoService = new PedidoService(varegistaAdapter.Object);
        }

        [Fact]
        public async Task AtualizaStatusPedidoAsync()
        {
            var objetoEsperado = new Pedido
            {
                CodigoProduto = 5,
                Observacao = "Teste",
                Quantidade = 3
            };
            var objetoRetornado = await pedidoService.AtualizaStatusPedidoAsync(objetoEsperado);

            Assert.Equal(objetoEsperado.Observacao, objetoRetornado.Observacao);
            Assert.Equal(objetoEsperado.Quantidade, objetoRetornado.Quantidade);
            Assert.Equal(objetoEsperado.CodigoProduto, objetoRetornado.CodigoProduto);
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
                        CodigoProduto = 4,
                        Quantidade = 2,
                        Observacao = "Teste"
                    }
                }
            };
            var objetoRetornado = await pedidoService.SolicitaOrcamentoAsync(objetoEsperado);

            Assert.Collection(objetoEsperado.Pedidos, p =>
            {
                Assert.Equal(p.Observacao, objetoRetornado.Pedidos.FirstOrDefault().Observacao);
                Assert.Equal(p.Quantidade, objetoRetornado.Pedidos.FirstOrDefault().Quantidade);
                Assert.Equal(p.CodigoProduto, objetoRetornado.Pedidos.FirstOrDefault().CodigoProduto);
            });
        }
    }
}
