using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    [Table("clientes")]
    public class Cliente
    {
            public int id { get; set; }
            public String nombre {get; set;}
            public String direccion {get; set;}
            public String nrc {get; set;}
            public String nit {get; set;}
            public String otroDocumento {get; set;}
            public String giro {get; set;}
            public String telefono {get; set;}
            public DateTime? fechaHoraReg {get; set;}
    }
}
