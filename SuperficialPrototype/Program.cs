using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperficialPrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Mueble mueble =new Mueble();
            mueble.NumAsientos = 1;
            mueble.Nombre = "Silla Victoriana";

            Console.WriteLine("num: " + mueble.NumAsientos.ToString());
            Console.WriteLine("Nombre: " + mueble.Nombre);
            Console.ReadLine();

            Mueble clonMueble = mueble.Clone() as Mueble;

            Console.WriteLine("num: " + clonMueble.NumAsientos.ToString());
            Console.WriteLine("Nombre: " + clonMueble.Nombre);
            Console.ReadLine();

        }
    }
}
