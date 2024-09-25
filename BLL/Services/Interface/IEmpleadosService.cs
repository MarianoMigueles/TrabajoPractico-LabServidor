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
    }
}
