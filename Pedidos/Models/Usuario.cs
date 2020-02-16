using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    public class Usuario
    {
        [Key]
        public int id { get; set; }
        public String username { get; set; }
        public String username_canonical { get; set; }
        public String email { get; set; }
        public String email_canonical { get; set; }
        public int enabled { get; set; }
        public String salt { get; set; }
        public String password { get; set; }
        public DateTime last_login { get; set; }
        public String confirmation_token { get; set; }
        public String password_requested_at { get; set; }
        public String roles { get; set; }
    }
}
