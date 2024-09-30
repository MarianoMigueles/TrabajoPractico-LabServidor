using BLL.DTO.Mesas;
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
    public class MesaController : Controller
    {
        private readonly IMesaService _mesaService;

        public MesaController(IMesaService mesaService)
        {
            _mesaService = mesaService;
        }

        [Authorize(policy: "Admin")]
        [HttpPost("CrearMesa")]
        public async Task<ActionResult<bool>> CrearMesa(string nombreMesa)
        {
            var result = await _mesaService.CrearMesa(nombreMesa);
            return Ok(result);
        }

        [Authorize(policy: "Admin")]
        [HttpDelete("EliminarMesa")]
        public async Task<ActionResult<bool>> EliminarMesa(int id)
        {
            var result = await _mesaService.EliminarMesa(id);
            return Ok(result);
        }

        [Authorize(policy: "Admin")]
        [HttpGet("ObtenerMesaPorId")]
        public async Task<ActionResult<MesaDTO>> ObtenerMesaPorId(int id)
        {
            var result = await _mesaService.ObtenerMesaPorId(id);
            return Ok(result);
        }

        [Authorize(policy: "Mozos")]
        [HttpPatch("CambiarEstado")]
        public async Task<ActionResult<MesaDTO>> CambiarEstado(int idMesa, EEstadoMesa estadoMesa)
        {
            var result = await _mesaService.CambiarEstado(idMesa, estadoMesa);
            return Ok(result);
        }

        [Authorize(policy: "Socio")]
        [HttpPatch("CerrarMesa")]
        public async Task<ActionResult<MesaDTO>> CerrarMesa(int idMesa)
        {
            var result = await _mesaService.CerrarMesa(idMesa);
            return Ok(result);
        }

        //[Authorize(policy: "Socio")]
        [HttpPatch("ObtenerMesas")]
        public async Task<ActionResult<List<MesaDTO>>> ObtenerMesas()
        {
            var result = await _mesaService.ObtenerMesas();
            return Ok(result);
        }
    }
}
