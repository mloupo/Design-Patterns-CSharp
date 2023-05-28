using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy2
{ 
    public abstract class Servidor
    {
        //tambien podria haber sido una Interfaz que obligara a implememtar el metodo 
        public abstract string Descargar(String url);
    }
}
