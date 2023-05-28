using FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Configuracion conf = new Configuracion();
            BaseDatosGenerica bDatos = conf.CrearConexion(Configuracion.SqlServer);
            Console.WriteLine(bDatos.GetCadenaConexion());
            bDatos.GuardarRegistro();

            Console.ReadLine();

            bDatos = conf.CrearConexion(Configuracion.Oracle);
            Console.WriteLine(bDatos.GetCadenaConexion());
            bDatos.GuardarRegistro();
            Console.ReadLine();

            bDatos = conf.CrearConexion(Configuracion.MySql);
            Console.WriteLine(bDatos.GetCadenaConexion());
            bDatos.GuardarRegistro();

            Console.ReadLine();

        }
    }
}
