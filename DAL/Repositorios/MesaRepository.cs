using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using DAL.Repositorios.Interfaces;
using Entities;
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
    }
}
