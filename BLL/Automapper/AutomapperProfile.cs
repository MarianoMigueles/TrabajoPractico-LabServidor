
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
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Comandas, ComandaDTO>().ReverseMap();
            CreateMap<Mesas, MesaDTO>().ReverseMap();
            CreateMap<Pedidos, PedidosDTO>().ReverseMap();
            CreateMap<Productos, ProductoDTO>().ReverseMap();
            CreateMap<Empleados, LogInEmpleado>()
                .ForMember(dest => dest.IdEmpleado, opt => opt.MapFrom(src => src.IdEmpleados)) 
                .ForMember(dest => dest.FechaIngreso, opt => opt.MapFrom(src => DateTime.Now));

            CreateMap<Empleados, OperacionesEmpleados>()
                .ForMember(dest => dest.IdEmpleado, opt => opt.MapFrom(src => src.IdEmpleados))
                .ForMember(dest => dest.FechaOperacion, opt => opt.MapFrom(src => DateTime.Now));


            CreateMap<Empleados, EmpleadoDTO>().ReverseMap();
            CreateMap<LogInEmpleado, EmpleadoLogInDTO>()
                .ForMember(dest => dest.Usuario, opt => opt.MapFrom(src => src.Empleado.Usuario))
                .ForMember(dest => dest.Rol, opt => opt.MapFrom(src => src.Empleado.Rol))
                .ForMember(dest => dest.Sector, opt => opt.MapFrom(src => src.Empleado.Sector))
                .ForMember(dest => dest.FechaIngreso, opt => opt.MapFrom(src => src.FechaIngreso.ToString("dd-MM-yyyy HH:mm")))
                .ReverseMap();

            CreateMap<OperacionesEmpleados, OperacionesEmpleadoDTO>()
                .ForMember(dest => dest.Usuario, opt => opt.MapFrom(src => src.Empleado.Usuario))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Empleado.Nombre))
                .ForMember(dest => dest.FechaOperacion, opt => opt.MapFrom(src => src.FechaOperacion.ToString("dd-MM-yyyy HH:mm")))
                .ReverseMap();
        }
    }
}
