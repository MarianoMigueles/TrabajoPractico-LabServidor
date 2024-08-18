using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class Pedidos
    {
        [Key]
        public int IdPedidos { get; set; }
        public int IdComandas { get; set; }
        public int IdProducto { get; set; }
        public int IdEstado { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaFinalizacion { get; set; }

    }
}
