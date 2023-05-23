using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperficialPrototypePattern
{
    class Mueble:IClonable
    {
        private int numAsientos;
        private string nombre;

        public int NumAsientos { get => numAsientos; set => numAsientos = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
