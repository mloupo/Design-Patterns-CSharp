using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    abstract class Bombilla
    {
        public abstract string Encender();
        public abstract string AumentarIntensidad();
        public abstract string Apagar();
    }
}
