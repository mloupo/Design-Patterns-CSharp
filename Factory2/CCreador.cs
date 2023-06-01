using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory2
{
    internal class CCreador
    {
        public static IVehiculo MetodoFabrica(int pDinero)
        {
            IVehiculo temp = null;
            if (pDinero > 1000000) 
                temp = new CAvion();
            else if (pDinero >200000)
                temp = new CAuto();
            else
                temp = new CBicicleta();

            return temp;
        }

    }
}
