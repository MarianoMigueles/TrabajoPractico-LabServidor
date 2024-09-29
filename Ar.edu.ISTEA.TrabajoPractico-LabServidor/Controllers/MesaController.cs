using BLL.DTO.Mesas;
using BLL.Services.Interface;
using Entities;
using Entities.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ar.edu.ISTEA.TrabajoPractico_LabServidor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesaController : Controller
    {
        private readonly IMesaService _mesaService;

        public MesaController(IMesaService mesaService)
        {
            _mesaService = mesaService;
        }

        [HttpPost("CrearMesa")]
        public async Task<ActionResult<bool>> CrearMesa(MesaDTO mesa)
        {
            var result = await _mesaService.CrearMesa(mesa);
            return Ok(result);
        }

        [HttpDelete("EliminarMesa")]
        public async Task<ActionResult<bool>> EliminarMesa(int id)
        {
            var result = await _mesaService.EliminarMesa(id);
            return Ok(result);
        }

        [HttpGet("ObtenerMesaPorId")]
        public async Task<ActionResult<MesaDTO>> ObtenerMesaPorId(int id)
        {
            var result = await _mesaService.ObtenerMesaPorId(id);
            return Ok(result);
        }

        [HttpPatch("CambiarEstado")]
        public async Task<ActionResult<MesaDTO>> CambiarEstado(int idMesa, EEstadoMesa estadoMesa)
        {
            var result = await _mesaService.CambiarEstado(idMesa, estadoMesa);
            return Ok(result);
        }

        [HttpPatch("CerrarMesa")]
        public async Task<ActionResult<MesaDTO>> CerrarMesa(int idMesa)
        {
            var result = await _mesaService.CerrarMesa(idMesa);
            return Ok(result);
        }
    }
}
