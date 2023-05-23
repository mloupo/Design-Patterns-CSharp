using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class CSuspension:IComponente
    {
        private double costo = 63850;
        private IComponente decoramosA;

        public CSuspension(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public double Costo()
        {
            return decoramosA.Costo() + costo;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Suspension en Modo Race";
        }

        public override string ToString()
        {
            return "Suspension de Alto Desempeño \r\n" + decoramosA.ToString();
        }
    }
}
