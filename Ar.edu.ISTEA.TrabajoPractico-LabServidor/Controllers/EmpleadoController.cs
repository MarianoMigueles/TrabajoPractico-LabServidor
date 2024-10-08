﻿using BLL.DTO.Empleados;
using BLL.Services.Interface;
using Entities;
using Entities.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Ar.edu.ISTEA.TrabajoPractico_LabServidor.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class EmpleadoController : Controller
    {
        public IConfiguration _configuration { get; set; }
        private readonly IEmpleadosService _empleadoService;

        public EmpleadoController(IEmpleadosService empleadoService, IConfiguration configuration)
        {
            _empleadoService = empleadoService;
            _configuration = configuration;
        }

        [AllowAnonymous]
        [HttpPost("LogInEmpleado")]
        public async Task<ActionResult<object>> LogInEmpleado(string usuario, string password)
        {
            var userEntity = await _empleadoService.LogInEmpleado(usuario, password);
            if (userEntity != null)
            {
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub,_configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("Usuario", userEntity.Usuario),
                    new Claim("Nombre", userEntity.Nombre),
                    new Claim("Sector", userEntity.Sector.ToString()),
                    new Claim("Rol", userEntity.Rol.ToString())
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    _configuration["Jwt:Issuer"],
                    _configuration["Jwt:Audience"],
                    claims,
                    expires: DateTime.UtcNow.AddHours(5),
                    signingCredentials: signIn);

                return Ok(new JwtSecurityTokenHandler().WriteToken(token));
            }
            else
                return BadRequest();
        }

        [Authorize(policy: "Admin")]
        [HttpPost("CrearEmpleado")]
        public async Task<ActionResult<bool>> CrearEmpleado(string nombre, string usuario, string password, ESectores sector, ERoles rol)
        {
            var result = await _empleadoService.CrearEmpleado(nombre, usuario, password, sector, rol);
            return Ok(result);
        }

        [Authorize(policy: "Admin")]
        [HttpDelete("EliminarEmpleado{id}")]
        public async Task<ActionResult<bool>> EliminarEmpleado(int id)
        {
            var result = await _empleadoService.EliminarEmpleado(id);
            return Ok(result);
        }

        [Authorize(policy: "Admin")]
        [HttpGet("ObtenerEmpleadoPorId{id}")]
        public async Task<ActionResult<EmpleadoDTO>> ObtenerEmpleadoPorId(int id)
        {
            var result = await _empleadoService.ObtenerEmpleadoPorId(id);
            return Ok(result);
        }

        [Authorize(policy: "Admin")]
        [HttpPatch("ActualizarEstadoEmpleado")]
        public async Task<ActionResult<EmpleadoDTO>> ActualizarEstadoEmpleado(int idEmpleado, EEstadoEmpleado estado)
        {
            var result = await _empleadoService.ActualizarEstadoEmpleado(idEmpleado, estado);
            return Ok(result);
        }

        [Authorize(policy: "Admin")]
        [HttpGet("ObtenerHorarioIngreso")]
        public async Task<ActionResult<List<EmpleadoLogInDTO>>> ObtenerHorarioIngreso(int idEmpleado)
        {
            var result = await _empleadoService.ObtenerHorarioIngreso(idEmpleado);
            return Ok(result);
        }

        [Authorize(policy: "Admin")]
        [HttpGet("ObtenerOperacionesEmpleado")]
        public async Task<ActionResult<OperacionesEmpleadoDTO>> ObtenerOperacionesEmpleado(int idEmpleado)
        {
            var result = await _empleadoService.ObtenerOperacionesEmpleado(idEmpleado);
            return Ok(result);
        }

        [Authorize(policy: "Admin")]
        [HttpGet("ObtenerOperacionesPorEmpleadoEnSector")]
        public async Task<ActionResult<List<OperacionesEmpleadoDTO>>> ObtenerOperacionesPorEmpleadoEnSector(int idEmpleado, ESectores sector)
        {
            var result = await _empleadoService.ObtenerOperacionesPorEmpleadoEnSector(idEmpleado, sector);
            return Ok(result);
        }

        [Authorize(policy: "Admin")]
        [HttpGet("ObtenerOperacionesPorSector")]
        public async Task<ActionResult<int>> ObtenerOperacionesPorSector(ESectores sector)
        {
            var result = await _empleadoService.ObtenerOperacionesPorSector(sector);
            return Ok(result);
        }

    }
}
