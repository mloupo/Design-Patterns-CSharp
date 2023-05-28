using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2
{
    internal class SQL: IConexion
    {
        bool conexionCorrecta = false;
        public string Conectar()
        {
            //try catch 
            conexionCorrecta = false;
            return "Conectando con BBDD SQL";
        }

        public bool ConexionEstablecida()
        {
            return conexionCorrecta;
        }
    }
}
