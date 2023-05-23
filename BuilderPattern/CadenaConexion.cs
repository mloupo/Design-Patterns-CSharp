using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class CadenaConexion
    {
        public string Servidor { get; set; }  
        public string NombreBaseDatos { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }

        public CadenaConexion(string servidor, string nombreBaseDatos, string usuario, string password)
        {
            Servidor = servidor;
            NombreBaseDatos = nombreBaseDatos;
            Usuario = usuario;
            Password = password;
        }

        public CadenaConexion()
        {
        }
    }
}
