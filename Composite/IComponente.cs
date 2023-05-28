using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal interface IComponente<T>
    {
        T Nombre { get; set; }
        void Adicionar(IComponente<T> pElemento);
        IComponente<T> Borrar(T pElemento);
        IComponente<T> Buscar(T pElemento);
        string Mostrar(int pProfundidad);
    }
}
