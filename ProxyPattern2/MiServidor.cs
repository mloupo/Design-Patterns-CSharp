using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern2
{
    class MiServidor:Servidor
    {
        private int puerto;
        private string host;

        public MiServidor(int puerto, string host)
        {
            this.puerto = puerto;
            this.host = host;
        }

        public override string Descargar(string url)
        {
            return "Descargando de " + host;
        }
    }
}
