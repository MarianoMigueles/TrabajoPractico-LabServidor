<<<<<<< Updated upstream
﻿using System;
=======
﻿using Entities;
using Entities.Enums;
using System;
>>>>>>> Stashed changes
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios.Interfaces
{
    internal interface IPedidosRepository
    {
<<<<<<< Updated upstream
=======
        void CambiarEstado(Pedidos pedidos, EEstadoPedido estado);
        Task<List<Pedidos>> FueraDeTiempo();
        Task<List<Pedidos>> ObtenerPedidosPendientes();
        Task<Pedidos> ObtenerPedidoEnPreparacion(int id);
>>>>>>> Stashed changes
    }
}
