﻿using BLL.DTO.Productos;
using Entities;
using Entities.Enums;
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
        Task<bool> CrearProducto(string Descripcion, int Stock, int Precio, ESectores sector);
        Task<bool> EliminarProducto(int id);
        Task<ProductoDTO> ObtenerProductoPorId(int id);
        Task ReducirStock(int idProducto, int stock);
        Task RellenarStock(int idProducto, int stock);

    }
}
