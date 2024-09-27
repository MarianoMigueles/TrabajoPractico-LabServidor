using Entities.Enums;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO.Empleados;

namespace BLL.Services.Interface
{
    public interface IEmpleadosService
    {
        Task<EmpleadoDTO> ActualizarEstadoEmpleado(int idEmpleado, string estado);
        Task<List<EmpleadoLogInDTO>> ObtenerHorarioIngreso(int idEmpleado);
        Task<OperacionesEmpleadoDTO> ObtenerOperacionesEmpleado(int idEmpleado);
        Task<int> ObtenerOperacionesPorSector(ESectores sector);
        Task<List<OperacionesEmpleadoDTO>> ObtenerOperacionesPorEmpleadoEnSector(int idEmpleado, ESectores sector);
        Task GenerarOperacion(OperacionesEmpleados operacion);

        Task<EmpleadoDTO> LogInEmpleado(string userName, string password);
    }
}
