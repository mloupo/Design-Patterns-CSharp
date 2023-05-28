using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class BombillaAdapter : Bombilla
    {
        private Vela v = new Vela();
        public override string Apagar()
        {
            return v.PrenderFuego();
        }

        public override string AumentarIntensidad()
        {
            return v.EcharCombustible();
        }

        public override string Encender()
        {
            return v.SoplarParaApagar();
        }
    }
}
