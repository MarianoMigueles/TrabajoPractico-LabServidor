﻿using BLL.DTO.Mesas;
using BLL.DTO.Pedidos;
using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interface
{
    public interface IPedidosService
    {
        Task<PedidosDTO> CambiarEstado(int idPedido, EEstadoPedido estado);
        Task<List<PedidosDTO>> ObtenerPedidosFueraDeTiempo();
        Task<DateTime> ObtenerTiempoEstimadoPedidoDePreparacion(int idPedido);
        Task<PedidosDTO> PonerPedidoEnPreparacion(int idPedido, DateTime tiempoEstimado);
        Task<List<PedidosDTO>> ObtenerPedidosPendientes();
        Task<bool> CrearPedido(int idComanda, int idProducto, int cantidad);
        Task<PedidosDTO> ConsultarEstadoPedido(int id);
        Task<List<PedidosDTO>> ObtenerPedidosPendientesPorSector(ESectores sector);
        Task<List<PedidosDTO>> ObtenerPedidosListosParaServir();
        Task<List<PedidosDTO>> ObtenerPedidos();
    }
}
