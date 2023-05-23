using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Conexion
    {
        private ConexionBuilder conexionBuilder;

        public void nuevaConexion(ConexionBuilder conBuilder)
        {
            conexionBuilder = conBuilder;
        }

        public void CrearCadenaConexion()
        {
            conexionBuilder.AsignarServidor();
            conexionBuilder.AsignarBaseDatos();
            conexionBuilder.AsignarUsuario();
            conexionBuilder.AsignarPassword();
        }

        public CadenaConexion conexionLista
        {
            get { return conexionBuilder.GetCadenaConexion(); }
        }
    }
}
