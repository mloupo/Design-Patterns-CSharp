using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Configuracion
    {
        public const int SqlServer = 1; //Podria tranquilamente ser un diccionario o enum
        public const int Oracle = 2;
        public const int MySql = 3;

        public BaseDatosGenerica CrearConexion(int BaseDatos)
        {
            BaseDatosGenerica baseDatos = null;

            if (BaseDatos == 1)
                baseDatos = new SqlServer();
            else if (BaseDatos == 2)
                baseDatos = new Oracle();
            else if (BaseDatos == 3)
                baseDatos = new MySql();
            else
                throw new Exception("Base de Datos no soportada!");

            return baseDatos;
        }
    }
}
