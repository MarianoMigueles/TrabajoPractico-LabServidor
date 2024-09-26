using BLL.DTO.Pedidos;
using BLL.Services.Interface;
using Entities;
using Entities.Enums;
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

        [HttpPatch("CambiarEstado")]
        public async Task<ActionResult<PedidosDTO>> CambiarEstado(int idPedido, EEstadoPedido estado)
        {
            var result = await _pedidoService.CambiarEstado(idPedido, estado);
            return Ok(result);
        }

        [HttpGet("ObtenerPedidosFueraDeTiempo")]
        public async Task<ActionResult<List<PedidosDTO>>> ObtenerPedidosFueraDeTiempo()
        {
            var result = await _pedidoService.ObtenerPedidosFueraDeTiempo();
            return Ok(result);
        }

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
    }
}
