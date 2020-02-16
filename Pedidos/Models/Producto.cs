using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    public class Producto
    {
        [Key]
        public int id { get; set; }
        public String nombre { get; set; }
        public String codigo { get; set; }
        [ForeignKey("idSubCategoria")]
        public int idSubCategoria { get; set; }
        public int exentoIva { get; set; }
    }
}
