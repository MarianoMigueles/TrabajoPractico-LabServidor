using BLL.DTO.Comandas;
using BLL.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ar.edu.ISTEA.TrabajoPractico_LabServidor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComandaController : Controller
    {
        private readonly IComandasService _comandasService;

        public ComandaController(IComandasService comandasService)
        {
            _comandasService = comandasService;
        }

        [HttpPost("CrearComanda")]
        public async Task<ActionResult<bool>> CrearComanda(ComandaDTO comanda)
        {
            var result = await _comandasService.CrearComanda(comanda);
            return Ok(result);
        }

        [HttpDelete("EliminarComanda{id}")]
        public async Task<ActionResult<bool>> EliminarComanda(int id)
        {
            var result = await _comandasService.EliminarComanda(id);
            return Ok(result);
        }

        [HttpGet("ObtenerComandaPorId{id}")]
        public async Task<ActionResult<ComandaDTO>> ObtenerComandaPorId(int id)
        {
            var result = await _comandasService.ObtenerComandaPorId(id);
            return Ok(result);
        }
    }
}
