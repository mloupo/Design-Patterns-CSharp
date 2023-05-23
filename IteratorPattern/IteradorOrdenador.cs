using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class IteradorOrdenador
    {
        private ArrayList ordenador;
        private int posicion;

        public IteradorOrdenador(Ordenador o)
        {
            this.ordenador = o.datos;
            posicion = 0;
        }

        public bool ExisteSiguiente()
        {
            if (posicion < ordenador.Count)
                return true;
            else
                return false;   
        }

        public Object Siguiente()
        {
            object valor = ordenador[posicion];
            posicion++;
            return valor;
        }
    }
}
