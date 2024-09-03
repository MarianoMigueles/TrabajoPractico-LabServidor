﻿using System;
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
        public EstadoPedido EstadoPedido { get; set; }

    }
}
