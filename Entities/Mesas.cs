using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Mesas
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMesa {  get; set; }

        [ForeignKey(nameof(IdEstadoNesaNavigation))]
        public int IdEstado { get; set; }
        public string Nombre { get; set; }

        public EstadoMesa IdEstadoNesaNavigation { get; set; }
    }
}
