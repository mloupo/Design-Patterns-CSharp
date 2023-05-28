using System;

namespace Bridge2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Creamos el objeto que representa a la empresa de mensajeria
            RepartoAmazon reparto = new RepartoAmazon("123546");

            // Enviamos el paquete a Argentina por defecto
            System.Console.WriteLine(reparto.ProcesarPedido());
            System.Console.WriteLine(reparto.EnviarPaquete());
            System.Console.WriteLine(reparto.EntregarPaquete());
            Console.ReadLine();

            //Ahora queremos enviar a Mexico
            reparto.AsignarEnvio(new EnvioMexico());

            // Enviamos el paquete a Argentina por defecto
            System.Console.WriteLine(reparto.ProcesarPedido());
            System.Console.WriteLine(reparto.EnviarPaquete());
            System.Console.WriteLine(reparto.EntregarPaquete());
            Console.ReadLine();
        }
    }
}
