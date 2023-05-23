using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern2
{
    internal class EnvioEspaña : InterfaceEnvio
    {
        public EnvioEspaña()
        { }

        public string Entregar()
        {
            return "Pedido entregado España";
        }

        public string Enviar()
        {
            return "Pedido enviado España";
        }

        public string ProcesarPedido()
        {
            return "Pedido procesado España";
        }
    }
}
