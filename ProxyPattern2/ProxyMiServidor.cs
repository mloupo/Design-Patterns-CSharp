using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern2
{
    class ProxyMiServidor : Servidor
    {
        MiServidor miServidor;
        private int puerto;
        private string host;

        public ProxyMiServidor(int p, string h)
        {
            puerto = p;
            host = h;
            miServidor = null;
        }

        public override string Descargar(string url)
        {
            string resultado = String.Empty;
            if (restringido(url))
            {
                if (miServidor == null)
                    miServidor = new MiServidor(puerto, host);
                resultado = miServidor.Descargar(url);
            }
            else
                resultado = "Desde esta ubicacion no puedes Descargar.";
            return resultado;
        }

        public bool restringido(string ruta)
        {
            bool descargaPermitida = false;
            if (ruta=="descargaPermitida")
                descargaPermitida = true;
            return descargaPermitida;
        }

    }
}
