﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;
using Exeptions;

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
        public DateTime? FechaFinalizacion { get; set; }
        public DateTime? TiempoEstimadoFinalizacion { get; set; }

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
                    throw new InvalidStateException("No se puede cambiar el estado, ya que el pedido ya fue entregado");
                }

                if(_estadoPedido == EEstadoPedido.Pagado)
                {
                    throw new InvalidStateException("No se puede cambiar el estado, ya que el pedido ya fue entragado y pagado");
                }
                _estadoPedido = value; 
            }
        }

        public void CambiarEstado(EEstadoPedido estado)
        {
            if ((int)estado < (int)this.EstadoPedido)
            {
                throw new InvalidStateException("No se puede cambiar el estado a uno anterior.");
            }

            if (estado == this.EstadoPedido)
            {
                throw new InvalidStateException("El pedido ya se encuentra en este estado.");
            }

            if (this.EstadoPedido == EEstadoPedido.ListoParaServir)
            {
                this.FechaFinalizacion = DateTime.Now;

                if(this.FechaFinalizacion > this.TiempoEstimadoFinalizacion)
                {
                    this.EstadoPedido = EEstadoPedido.EntregadoFueraDeTiempo;
                }
            }

            this.EstadoPedido = estado;
        } 

        public void CambiarEstado(DateTime tiempoEstimadoFinalizacion)
        {
            if (this.EstadoPedido != EEstadoPedido.Pendiente)
            {
                throw new InvalidStateException($"No se puede asignar una fecha estimada de finalizacion al pedido ya que el pedido se encuentra {this.EstadoPedido}");
            }
            else
            {
                this.TiempoEstimadoFinalizacion = tiempoEstimadoFinalizacion;
                this.CambiarEstado(EEstadoPedido.EnPreparacion);
            }

        }

    }
}
