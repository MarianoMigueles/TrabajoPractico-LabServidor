using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;
using Exeptions;

namespace Entities
{
    public class Mesas
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMesa {  get; set; }
        public string Nombre { get; set; }
        public EEstadoMesa EstadoMesa { get; set; }

        public void CambiarEstado(EEstadoMesa estadoMesa)
        {

            if (this.EstadoMesa == estadoMesa)
            {
                throw new InvalidStateException("La mesa ya está en el estado solicitado.");
            }

            if (this.EstadoMesa == EEstadoMesa.Cerrada)
            {
                throw new InvalidStateException("No se puede cambiar el estado de una mesa que ya está cerrada.");
            }

            if (estadoMesa == EEstadoMesa.Cerrada)
            {
                throw new UnauthorizedAccessException("Solo un administrador puede cerrar la mesa.");
            }

            this.EstadoMesa = estadoMesa;
        }

        public void CerrarMesa()
        {
            if(this.EstadoMesa == EEstadoMesa.Cerrada)
            {
                throw new InvalidStateException("La mesa ya se encuentra cerrada");
            }

            this.EstadoMesa = EEstadoMesa.Cerrada;
        }
    }
}
