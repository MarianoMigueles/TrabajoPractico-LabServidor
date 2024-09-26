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

        [HttpPatch("CambiarEstado")]
        public async Task<ActionResult<Mesas>> CambiarEstado(int idMesa, EEstadoMesa estadoMesa)
        {
            var result = await _mesaService.CambiarEstado(idMesa, estadoMesa);
            return Ok(result);
        }

        [HttpPatch("CerrarMesa")]
        public async Task<ActionResult<Mesas>> CerrarMesa(int idMesa)
        {
            var result = await _mesaService.CerrarMesa(idMesa);
            return Ok(result);
        }
    }
}
