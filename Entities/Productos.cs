using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Productos
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        private int _stock;
        public int Stock
        {   get => _stock;
            set
            {
                if(value < 0)
                {
                    throw new Exception("El stock esta en 0");
                } 

                _stock = value;
            }
        }
        public int Precio { get; set; }
        public Sectores Sector { get; set; }

        public void ReducirStock(int? cantidad = null)
        {
            this.Stock -= cantidad ?? 1;
        }
    }
}
