using AutoMapper;
using BLL.DTO.Mesas;
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
    public class MesaService(IMapper mapper, IUnitOfWork unitOfWork) : AbstractServices(mapper, unitOfWork), IMesaService
    {
        public async Task<MesaDTO> CambiarEstado(int idMesa, EEstadoMesa estadoMesa)
        {
            var result = await _unitOfWork.MesaRepository.CambiarEstado(idMesa, estadoMesa);
            await _unitOfWork.Save();
            return _mapper.Map<MesaDTO>(result);
        }

        public async Task<MesaDTO> CerrarMesa(int idMesa)
        {
            var result = await _unitOfWork.MesaRepository.CerrarMesa(idMesa);
            await _unitOfWork.Save();
            return _mapper.Map<MesaDTO>(result);
        }

        public async Task<bool> CrearMesa(string nombreMesa)
        {
            var validation = await _unitOfWork.MesaRepository.ObtenerMesaPorNombre(nombreMesa);
            if(validation == null)
            {
                MesaDTO mesa = new()
                {
                    Nombre = nombreMesa,
                    EstadoMesa = EEstadoMesa.MesaVacia
                };

                var nuevaMesa = _mapper.Map<Mesas>(mesa);
                await _unitOfWork.MesaRepository.Create(nuevaMesa);
                await _unitOfWork.Save();
                return true;
            }
            else
            {
                throw new EntityAlreadyExistsException($"No se pudo crear la mesa '{nombreMesa}' porque ya existe una mesa con ese mismo nombre.");
            }
            
        }

        public async Task<bool> EliminarMesa(int id)
        {
            var result = await _unitOfWork.MesaRepository.GetById(id);
            _unitOfWork.MesaRepository.Delete(result);
            await _unitOfWork.Save();
            return true;
        }

        public async Task<MesaDTO> ObtenerMesaPorId(int id)
        {
            var result = await _unitOfWork.MesaRepository.GetById(id);
            return _mapper.Map<MesaDTO>(result);
        }
    }
}
