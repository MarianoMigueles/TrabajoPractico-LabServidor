
using AutoMapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO.Comandas;
using BLL.DTO.Empleados;
using BLL.DTO.Mesas;
using BLL.DTO.Pedidos;
using BLL.DTO.Productos;

namespace BLL.Automapper
{
    internal class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Comandas, ComandaDTO>().ReverseMap();
            CreateMap<Empleados, EmpleadoDTO>().ReverseMap();
            CreateMap<Mesas, MesaDTO>().ReverseMap();
            CreateMap<Pedidos, PedidosDTO>().ReverseMap();
            CreateMap<Productos, ProductoDTO>().ReverseMap();
        }
    }
}
