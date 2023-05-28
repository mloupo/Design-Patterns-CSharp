using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ordenador lista = new Ordenador();
            lista.AñadirValor("Pentium 1");
            lista.AñadirValor("Pentium 2");
            lista.AñadirValor("Pentium 3");
            lista.AñadirValor("Pentium 4");

            IteradorOrdenador iterador = lista.iterador();

            while (iterador.ExisteSiguiente())
                Console.WriteLine(iterador.Siguiente());

            Console.ReadLine();
        }
    }
}
