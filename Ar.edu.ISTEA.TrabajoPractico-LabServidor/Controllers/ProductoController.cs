﻿using BLL.DTO.Productos;
using BLL.Services.Interface;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ar.edu.ISTEA.TrabajoPractico_LabServidor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductoController : Controller
    {
        private readonly IProductosService _productosService;

        public ProductoController(IProductosService productosService)
        {
            _productosService = productosService;
        }

        [HttpPost("CrearProducto")]
        public async Task<ActionResult<bool>> CrearProducto(ProductoDTO producto)
        {
            var result = await _productosService.CrearProducto(producto);
            return Ok(result);
        }

        [HttpDelete("EliminarProducto{id}")]
        public async Task<ActionResult<bool>> EliminarProducto(int id)
        {
            var result = await _productosService.EliminarProducto(id);
            return Ok(result);
        }

        [HttpGet("ObtenerProductoPorId{id}")]
        public async Task<ActionResult<ProductoDTO>> ObtenerProductoPorId(int id)
        {
            var result = await _productosService.ObtenerProductoPorId(id);
            return Ok(result);
        }

        [HttpPatch("ReducirStock{idProducto}/{stock}")]
        public async Task<ActionResult> ReducirStock(int idProducto, int stock)
        {
            await _productosService.ReducirStock(idProducto, stock);
            return Ok();
        }

        [HttpPatch("RellenarStock{idProducto}/{stock}")]
        public async Task<ActionResult> RellenarStock(int idProducto, int stock)
        {
            await _productosService.RellenarStock(idProducto, stock);
            return Ok();
        }


        [HttpGet("MasVendido")]
        public async Task<ActionResult<ProductoDTO>> MasVendido()
        {
            var result = await _productosService.MasVendido();
            return Ok(result);
        }

        [HttpGet("MenosVendido")]
        public async Task<ActionResult<ProductoDTO>> MenosVendido()
        {
            var result = await _productosService.MenosVendido();
            return Ok(result);
        }
    }
}
