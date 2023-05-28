using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Ordenador
    {
        public ArrayList datos;

        public Ordenador()
        {
            datos = new ArrayList();
        }
        public Ordenador GetValor(int pos)
        {
            Ordenador o = null;
            if (pos<datos.Count)
                return (Ordenador)datos[pos];

            return o;
        }

        public void AñadirValor(string valor)
        {
            datos.Add(valor);
        }

        public int Dimension()
        {
            return datos.Count;
        }

        public IteradorOrdenador iterador()
        {
            return new IteradorOrdenador(this);
        }
    }
}
