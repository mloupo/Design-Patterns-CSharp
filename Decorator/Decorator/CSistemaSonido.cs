using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class CSistemaSonido :IComponente
    {
        private double costo = 3500;
        //variable de referencia hacia quien decoramos
        private IComponente decoramosA;

        //pasamos el objeto que va a ser decorado
        public CSistemaSonido(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Radio 350XZ +\r\n" + decoramosA.ToString();
        }

        //metodos de la interfaz

        public double Costo()
        {
            //el costo de lo que decoro mas mi costo como componente
            return decoramosA.Costo() + costo;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Enciendo el radio";
        }
    }
}
