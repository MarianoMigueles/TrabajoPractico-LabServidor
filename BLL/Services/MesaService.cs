using AutoMapper;
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
    }
}
