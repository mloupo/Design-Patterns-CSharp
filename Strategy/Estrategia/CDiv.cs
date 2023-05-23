using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Estrategia
{
    internal class CDiv : IOperacion
    {
        public double operacion(double a, double b)
        {
            return a / b;
        }
    }
}
