using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Pedidos
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPedidos { get; set; }

        [ForeignKey(nameof(IdComandaNavigation))]
        public int IdComandas { get; set; }

        [ForeignKey(nameof(IdProductoNavigation))]
        public int IdProducto { get; set; }

        public int Cantidad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaFinalizacion { get; set; }

        public Comandas IdComandaNavigation { get; set; }
        public List<Productos> IdProductoNavigation { get; set; }

        private EstadoPedido _estadoPedido;
        public EstadoPedido EstadoPedido
        {
            get => _estadoPedido;
            set
            {
                if (_estadoPedido == EstadoPedido.Entregado)
                {
                    throw new Exception("No se puede cambiar el estado, ya que el pedido ya fue entregado");
                }
                _estadoPedido = value; 
            }
        }

        public void CambiarEstado(EstadoPedido estado)
        {
            if(this.EstadoPedido == EstadoPedido.ListoParaServir)
            {
                this.FechaFinalizacion = DateTime.Now;
            }

            this.EstadoPedido = estado;
        } 

    }
}
