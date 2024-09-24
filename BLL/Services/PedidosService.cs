using AutoMapper;
using BLL.DTO.Pedidos;
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
    public class PedidosService(IMapper mapper, IUnitOfWork unitOfWork) : AbstractServices(mapper, unitOfWork), IPedidosService
    {
        public async Task<PedidosDTO> CambiarEstado(int idPedido, EEstadoPedido estado)
        {
            var pedido = await _unitOfWork.PedidosRepository.GetById(idPedido);
            _unitOfWork.PedidosRepository.CambiarEstado(pedido, estado); // no se si la falta de asincronismo puede ocasionar un problema
            return _mapper.Map<PedidosDTO>(pedido);
        }

        public async Task<List<PedidosDTO>> ObtenerPedidosFueraDeTiempo()
        {
            var result = await _unitOfWork.PedidosRepository.ObtenerPedidoFueraDeTiempo();
            return _mapper.Map<List<PedidosDTO>>(result);
        }

        public async Task<DateTime> ObtenerTiempoEstimadoPedidoDePreparacion(int idPedido)
        {
            return await _unitOfWork.PedidosRepository.ObtenerTiempoEstimadoPedidoDePreparacion(idPedido);
        }

        public async Task<PedidosDTO> PonerPedidoEnPreparacion(int idPedido, DateTime tiempoEstimado)
        {
            var result = await _unitOfWork.PedidosRepository.PonerPedidoEnPreparacion(idPedido, tiempoEstimado);
            return _mapper.Map<PedidosDTO>(result);
        }

        public async Task<List<PedidosDTO>> ObtenerPedidosPendientes()
        {
            var result = await _unitOfWork.PedidosRepository.ObtenerPedidosPendientes();
            return _mapper.Map<List<PedidosDTO>>(result);
        }

    }
}
