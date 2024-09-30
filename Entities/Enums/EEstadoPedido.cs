using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enums
{
    public enum EEstadoPedido
    {
        Pendiente,
        EnPreparacion,
        ListoParaServir,
        Entregado,
        EntregadoFueraDeTiempo,
        Pagado
    }
}
