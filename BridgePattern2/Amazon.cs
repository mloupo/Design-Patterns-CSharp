using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern2
{
    public abstract class Amazon
    {
        protected InterfaceEnvio interfaceEnvio;
        public Amazon(InterfaceEnvio envio)
        {
            this.interfaceEnvio = envio;
        }
        public string ProcesarPedido()
        {
            return interfaceEnvio.ProcesarPedido();
        }
        public string EnviarPaquete()
        {
            return interfaceEnvio.Enviar();
        }

        public string EntregarPaquete()
        {
            return interfaceEnvio.Entregar();
        }
        public void AsignarEnvio(InterfaceEnvio envio)
        {
            interfaceEnvio = envio;
        }
        public InterfaceEnvio ObtenerEnvio()
        {
            return interfaceEnvio;
        }






    }
   
}
