using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Empleados
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpleados {  get; set; }


        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Passsword { get; set; }

        public Sectores Sector { get; set; }
        public Roles Rol { get; set; }

    }
}
