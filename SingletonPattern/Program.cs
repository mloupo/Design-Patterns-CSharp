using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SingletonEjemplo.Singleton.texto);
            Console.WriteLine(SingletonEjemplo.Singleton.numero.ToString());
            Console.ReadLine();

            SingletonEjemplo.Singleton.texto="Hola Marti, soy singleton de nuevo";
            SingletonEjemplo.Singleton.numero = 10;

            Console.WriteLine(SingletonEjemplo.Singleton.texto);
            Console.WriteLine(SingletonEjemplo.Singleton.numero.ToString());
            Console.ReadLine();
        }
    }
}
