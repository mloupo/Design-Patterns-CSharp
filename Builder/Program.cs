using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var conexion = new Conexion();

            //Creamos cadena de conexion a SqlServer
            conexion.nuevaConexion(new SqlServerBuilder());
            conexion.CrearCadenaConexion();
            var conexionSqlServer = conexion.conexionLista;

            //Creamos cadena de conexion a SqlServer
            conexion.nuevaConexion(new OracleBuilder());
            conexion.CrearCadenaConexion();
            var conexionOracle = conexion.conexionLista;

            //Creamos cadena de conexion a SqlServer
            conexion.nuevaConexion(new MySqlBuilder());
            conexion.CrearCadenaConexion();
            var conexionMySql = conexion.conexionLista;

        }
    }
}
