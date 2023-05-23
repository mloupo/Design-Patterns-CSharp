using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern2
{
    internal class Oracle : IConexion
    {
        bool conexionCorrecta = false;
        public string Conectar()
        {
            //try catch 
            conexionCorrecta=true;
            return "Conectando con BBDD ORACLE";
        }

        public bool ConexionEstablecida()
        {            
            return conexionCorrecta;
        }
    }
}
