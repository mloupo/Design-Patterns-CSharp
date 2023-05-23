using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal abstract class BaseDatosGenerica
    {
        public abstract string GetCadenaConexion();
        public abstract void GuardarRegistro();
    }
}
