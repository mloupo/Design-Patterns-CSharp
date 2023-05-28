using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class BombillaModerna : Bombilla
    {
        public override string Apagar()
        {
            return "Encendido Bombilla Moderna";
        }

        public override string AumentarIntensidad()
        {
            return "Aumentando Intensidad Bombilla Moderna";

        }

        public override string Encender()
        {
            return "Apagado Bombilla Moderna";

        }
    }
}
