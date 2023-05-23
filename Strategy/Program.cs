using Strategy.Estrategia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy Pattern");


            string dato = "";
            double x = 0;
            double y = 0;
            double r = 0;
            string opcion = "";

            IOperacion miOperacion = new CSuma();

            while (opcion != "5")
            {
                Console.WriteLine("1-Suma, 2-Resta, 3-Multiplicacion, 4-Division, 5-Salir");
                opcion = Console.ReadLine();
                if (opcion == "5")
                    break;
                Console.WriteLine("Ingresa primer operando");
                dato = Console.ReadLine();
                x = Convert.ToDouble(dato);

                Console.WriteLine("Ingresa el segundo operando");
                dato = Console.ReadLine();
                y = Convert.ToDouble(dato);

                //if (opcion == "1")
                //    miOperacion = new CSuma();

                //if (opcion == "2")
                //    miOperacion = new CResta();

                //if (opcion == "3")
                //    miOperacion = new CMulti();

                //if (opcion == "4")
                //    miOperacion = new CDiv();


                switch (opcion)
                {
                    case "1":
                        miOperacion = new CSuma();
                        break;

                    case "2":
                        miOperacion = new CResta();
                        break;

                    case "3":
                        miOperacion = new CMulti();
                        break;

                    case "4":
                        miOperacion = new CDiv();
                        break;
                }

                r = miOperacion.operacion(x, y);

                Console.WriteLine("El resultado es {0}", r);

            }


            Console.ReadLine();
        }
    }
}
