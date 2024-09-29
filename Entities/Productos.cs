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
    public class Productos
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }

        private int _Stock;
        public int Stock {
            get => this._Stock;
            set
            {
                this._Stock = value;
            }
        }
        public int Precio { get; set; }
        public ESectores Sector { get; set; }

        public void ReducirStock(int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException("La cantidad a reducir debe ser mayor que cero.");
            }

            if (Stock - cantidad < 0)
            {
                throw new InvalidOperationException($"No se pudo reducir el stock. La cantidad disponible ({this._Stock}) es insuficiente para cubrir la cantidad solicitada ({cantidad}).");
            }

            this.Stock -= cantidad;
        }

        public void RellenarStock(int nuevoStock)
        {
            if (nuevoStock <= 0)
            {
                throw new ArgumentException("La cantidad a rellenar debe ser mayor que cero.");
            }

            this.Stock += nuevoStock;
        }

    }
}
