using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal abstract class ConexionBuilder
    {
        protected CadenaConexion conexion;
        public CadenaConexion GetCadenaConexion() { return conexion; }

        public virtual void AsignarServidor() { }
        public virtual void AsignarBaseDatos() { }
        public virtual void AsignarUsuario() { }
        public virtual void AsignarPassword() { }
    }
}
