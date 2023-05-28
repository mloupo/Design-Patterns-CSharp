namespace Builder
{
    internal class MySqlBuilder : ConexionBuilder
    {
        public MySqlBuilder()
        {
            conexion = new CadenaConexion();
        }

        public override void AsignarServidor()
        {
            conexion.Servidor = "Servidor MySql";
        }
        public override void AsignarBaseDatos()
        {
            conexion.NombreBaseDatos = "Nombre Instancia MySql";
        }
        public override void AsignarUsuario()
        {
            conexion.Usuario = "Usuario MySql";
        }
        public override void AsignarPassword()
        {
            conexion.Password = "Password Usuario MySql";
        }
    }
}
