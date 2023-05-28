using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2
{
    internal interface IConexion
    {
        string Conectar();

        bool ConexionEstablecida();
    }
}
