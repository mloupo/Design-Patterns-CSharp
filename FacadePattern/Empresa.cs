using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Empresa
    {
        public Queja q;
        public Pedido p;

        public Empresa()
        {
            q = new Queja();
            p = new Pedido();
        }

        private string Quejas(Comprador comprador)
        {
            return q.Quejas(comprador);
        }
        private string Quejas(Comercial comercial)
        {
            return q.Quejas(comercial);
        }
        private string Quejas(Desarrollador desarrollador)
        {
            return q.Quejas(desarrollador);
        }

        public void EscucharQuejas(Persona p)
        {
            if (p is Comprador)
                Quejas((Comprador)p);
            else if (p is Comercial)
                Quejas((Comercial)p);
            else if (p is Desarrollador)
                Quejas((Desarrollador)p);
        }

        public int HacerPedido(Comercial comercial, Comprador cliente)
        {
            return p.comisionPedido(comercial)+ p.precioProducto(cliente);
        }

    }
}
