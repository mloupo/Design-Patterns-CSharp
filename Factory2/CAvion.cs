using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory2
{
    internal class CAvion : IVehiculo
    {
        public void Encender()
        {
            Console.WriteLine("Sigue todo el procedimiento");
        }

        public void Acelerar ()
        {
            Console.WriteLine("Empuja el acelerador");
        }

        public void Frenar()
        {
            Console.WriteLine("Jala el acelerador");
        }

        public void Girar()
        {
            Console.WriteLine("Mueve el timon de cola");
        }
    }
}
