using BLL.DTO.Productos;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interface
{
    public interface IProductosService 
    {
        Task<ProductoDTO> MasVendido();
        Task<ProductoDTO> MenosVendido();

        Task<bool> CrearProducto(ProductoDTO producto);
        Task<bool> EliminarProducto(int id);
        Task<ProductoDTO> ObtenerProductoPorId(int id);
    }
}
