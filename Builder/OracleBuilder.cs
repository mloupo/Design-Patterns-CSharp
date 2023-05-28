using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class OracleBuilder : ConexionBuilder
    {
        public OracleBuilder()
        {
            conexion = new CadenaConexion();
        }

        public override void AsignarServidor()
        {
            conexion.Servidor = "Servidor Oracle";
        }
        public override void AsignarBaseDatos()
        {
            conexion.NombreBaseDatos = "Nombre Instancia Oracle";
        }
        public override void AsignarUsuario()
        {
            conexion.Usuario = "Usuario Oracle";
        }
        public override void AsignarPassword()
        {
            conexion.Password = "Password Usuario Oracle";
        }

    }
}
