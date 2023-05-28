using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Pedido
    {
        public int precioProducto(Comprador comprador)
        {
            return 10;
        }
        public int comisionPedido(Comercial comercial)
        {
            return 5;
        }
    }
}
