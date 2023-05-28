using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class MySql : BaseDatosGenerica
    {
        public override string GetCadenaConexion()
        {
            return "Cadena de conexion MySql";
        }

        public override void GuardarRegistro()
        {
            Console.WriteLine("Se Guardo el registro correctamente en MySql");
        }
    }
}
