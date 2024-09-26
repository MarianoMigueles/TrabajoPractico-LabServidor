using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Comandas
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdComandas {  get; set; }
        public int IdMesa { get; set; }
        public string NombreCliente { get; set; }
    }
}
