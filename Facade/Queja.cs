using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Queja
    {
        public string Quejas(Comprador comprador)
        {
            return ("Escuchando quejas Comprador");
        }
        public string Quejas(Comercial comprador)
        {
            return ("Escuchando quejas Comercial");
        }
        public string Quejas(Desarrollador comprador)
        {
            return ("Escuchando quejas Desarrollador");
        }

    }
}
