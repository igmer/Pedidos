using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    [Table("sub_categorias_producto")]
    public class SubCategoria
    {
        [Key]
        public int id { get; set; }
        public String nombre { get; set; }
        public String codigo { get; set; }
   
        public int idCategoria { get; set; }
        [ForeignKey("idCategoria ")]
        public Categoria categoria { get; set; }
    }
}
