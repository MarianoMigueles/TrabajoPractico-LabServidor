using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;

namespace Entities
{
    public class OperacionesEmpleados
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey(nameof(Empleado))]
        public int IdEmpleado { get; set; }
        public Empleados Empleado { get; set; }

        public ESectores Sector { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaOperacion { get; set; }
    }
}
