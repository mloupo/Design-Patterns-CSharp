using System;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy Pattern\n");
            Console.WriteLine("Proxy Sencillo");
            CProxy.ISujeto miProxy = new CProxy.ProxySencillo();
            miProxy.Peticion(1);
            Console.WriteLine("-------");
            miProxy.Peticion(2);

            Console.WriteLine("Proxy Seguro");
            CProxy.ISujeto miProxyS = new CProxy.ProxySeguro();
            miProxyS.Peticion(1);
            Console.WriteLine("-------");
            miProxyS.Peticion(2);






            
            Console.ReadLine();
        }
    }
}
