using BLL.DTO.Empleados;
using BLL.Services.Interface;
using Entities;
using Entities.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ar.edu.ISTEA.TrabajoPractico_LabServidor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : Controller
    {
        private readonly IEmpleadosService _empleadoService;

        public EmpleadoController(IEmpleadosService empleadoService)
        {
            _empleadoService = empleadoService;
        }
        [HttpPatch("ActualizarEstadoEmpleado")]
        public async Task<ActionResult<EmpleadoDTO>> ActualizarEstadoEmpleado(int idEmpleado, string estado)
        {
            var result = await _empleadoService.ActualizarEstadoEmpleado(idEmpleado, estado);
            return Ok(result);
        }

        [HttpPost("GenerarOperacion")]
        public async Task<ActionResult> GenerarOperacion(OperacionesEmpleados operacion)
        {
            await _empleadoService.GenerarOperacion(operacion);
            return Ok();
        }

        [HttpGet("ObtenerHorarioIngreso")]
        public async Task<ActionResult<List<EmpleadoLogInDTO>>> ObtenerHorarioIngreso(int idEmpleado)
        {
            var result = await _empleadoService.ObtenerHorarioIngreso(idEmpleado);
            return Ok(result);
        }

        [HttpGet("ObtenerOperacionesEmpleado")]
        public async Task<ActionResult<OperacionesEmpleadoDTO>> ObtenerOperacionesEmpleado(int idEmpleado)
        {
            var result = await _empleadoService.ObtenerOperacionesEmpleado(idEmpleado);
            return Ok(result);
        }

        [HttpGet("ObtenerOperacionesPorEmpleadoEnSector")]
        public async Task<ActionResult<List<OperacionesEmpleadoDTO>>> ObtenerOperacionesPorEmpleadoEnSector(int idEmpleado, ESectores sector)
        {
            var result = await _empleadoService.ObtenerOperacionesPorEmpleadoEnSector(idEmpleado, sector);
            return Ok(result);
        }

        [HttpGet("ObtenerOperacionesPorSector")]
        public async Task<ActionResult<int>> ObtenerOperacionesPorSector(ESectores sector)
        {
            var result = await _empleadoService.ObtenerOperacionesPorSector(sector);
            return Ok(result);
        }

    }
}
