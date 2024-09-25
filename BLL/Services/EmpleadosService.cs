using AutoMapper;
using BLL.DTO.Empleados;
using BLL.Services.Interface;
using DAL.UnitOfWork;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmpleadosService(IMapper mapper, IUnitOfWork unitOfWork) : AbstractServices(mapper, unitOfWork), IEmpleadosService
    {
        public async Task<EmpleadoDTO> ActualizarEstadoEmpleado(int idEmpleado, string estado)
        {
            if (Enum.TryParse<EEstadoEmpleado>(estado, out var estadoEmpleado))
            {
                var result = await _unitOfWork.EmpleadosRepository.ActualizarEstadoEmpleado(idEmpleado, estadoEmpleado);
                return _mapper.Map<EmpleadoDTO>(result);
            }
            else
            {
                throw new Exception("El estado entregado no coincide con ningu estado permitido.");
            }
        }
    }
}
