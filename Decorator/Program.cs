using System;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator Pattern\n");

            //Creamos el componente central con tipo IComponente
            //para ermitir la decoracion
            IComponente miAuto = new CAuto("2018", "4 Puertas", 200000);

            Console.WriteLine(miAuto);

            //si necesitamos usar un metodo propio de CAuto
            // necesitamos hacer uso de un type cast
            ((CAuto)miAuto).Puertas(true);
            Console.WriteLine("-------------");

            //decoramos el auto con un sistemas de sonido
            miAuto = new CSistemaSonido(miAuto);
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("-------------");

            miAuto = new CNitrogeno(miAuto);
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            //para utilizar un metodo propio de Nitrogeno
            // necesitamos hacer un type cast
            ((CNitrogeno)miAuto).UsaN();
            Console.WriteLine("-------------");

            miAuto = new CSuspension(miAuto);
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            //una vez decorado no se puede volver a usar metodos especificos de la clase
            //((CNitrogeno)miAuto).UsaN();
            //((CAuto)miAuto).Puertas();
            Console.ReadLine();
        }
    }
}
