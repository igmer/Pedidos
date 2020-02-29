using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    [Table("pedidoDetalles")]
    public class PedidoDetalle
    {

        public int id { get; set; }
        public int idPedido { get; set; }
        [ForeignKey("idProducto")]
        public int idProducto { get; set; }

        public decimal cantidad { get; set; }
        public decimal precioUnitario { get; set; }
        public decimal descuento { get; set; }
        public decimal total { get; set; }
        [ForeignKey("idPedido")]
        public Pedido pedido { get; set; }

    }
}
