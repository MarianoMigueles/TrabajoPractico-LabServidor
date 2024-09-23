using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EstadoPedido
    {
        [Key]
        public int IdEstado {  get; set; }
        public string Descripcion { get; set; }
    }
}
