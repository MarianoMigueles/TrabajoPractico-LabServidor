using BLL.Services.Interface;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ar.edu.ISTEA.TrabajoPractico_LabServidor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        private readonly IProductosService _productosService;

        public ProductoController(IProductosService productosService)
        {
            _productosService = productosService;
        }

        [HttpGet("MasVendido")]
        public async Task<ActionResult<Productos>> MasVendido()
        {
            var result = await _productosService.MasVendido();
            return Ok(result);
        }

        [HttpGet("MenosVendido")]
        public async Task<ActionResult<Productos>> MenosVendido()
        {
            var result = await _productosService.MenosVendido();
            return Ok(result);
        }
    }
}
