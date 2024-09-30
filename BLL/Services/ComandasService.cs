using AutoMapper;
using BLL.DTO.Comandas;
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
    public class ComandasService(IMapper mapper, IUnitOfWork unitOfWork) : AbstractServices(mapper, unitOfWork), IComandasService
    {
        public async Task<decimal?> CobrarComanda(int idComanda)
        {
            var comanda = await _unitOfWork.ComandasRepository.ObtenerComandaConPedidos(idComanda);

            if (comanda == null || !comanda.Pedidos.Any())
            {
                throw new EntityNotFoundException("No se pudo proceder. La comanda no fue encontrada o se encuentra sin pedidos");
            }

            decimal totalCobro = comanda.TotalComanda;

            foreach (var pedido in comanda.Pedidos)
            {
                pedido.CambiarEstado(EEstadoPedido.Pagado);
            }

            await _unitOfWork.Save();
            return totalCobro;
        }

        public async Task<bool> CrearComanda(int idMesa, string nombreCliente)
        {
            ComandaDTO comanda = new()
            {
                IdMesa = idMesa,
                NombreCliente = nombreCliente
            };

            var nuevaComanda = _mapper.Map<Comandas>(comanda);
            await _unitOfWork.ComandasRepository.Create(nuevaComanda);
            await _unitOfWork.Save();
            return true;
        }

        public async Task<bool> EliminarComanda(int id)
        {
            var comanda = await _unitOfWork.ComandasRepository.GetById(id);
            _unitOfWork.ComandasRepository.Delete(comanda);
            await _unitOfWork.Save();
            return true;
        }

        public async Task<ComandaDTO> ObtenerComandaPorId(int id)
        {
            var result = await _unitOfWork.ComandasRepository.GetById(id);
            return _mapper.Map<ComandaDTO>(result);
        }
    }
}
