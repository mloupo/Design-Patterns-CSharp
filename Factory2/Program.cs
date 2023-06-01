﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int dinero;
            IVehiculo vehiculo;

            Console.WriteLine("Cuanto dinero tienees para tu vehiculo?");
            dato = Console.ReadLine();
            dinero = Convert.ToInt32(dato);
            vehiculo = CCreador.MetodoFabrica(dinero);
            vehiculo.Encender();
            vehiculo.Acelerar();
            vehiculo.Frenar();
            vehiculo.Girar();
            Console.ReadLine(); 

        }
    }
}
