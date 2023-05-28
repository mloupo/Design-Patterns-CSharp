using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class BombillaClasica : Bombilla
    {
        public override string Apagar()
        {
            return "Encendido Bombilla Clasica";
        }

        public override string AumentarIntensidad()
        {
            return "Aumentando Intensidad Bombilla Clasica";

        }

        public override string Encender()
        {
            return "Apagado Bombilla Clasica";

        }
    }
}
