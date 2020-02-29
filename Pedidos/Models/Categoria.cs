using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    [Table("categorias_producto")]
    public class Categoria
    {
        [Key]
        public int id { get; set; }
        public String nombre { get;set;}
       public String codigo { get; set; }
}
}
