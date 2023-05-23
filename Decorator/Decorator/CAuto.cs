using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class CAuto :IComponente
    {
        private string modelo;
        private string caracteristicas;
        public double costo;

        public CAuto(string pModelo, string pCaract, double pCcosto)
        {
            modelo = pModelo;
            caracteristicas = pCaract;
            costo = pCcosto;
        }

        public void Puertas(bool pEstado)
        {
            if (pEstado)
                Console.WriteLine("Puertas Cerradas");
            else
                Console.WriteLine("Puertas Abiertas");
        }

        public override string ToString()
        {
            return string.Format("Modelo {0}, {1} \r\n", modelo, caracteristicas);
        }

        public double Costo()
        {
            return costo;
        }

        public string Funciona()
        {
            return "Encendi el motor";
        }
    }
}
