using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern2
{
    internal class GestionarConexiones
    {
        private IConexion conexion;
        public void ConexionesOracle()
        {
            this.conexion = new Oracle();
        }
        public void ConexionesSQL()
        {
            this.conexion = new SQL();
        }

        public string Conectar()
        {
            return this.conexion.Conectar();
        }
        public bool ConexionCorrecta()
        {
            return this.conexion.ConexionEstablecida();
        }
    }
}