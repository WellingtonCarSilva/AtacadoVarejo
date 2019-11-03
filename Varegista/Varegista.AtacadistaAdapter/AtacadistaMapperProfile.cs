using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Varegista.AtacadistaAdapter.Client;
using Varegista.Dominio.Models;

namespace Varegista.AtacadistaAdapter
{
    public class AtacadistaMapperProfile : Profile
    {
        public AtacadistaMapperProfile()
        {
            CreateMap<Orcamento, PedidoPost>();
            CreateMap<Pedido, ItemPedidoPost>();
        }
    } 
}
