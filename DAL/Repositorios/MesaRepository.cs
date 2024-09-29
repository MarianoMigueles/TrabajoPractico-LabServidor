using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using DAL.Repositorios.Interfaces;
using Entities;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    public class MesaRepository(DataContext context) : Repository<Mesas>(context), IMesaRepository
    {
        public async Task<Mesas> CambiarEstado(int idMesa, EEstadoMesa estadoMesa)
        {
            Mesas mesa = await this.GetById(idMesa) ?? throw new Exception("La mesa no fue encontrada");
            mesa.CambiarEstado(estadoMesa);
            return mesa;
        }

        public async Task<Mesas> CerrarMesa(int idMesa)
        {
            var mesa = await this.GetById(idMesa) ?? throw new Exception("La mesa no fue encontrada");
            mesa.CerrarMesa();
            return mesa;
        }

    }
}
