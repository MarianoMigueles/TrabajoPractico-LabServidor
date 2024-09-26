using AutoMapper;
using BLL.DTO.Empleados;
using BLL.Services.Interface;
using DAL.UnitOfWork;
using Entities;
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
                await _unitOfWork.Save();
                return _mapper.Map<EmpleadoDTO>(result);
            }
            else
            {
                throw new Exception("El estado entregado no coincide con ningu estado permitido.");
            }
        }

        public async Task GenerarOperacion(OperacionesEmpleados operacion)
        {
            await _unitOfWork.EmpleadosRepository.GenerarOperacion(operacion);
        }

        public async Task<List<EmpleadoLogInDTO>> ObtenerHorarioIngreso(int idEmpleado)
        {
            var result = await _unitOfWork.EmpleadosRepository.ObtenerHorarioIngreso(idEmpleado);
            return _mapper.Map<List<EmpleadoLogInDTO>>(result);
        }

        public async Task<OperacionesEmpleadoDTO> ObtenerOperacionesEmpleado(int idEmpleado)
        {
            var result = await _unitOfWork.EmpleadosRepository.ObtenerOperacionesEmpleado(idEmpleado);
            return _mapper.Map<OperacionesEmpleadoDTO>(result);
        }

        public async Task<List<OperacionesEmpleadoDTO>> ObtenerOperacionesPorEmpleadoEnSector(int idEmpleado, ESectores sector)
        {
            var result = await _unitOfWork.EmpleadosRepository.ObtenerOperacionesPorEmpleadoEnSector(idEmpleado, sector);
            return _mapper.Map<List<OperacionesEmpleadoDTO>>(result);
        }

        public async Task<int> ObtenerOperacionesPorSector(ESectores sector)
        {
            return await _unitOfWork.EmpleadosRepository.ObtenerOperacionesPorSector(sector);
        }

    }
}
