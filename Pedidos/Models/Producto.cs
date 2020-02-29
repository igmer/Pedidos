using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    [Table("productos")]
    public class Producto
    {
        [Key]
        public int id { get; set; }
        public String nombre { get; set; }
        public String codigo { get; set; }
        public int idSubCategoria { get; set; }

        [ForeignKey("idSubCategoria")]
        public SubCategoria subCategoria { get; set; }
        public int exentoIva { get; set; }
    }
}
