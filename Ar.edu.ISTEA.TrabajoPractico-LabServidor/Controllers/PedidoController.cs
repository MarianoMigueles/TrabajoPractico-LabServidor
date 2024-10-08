﻿using BLL.DTO.Empleados;
using BLL.DTO.Pedidos;
using BLL.Services.Interface;
using Entities;
using Entities.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ar.edu.ISTEA.TrabajoPractico_LabServidor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : Controller
    {
        private readonly IPedidosService _pedidoService;

        public PedidoController(IPedidosService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [Authorize(policy: "Mozos")]
        [HttpPost("CrearPedido")]
        public async Task<ActionResult<bool>> CrearPedido(int idComanda, int idProducto, int cantidad)
        {
            var result = await _pedidoService.CrearPedido(idComanda, idProducto, cantidad);
            return Ok(result);
        }

        [HttpGet("ConsultarEstadoPedido")]
        public async Task<ActionResult<PedidosDTO>> ConsultarEstadoPedido(int id)
        {
            var result = await _pedidoService.ConsultarEstadoPedido(id);
            return Ok(result);
        }

        [HttpPatch("CambiarEstado")]
        public async Task<ActionResult<PedidosDTO>> CambiarEstado(int idPedido, EEstadoPedido estado)
        {
            var result = await _pedidoService.CambiarEstado(idPedido, estado);
            return Ok(result);
        }

        [Authorize(policy: "Admin")]
        [HttpGet("ObtenerPedidosFueraDeTiempo")]
        public async Task<ActionResult<List<PedidosDTO>>> ObtenerPedidosFueraDeTiempo()
        {
            var result = await _pedidoService.ObtenerPedidosFueraDeTiempo();
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("ObtenerTiempoEstimadoPedidoDePreparacion")]
        public async Task<ActionResult<DateTime>> ObtenerTiempoEstimadoPedidoDePreparacion(int idPedido)
        {
            var result = await _pedidoService.ObtenerTiempoEstimadoPedidoDePreparacion(idPedido);
            return Ok(result);
        }

        [HttpPatch("PonerPedidoEnPreparacion")]
        public async Task<ActionResult<PedidosDTO>> PonerPedidoEnPreparacion(int idPedido, DateTime tiempoEstimado)
        {
            var result = await _pedidoService.PonerPedidoEnPreparacion(idPedido, tiempoEstimado);
            return Ok(result);
        }

        [HttpGet("ObtenerPedidosPendientes")]
        public async Task<ActionResult<List<PedidosDTO>>> ObtenerPedidosPendientes()
        {
            var result = await _pedidoService.ObtenerPedidosPendientes();
            return Ok(result);
        }

        [HttpGet("ObtenerPedidosPendientesPorSector")]
        public async Task<ActionResult<List<PedidosDTO>>> ObtenerPedidosPendientesPorSector(ESectores sector)
        {
            var result = await _pedidoService.ObtenerPedidosPendientesPorSector(sector);
            return Ok(result);
        }

        [Authorize(policy: "Mozos")]
        [HttpGet("ObtenerPedidosListosParaServir")]
        public async Task<ActionResult<List<PedidosDTO>>> ObtenerPedidosListosParaServir()
        {
            var result = await _pedidoService.ObtenerPedidosListosParaServir();
            return Ok(result);
        }

        [HttpGet("ObtenerPedidos")]
        public async Task<ActionResult<List<PedidosDTO>>> ObtenerPedidos()
        {
            var result = await _pedidoService.ObtenerPedidos();
            return Ok(result);
        }
    }
}
