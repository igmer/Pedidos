﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    public class Categoria
    {
        [Key]
        public String id { get; set; }
        public String nombre { get;set;}
       public String codigo { get; set; }
}
}