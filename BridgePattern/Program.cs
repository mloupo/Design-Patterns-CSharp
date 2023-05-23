using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Main representa al Cliente
            Dictionary<string, double> productos = new Dictionary<string, double>();

            //Hardcodeamos algunos productos
            productos.Add("M101", 56.32);
            productos.Add("M234", 23.88);
            productos.Add("C654", 974.56);
            productos.Add("M401", 43.28);
            productos.Add("C345", 785.12);
            productos.Add("D567", 432.56);
            productos.Add("M103", 874.54);
            productos.Add("D901", 23.18);
            productos.Add("C732", 43.12);
            productos.Add("M056", 21.42);


            //Creamos el bridge
            //CAbstraccion bridge = new CAbstraccion(new CImplementacion3(), productos);
            CAbstraccion bridge = new CAbstraccion(3, productos);


            bridge.MostrarTotales();
            bridge.Listar();


            Console.ReadLine();

        }
    }
}
