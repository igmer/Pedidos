using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    public class PedidoDetalle
    {

        public int id { get; set; }
        [ForeignKey("idPedido")]
        public int idPedido { get; set; }
        [ForeignKey("idProducto")]
        public int idProducto { get; set; }

        public double cantidad { get; set; }
        public double precioUnitario { get; set; }
        public double descuento { get; set; }
        public double total { get; set; }

    }
}
