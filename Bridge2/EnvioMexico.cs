using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2
{
    internal class EnvioMexico : InterfaceEnvio
    {
        public EnvioMexico()
        { }


        public string Entregar()
        {
            return "Pedido entregado Mexico";
        }

        public string Enviar()
        {
            return "Pedido enviado Mexico";
        }

        public string ProcesarPedido()
        {
            return "Pedido procesado Mexico";
        }

    }
}
