using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using DAL.Repositorios.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    public class MesaRepository : Repository<Mesas>, IMesaRepository
    {
        public MesaRepository(DataContext context) : base(context)
        {
        }

        public async Task<bool> CambiarEstado(int idMesa, EstadoMesa estadoMesa)
        {
            Mesas mesa = await _context.Mesas.Where(x => x.IdMesa == idMesa).FirstOrDefaultAsync() ?? throw new Exception("La mesa no fue encontrada");
            mesa.EstadoMesa = estadoMesa;
            return true;
        }

        public async Task<bool> CerrarMesa(int idMesa)
        {
            var mesa = await _context.Mesas.Where(x => x.IdMesa == idMesa).FirstOrDefaultAsync() ?? throw new Exception("La mesa no fue encontrada");
            mesa.EstadoMesa = EstadoMesa.Cerrada;
            return true;
        }

    }
}
