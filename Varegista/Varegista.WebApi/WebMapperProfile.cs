using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Varegista.Dominio.Models;
using Varegista.WebApi.Dto;

namespace Varegista.WebApi
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
