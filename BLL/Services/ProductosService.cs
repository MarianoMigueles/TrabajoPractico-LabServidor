using AutoMapper;
using BLL.DTO.Productos;
using BLL.Services.Interface;
using DAL.UnitOfWork;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductosService(IMapper mapper, IUnitOfWork unitOfWork) : AbstractServices(mapper, unitOfWork), IProductosService
    {
        public async Task<bool> CrearProducto(ProductoDTO producto)
        {
            var nuevoProducto = _mapper.Map<Productos>(producto);
            await _unitOfWork.ProductosRepository.Create(nuevoProducto);
            await _unitOfWork.Save();
            return true;
        }

        public async Task<bool> EliminarProducto(int id)
        {
            var result = await _unitOfWork.ProductosRepository.GetById(id);
            _unitOfWork.ProductosRepository.Delete(result);
            await _unitOfWork.Save();
            return true;
        }

        public async Task<ProductoDTO> MasVendido()
        {
            var result = await _unitOfWork.ProductosRepository.MasVendido();
            return _mapper.Map<ProductoDTO>(result);
        }

        public async Task<ProductoDTO> MenosVendido()
        {
            var result = await _unitOfWork.ProductosRepository.MenosVendido();
            return _mapper.Map<ProductoDTO>(result);
        }

        public async Task<ProductoDTO> ObtenerProductoPorId(int id)
        {
            var result = await _unitOfWork.ProductosRepository.GetById(id);
            return _mapper.Map<ProductoDTO>(result);
        }

        public async Task ReducirStock(int idProducto, int stock)
        {
            var producto = await _unitOfWork.ProductosRepository.GetById(idProducto);
            _unitOfWork.ProductosRepository.ReducirStock(producto, stock);
            await _unitOfWork.Save();
        }

        public async Task RellenarStock(int idProducto, int stock)
        {
            var producto = await _unitOfWork.ProductosRepository.GetById(idProducto);
            _unitOfWork.ProductosRepository.RellenarStock(producto, stock);
            await _unitOfWork.Save();
        }
    }
}
