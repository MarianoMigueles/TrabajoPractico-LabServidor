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
    }
}
