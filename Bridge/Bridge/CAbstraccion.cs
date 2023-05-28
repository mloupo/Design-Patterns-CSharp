using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class CAbstraccion
    {
        //referencia a la implementacion
        IBridge implementacion;
        Dictionary<string, double> productos;

        //Metodo 1, el mas usual
        //Costructor, recibimos la implementacion concreta
        public CAbstraccion (IBridge pImp, Dictionary<string, double> pProd)
        {
            implementacion = pImp;
            productos = pProd;
        }
        //Metodo 2, no deseamos hacer una fabrica
        public CAbstraccion(int pTipo, Dictionary<string, double> pProd)
        {
            if (pTipo == 1)
                implementacion = new CImplementacion1();
            if (pTipo == 2)
                implementacion = new CImplementacion2();
            if (pTipo == 3)
                implementacion = new CImplementacion3();
            productos= pProd;
        }

        //estos metodos representan la interfaz que conoce el cliente

        public void MostrarTotales()
        {
            implementacion.MostrarTotales(productos);
        }

        public void Listar()
        {
            implementacion.ListarProductos(productos);
        }
    }
}
