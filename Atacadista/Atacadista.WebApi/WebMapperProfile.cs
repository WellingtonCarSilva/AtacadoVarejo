using Atacadista.Dominio.Model;
using Atacadista.WebApi.Dto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atacadista.WebApi
{
    public class WebMapperProfile : Profile
    {
        public WebMapperProfile()
        {
            CreateMap<PedidoPost, Orcamento>();
            CreateMap<ItemPedidoPost, Pedido>();
        }
    }
}
