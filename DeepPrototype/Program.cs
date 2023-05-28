using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepPrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p= new Persona();
            p.Altura = 170;
            p.Peso = 80;
            p.Detalle = new DetallePersona();
            p.Detalle.EstaCalvo = false;
            p.Detalle.ColorOjos = "Rojos";

            Persona clon = p.Clone() as Persona;
            clon.Detalle.EstaCalvo = true;
            clon.Detalle.ColorOjos = "Verdes";

            Console.WriteLine(p.Detalle.ColorOjos);
            Console.WriteLine(p.Detalle.EstaCalvo);

            Console.WriteLine(clon.Detalle.ColorOjos);
            Console.WriteLine(clon.Detalle.EstaCalvo);

            Console.ReadLine();
        }
    }
}
