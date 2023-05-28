using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos una CLase GestionarConexiones
            GestionarConexiones gesConex = new GestionarConexiones();
            gesConex.ConexionesSQL();
            //gesConex.ConexionesOracle();
            Console.WriteLine(gesConex.Conectar());
            Console.WriteLine("Conexion establecida: " + gesConex.ConexionCorrecta());
            Console.ReadLine();


            if (!gesConex.ConexionCorrecta())
            {
                gesConex.ConexionesOracle();
                //gesConex.ConexionesSQL();                
                Console.WriteLine(gesConex.Conectar());
                Console.WriteLine("Conexion establecida: "+ gesConex.ConexionCorrecta());
            }
            Console.ReadLine();
        }
    }
}
