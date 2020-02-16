using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    public class Pedido
    {
        [Key]
        public String id { get; set; }
        [ForeignKey("idCLiente")]
        public String idCLiente { get; set; }
        public DateTime fechaHoraReg { get; set; }
        public int idUsuarioReg { get; set; }
    }
}
