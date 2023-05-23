using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Servidor servidor = new ProxyMiServidor(20, "https://thekaizen.com.ar");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(servidor.Descargar("descargaPermitida"));
            Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(servidor.Descargar("descargaDenegada"));
            Console.ReadLine();

        }
    }
}
