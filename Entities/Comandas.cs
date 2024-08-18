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

        [ForeignKey(nameof(IdMesaNavigation))]
        public int IdMesa { get; set; }
        public string NombreCliente { get; set; }

        public Mesas IdMesaNavigation { get; set; }
    }
}
