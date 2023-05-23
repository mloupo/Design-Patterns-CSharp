using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BombillaClasica bombillaClasica = new BombillaClasica();
            Console.WriteLine(bombillaClasica.Encender());
            Console.WriteLine(bombillaClasica.AumentarIntensidad());
            Console.WriteLine(bombillaClasica.Apagar());
            Console.ReadLine();

            BombillaModerna bombillaModerna = new BombillaModerna();
            Console.WriteLine(bombillaModerna.Encender());
            Console.WriteLine(bombillaModerna.AumentarIntensidad());
            Console.WriteLine(bombillaModerna.Apagar());
            Console.ReadLine();

            BombillaAdapter usarVela = new BombillaAdapter();
            Console.WriteLine(usarVela.Encender());
            Console.WriteLine(usarVela.AumentarIntensidad());
            Console.WriteLine(usarVela.Apagar());
            Console.ReadLine();
        }
    }
}
