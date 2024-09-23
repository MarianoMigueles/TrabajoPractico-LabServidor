using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;

namespace Entities
{
    public class Productos
    {
        [Key]
        public int IdProducto { get; set; }
        public int IdSector { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public int Precio { get; set; }
        public ESectores Sector { get; set; }

        public void ReducirStock(int? cantidad = null)
        {
            this.Stock -= cantidad ?? 1;
        }

    }
}
