﻿using AutoMapper;
using BLL.DTO.Comandas;
using BLL.DTO.Empleados;
using BLL.Services.Interface;
using DAL.UnitOfWork;
using Entities;
using Entities.Enums;
using Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmpleadosService(IMapper mapper, IUnitOfWork unitOfWork) : AbstractServices(mapper, unitOfWork), IEmpleadosService
    {
        public async Task<EmpleadoDTO> ActualizarEstadoEmpleado(int idEmpleado, EEstadoEmpleado estado)
        {
            var result = await _unitOfWork.EmpleadosRepository.ActualizarEstadoEmpleado(idEmpleado, estado);
            await _unitOfWork.Save();
            return _mapper.Map<EmpleadoDTO>(result);

        }

        public async Task<bool> CrearEmpleado(string nombre, string usuario, string password, ESectores sector, ERoles rol)
        {
            var validation = await _unitOfWork.EmpleadosRepository.ObtenerEmpleadoPorNombreUsuario(usuario);

            if(validation == null)
            {
                EmpleadoCreateRequestDTO empleado = new()
                {
                    Nombre = nombre,
                    Usuario = usuario,
                    Password = password,
                    Sector = sector,
                    Rol = rol
                };

                var nuevoEmpleado = _mapper.Map<Empleados>(empleado);
                await _unitOfWork.EmpleadosRepository.Create(nuevoEmpleado);
                await _unitOfWork.Save();
                return true;
            }
            else
            {
                throw new EntityAlreadyExistsException($"El usuario {usuario} ya se encuentra registrado, intente con un usuario diferente.");
            }

            
        }

        public async Task<bool> EliminarEmpleado(int id)
        {
            var result = await _unitOfWork.EmpleadosRepository.GetById(id);
            _unitOfWork.EmpleadosRepository.Delete(result);
            await _unitOfWork.Save();
            return true;
        }

        public async Task GenerarInicioSecion(string usuario)
        {
            var result = await _unitOfWork.EmpleadosRepository.ObtenerEmpleadoPorNombreUsuario(usuario);
            var nuevaSecion = _mapper.Map<LogInEmpleado>(result);
            await _unitOfWork.EmpleadosRepository.GenerarInicioSecion(nuevaSecion);
            await _unitOfWork.Save();
        }

        public async Task GenerarOperacion(string usuario, string sector, string descripcion)
        {
            var empleado = await _unitOfWork.EmpleadosRepository.ObtenerEmpleadoPorNombreUsuario(usuario);
            var nuevaOperacion = _mapper.Map<OperacionesEmpleados>(empleado);

            nuevaOperacion.Sector = Enum.Parse<ESectores>(sector);
            nuevaOperacion.Descripcion = descripcion;

            await _unitOfWork.EmpleadosRepository.GenerarOperacion(nuevaOperacion);
            await _unitOfWork.Save();
        }

        public async Task<EmpleadoDTO> LogInEmpleado(string userName, string password)
        {
            var result = await _unitOfWork.EmpleadosRepository.LogInEmpleado(userName, password);
            return _mapper.Map<EmpleadoDTO>(result);
        }

        public async Task<EmpleadoDTO> ObtenerEmpleadoPorId(int id)
        {
            var result = await _unitOfWork.EmpleadosRepository.GetById(id);
            return _mapper.Map<EmpleadoDTO>(result);
        }

        public async Task<List<EmpleadoLogInDTO>> ObtenerHorarioIngreso(int idEmpleado)
        {
            var result = await _unitOfWork.EmpleadosRepository.ObtenerHorarioIngreso(idEmpleado);
            return _mapper.Map<List<EmpleadoLogInDTO>>(result);
        }

        public async Task<List<OperacionesEmpleadoDTO>> ObtenerOperacionesEmpleado(int idEmpleado)
        {
            var result = await _unitOfWork.EmpleadosRepository.ObtenerOperacionesEmpleado(idEmpleado);
            return _mapper.Map<List<OperacionesEmpleadoDTO>>(result);
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
