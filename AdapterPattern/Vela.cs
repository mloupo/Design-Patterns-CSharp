using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Vela
    {
        public string PrenderFuego()
        {
            return ("Encedemos Llama");
        }

        public string SoplarParaApagar()
        {
            return ("Soplamos para Apagar");
        }
        
        public string EcharCombustible()
        {
            return ("Echamos Gasolina");
        }
    
    }

}
