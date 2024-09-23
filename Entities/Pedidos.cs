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
    public class Pedidos
    {
        [Key]
        public int IdPedidos { get; set; }
        public int IdComandas { get; set; }
        public int IdProducto { get; set; }
        public int IdEstado { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaFinalizacion { get; set; }

<<<<<<< Updated upstream
=======
        public Comandas IdComandaNavigation { get; set; }
        public Productos IdProductoNavigation { get; set; }

        private EEstadoPedido _estadoPedido;
        public EEstadoPedido EstadoPedido
        {
            get => _estadoPedido;
            set
            {
                if (_estadoPedido == EEstadoPedido.Entregado)
                {
                    throw new Exception("No se puede cambiar el estado, ya que el pedido ya fue entregado");
                }
                _estadoPedido = value; 
            }
        }

        public void CambiarEstado(EEstadoPedido estado)
        {
            if(this.EstadoPedido == EEstadoPedido.ListoParaServir)
            {
                this.FechaFinalizacion = DateTime.Now;
            }

            this.EstadoPedido = estado;
        } 

>>>>>>> Stashed changes
    }
}
