using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    [Table("pedidos")]
    public class Pedido
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("idCLiente")]
        public int idCLiente { get; set; }
        public DateTime fechaHoraReg { get; set; }
        public int idUsuarioReg { get; set; }
        public virtual ICollection<PedidoDetalle> pedidoDetalle { get; set; }
    }
}
