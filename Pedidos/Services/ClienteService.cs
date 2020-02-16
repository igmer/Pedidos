using Pedidos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Services
{
    public class ClienteService
    {
        private readonly PedidoDbContext _pedidoDbContext;

        public ClienteService(PedidoDbContext pedidoDbContext)
        {
            _pedidoDbContext = pedidoDbContext;
        }
        public List<Cliente> obtener()
        {
            var result = _pedidoDbContext.Cliente.ToList();
            return result;


        }

    }
}
