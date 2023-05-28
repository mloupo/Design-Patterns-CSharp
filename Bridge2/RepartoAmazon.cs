using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2
{
    internal class RepartoAmazon: Amazon
    {
        private string numPedido;

        public RepartoAmazon(string idPedido):base(new EnvioArgentina())
        {
            this.numPedido = idPedido;
        }
        public RepartoAmazon(string idPedido, InterfaceEnvio envio):base(envio)
        {
            this.numPedido=idPedido;
        }
        public string IdPedido()
        { return "Nuestro Pedido es: " + numPedido; }
    }
}
