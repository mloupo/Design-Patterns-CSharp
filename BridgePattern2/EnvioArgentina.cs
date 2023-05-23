using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern2
{
    internal class EnvioArgentina : InterfaceEnvio
    {
        public EnvioArgentina ()
        { }

        public string Entregar()
        {
            return "Pedido entregado Argentina";
        }

        public string Enviar()
        {
            return "Pedido enviado Argentina";
        }

        public string ProcesarPedido()
        {
            return "Pedido procesado Argentina";
        }
    }
}
