using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;

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

            if(this.EstadoMesa == estadoMesa)
            {
                throw new InvalidOperationException("La mesa ya se encuentra en ese estado");
            }
            else if (this.EstadoMesa == EEstadoMesa.Cerrada)
            {
                throw new InvalidOperationException("No se puede cambiar el estado de la mesa ya que se encuentra cerrada");
            }
            else if (estadoMesa == EEstadoMesa.Cerrada)
            {
                throw new InvalidOperationException("Solo el administrador puede cerrar la mesa");
            }

            this.EstadoMesa = estadoMesa;
        }

        public void CerrarMesa()
        {
            if(this.EstadoMesa == EEstadoMesa.Cerrada)
            {
                throw new Exception("La mesa ya se encuentra cerrada");
            }

            this.EstadoMesa = EEstadoMesa.Cerrada;
        }
    }
}
