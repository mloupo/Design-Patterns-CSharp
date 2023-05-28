using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Componente<T> :IComponente<T>
    {
        public T Nombre { get; set; }   
        public Componente (T pNombre)
        {
            Nombre = pNombre;
        }
        public void Adicionar (IComponente<T> pElemento)
        {
            Console.WriteLine("Solo se adiciona a los compuestos, no a los componentes");
        }

        public IComponente<T> Borrar(T pElemento)
        {
            Console.WriteLine("No se puede eliminar directamente");
            return this;
        }
        public IComponente<T> Buscar(T pElemento)
        {
            if (pElemento.Equals(Nombre))
                return this;
            else
                return null;
        }

        public string Mostrar(int pProfundidad)
        {
            //Colocamos la cantidad de "-" segun la profundidad
            return new String('-', pProfundidad) + Nombre + "\n\r";
        }
    }
}
