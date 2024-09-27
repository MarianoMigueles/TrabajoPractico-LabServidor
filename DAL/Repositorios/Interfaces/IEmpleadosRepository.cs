using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios.Interfaces
{
    public interface IEmpleadosRepository : IRepository<Empleados>
    {
        Task<Empleados> ActualizarEstadoEmpleado(int idEmpleado, EEstadoEmpleado estado);
        Task<List<LogInEmpleado>> ObtenerHorarioIngreso(int idEmpleado);
        Task<OperacionesEmpleados> ObtenerOperacionesEmpleado(int idEmpleado);
        Task<int> ObtenerOperacionesPorSector(ESectores sector);
        Task<List<OperacionesEmpleados>> ObtenerOperacionesPorEmpleadoEnSector(int idEmplead, ESectores sector);
        Task GenerarOperacion(OperacionesEmpleados operacion);
        Task<Empleados> LogInEmpleado(string userName, string password);
    }
}
