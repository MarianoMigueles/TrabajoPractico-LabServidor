using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;

namespace Entities
{
    public class Mesas
    {
        [Key]
        public int IdMesa {  get; set; }
        public int IdEstado { get; set; }
        public string Nombre { get; set; }
<<<<<<< Updated upstream
=======
        public EEstadoMesa EstadoMesa { get; set; }
>>>>>>> Stashed changes
    }
}
