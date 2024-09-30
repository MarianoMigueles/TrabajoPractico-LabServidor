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
            _unitOfWork.PedidosRepository.CambiarEstado(pedido, estado);
            await _unitOfWork.Save();
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
            await _unitOfWork.Save();
            return _mapper.Map<PedidosDTO>(result);
        }

        public async Task<List<PedidosDTO>> ObtenerPedidosPendientes()
        {
            var result = await _unitOfWork.PedidosRepository.ObtenerPedidosPendientes();
            return _mapper.Map<List<PedidosDTO>>(result);
        }

        public async Task<bool> CrearPedido(int idComanda, int idProducto, int cantidad)
        {
            PedidoCreateRequestDTO pedido = new()
            {
                IdComanda = idComanda,
                IdProducto = idProducto,
                Cantidad = cantidad,
            };

            var nuevoPedido = _mapper.Map<Pedidos>(pedido);
            await _unitOfWork.PedidosRepository.Create(nuevoPedido);
            await _unitOfWork.Save();
            return true;
        }

        public async Task<PedidosDTO> ConsultarEstadoPedido(int id)
        {
            var result = await _unitOfWork.PedidosRepository.GetById(id);
            return _mapper.Map<PedidosDTO>(result);
        }

        public async Task<List<PedidosDTO>> ObtenerPedidosPendientesPorSector(ESectores sector)
        {
            var result = await _unitOfWork.PedidosRepository.ObtenerPedidosPendientesPorSector(sector);
            return _mapper.Map<List<PedidosDTO>>(result);
        }

        public async Task<List<PedidosDTO>> ObtenerPedidosListosParaServir()
        {
            var result = await _unitOfWork.PedidosRepository.ObtenerPedidosListosParaServir();
            return _mapper.Map<List<PedidosDTO>>(result);
        }

        public async Task<List<PedidosDTO>> ObtenerPedidos()
        {
            var result = await _unitOfWork.PedidosRepository.GetAll();
            return _mapper.Map<List<PedidosDTO>>(result);
        }
    }
}
