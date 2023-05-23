using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Desarrollador programador = new Desarrollador();
            Comprador cliente = new Comprador();
            Comercial vendedor = new Comercial();

            //SIN FACADE
            Queja queja = new Queja();
            queja.Quejas(vendedor);
            queja.Quejas(programador);
            queja.Quejas(cliente);
            Pedido pedido = new Pedido();
            int totalPrecioPedido = 0;
            totalPrecioPedido = pedido.comisionPedido(vendedor);
            totalPrecioPedido += pedido.precioProducto(cliente);
            Console.WriteLine("Total sin Facade: "+ totalPrecioPedido);
            Console.ReadLine();

            //CON FACADE
            Empresa empresa = new Empresa();
            empresa.EscucharQuejas(programador);
            empresa.EscucharQuejas(vendedor);
            empresa.EscucharQuejas(cliente);
            totalPrecioPedido=empresa.HacerPedido(vendedor, cliente);
            Console.WriteLine("Total con Facade: " + totalPrecioPedido);
            Console.ReadLine();


        }
    }
}
