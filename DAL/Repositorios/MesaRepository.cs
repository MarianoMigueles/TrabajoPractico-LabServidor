<<<<<<< Updated upstream
﻿using System;
=======
﻿using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using DAL.Repositorios.Interfaces;
using Entities;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
>>>>>>> Stashed changes
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    internal class MesaRepository
    {
<<<<<<< Updated upstream
=======
        public MesaRepository(DataContext context) : base(context)
        {
        }

        public async Task<Mesas> CambiarEstado(int idMesa, EEstadoMesa estadoMesa)
        {
            Mesas mesa = await _context.Mesas.Where(x => x.IdMesa == idMesa).FirstOrDefaultAsync() ?? throw new Exception("La mesa no fue encontrada");
            mesa.EstadoMesa = estadoMesa;
            return mesa;
        }

        public async Task<Mesas> CerrarMesa(int idMesa)
        {
            var mesa = await _context.Mesas.Where(x => x.IdMesa == idMesa).FirstOrDefaultAsync() ?? throw new Exception("La mesa no fue encontrada");
            mesa.EstadoMesa = EEstadoMesa.Cerrada;
            return mesa;
        }

>>>>>>> Stashed changes
    }
}
