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

        [Required]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "El código de la mesa debe tener exactamente 5 caracteres.")]
        public string CodigoMesa { get; set; }

        public string Nombre { get; set; }
        public EstadoMesa EstadoMesa { get; set; }
    }
}
