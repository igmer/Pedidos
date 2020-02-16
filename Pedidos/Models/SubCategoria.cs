using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    public class SubCategoria
    {
        [Key]
        public String id { get; set; }
        public String nombre { get; set; }
        public String codigo { get; set; }
        [ForeignKey("idCategoria")]
        public int idCategoria { get; set; }
    }
}
