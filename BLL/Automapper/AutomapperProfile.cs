
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
            CreateMap<Mesas, MesaDTO>().ReverseMap();
            CreateMap<Pedidos, PedidosDTO>().ReverseMap();
            CreateMap<Productos, ProductoDTO>().ReverseMap();

            CreateMap<Empleados, EmpleadoDTO>().ReverseMap();
            CreateMap<LogInEmpleado, EmpleadoLogInDTO>()
                .ForMember(dest => dest.Usuario, opt => opt.MapFrom(src => src.Empleado.Usuario))
                .ForMember(dest => dest.Rol, opt => opt.MapFrom(src => src.Empleado.Rol))
                .ForMember(dest => dest.Sector, opt => opt.MapFrom(src => src.Empleado.Sector))
                .ReverseMap();

            CreateMap<OperacionesEmpleados, OperacionesEmpleadoDTO>()
                .ForMember(dest => dest.Usuario, opt => opt.MapFrom(src => src.Empleado.Usuario))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Empleado.Nombre))
                .ReverseMap();
        }
    }
}
