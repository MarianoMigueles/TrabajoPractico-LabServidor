using Entities.Enums;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO.Empleados;
using BLL.DTO.Comandas;

namespace BLL.Services.Interface
{
    public interface IEmpleadosService
    {
        Task<EmpleadoDTO> ActualizarEstadoEmpleado(int idEmpleado, string estado);
        Task<List<EmpleadoLogInDTO>> ObtenerHorarioIngreso(int idEmpleado);
        Task<List<OperacionesEmpleadoDTO>> ObtenerOperacionesEmpleado(int idEmpleado);
        Task<int> ObtenerOperacionesPorSector(ESectores sector);
        Task<List<OperacionesEmpleadoDTO>> ObtenerOperacionesPorEmpleadoEnSector(int idEmpleado, ESectores sector);
        Task GenerarOperacion(string usuario, string sector, string descripcion);
        Task GenerarInicioSecion(string usuario);
        Task<EmpleadoDTO> LogInEmpleado(string userName, string password);
        Task<bool> CrearEmpleado(EmpleadoCreateRequestDTO empleado);
        Task<EmpleadoDTO> ObtenerEmpleadoPorId(int id);
        Task<bool> EliminarEmpleado(int id);
    }
}
