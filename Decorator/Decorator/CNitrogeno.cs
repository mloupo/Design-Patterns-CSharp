using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class CNitrogeno:IComponente
    {
        private double costo = 45000;
        private IComponente decoramosA;
        public CNitrogeno(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Sistemas de Nitrogeno\r\n" + decoramosA.ToString();
        }

        public double Costo()
        {
            return decoramosA.Costo() + costo;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Nitrogenos Listo";
        }

        public void UsaN()
        {
            Console.WriteLine("Nitrogeno en Uso");
        }
    }
}
