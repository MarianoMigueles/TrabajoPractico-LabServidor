using AutoMapper;
using BLL.DTO.Pedidos;
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
    public class PedidosService(IMapper mapper, IUnitOfWork unitOfWork) : AbstractServices(mapper, unitOfWork), IPedidosService
    {
        public async Task<PedidosDTO> CambiarEstado(int idPedido, EEstadoPedido estado)
        {
            var pedido = await _unitOfWork.PedidosRepository.GetById(idPedido);
            _unitOfWork.PedidosRepository.CambiarEstado(pedido, estado); // no se si la falta de asincronismo puede ocacionar un problema
            return _mapper.Map<PedidosDTO>(pedido);
        }

        public Task<List<PedidosDTO>> FueraDeTiempo()
        {
            throw new NotImplementedException();
        }

        public Task<PedidosDTO> ObtenerPedidoEnPreparacion(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PedidosDTO>> ObtenerPedidosPendientes()
        {
            var result = await _unitOfWork.PedidosRepository.ObtenerPedidosPendientes();
            return _mapper.Map<List<PedidosDTO>>(result);
        }
    }
}
