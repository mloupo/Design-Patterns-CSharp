﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class CImplementacion3 : IBridge
    {
        public void MostrarTotales(Dictionary<string, double> pProductos)
        {
            double total = 0;
            double totalm = 0;
            double totalc = 0;
            double totald = 0;
            int cantidad = 0;

            foreach (KeyValuePair<string, double> p in pProductos)
            {
                total += p.Value;
                if (p.Key[0] == 'C')
                    totalc += p.Value;

                if (p.Key[0] == 'M')
                    totalm += p.Value;

                if (p.Key[0] == 'D')
                    totald += p.Value;
                cantidad++;
            }
            Console.WriteLine("El Total de comida es ${0}, {1}% del total", totalc, totalc/total*100);
            Console.WriteLine("El Total de medicamentos es ${0}, {1}% del total", totalm, totalm / total * 100);
            Console.WriteLine("El Total de deportes es ${0}, {1}% del total", totald, totald / total * 100); 
            Console.WriteLine("El Total de {0} es ${1}", cantidad, total);
        }
        public void ListarProductos(Dictionary<string, double> pProductos)
        {
            foreach (KeyValuePair<string, double> p  in pProductos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (p.Key[0] == 'C')
                    Console.WriteLine("{0} - {1}", p.Key, p.Value);

            }
            foreach (KeyValuePair<string, double> p in pProductos)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (p.Key[0] == 'M')
                    Console.WriteLine("{0} - {1}", p.Key, p.Value);

            }
            foreach (KeyValuePair<string, double> p in pProductos)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (p.Key[0] == 'D')
                    Console.WriteLine("{0} - {1}", p.Key, p.Value);

            }




        }

       
    }
}
