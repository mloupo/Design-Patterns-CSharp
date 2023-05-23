using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class SqlServerBuilder : ConexionBuilder
    {
        public SqlServerBuilder()
        {
            conexion = new CadenaConexion();
        }

        public override void AsignarServidor()
        {
            conexion.Servidor = "Servidor SQL SERVER";
        }
        public override void AsignarBaseDatos()
        {
            conexion.NombreBaseDatos = "Nombre Instancia SQL SERVER";
        }
        public override void AsignarUsuario()
        {
            conexion.Usuario = "Usuario SQL SERVER";
        }
        public override void AsignarPassword()
        {
            conexion.Password = "Password Usuario SQL SERVER";
        }

    }
}
