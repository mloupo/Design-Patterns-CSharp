using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class CProxy
    {
        public interface ISujeto
        {
            void Peticion(int pOpcion);
        }

        public class ProxySencillo : ISujeto
        {
            private CCocina cocina;
            public void Peticion(int pOpcion)
            {
                if (cocina == null)
                {
                    Console.WriteLine("Activando al Sujeto");
                    cocina = new CCocina();
                }
                if (pOpcion == 1)
                    cocina.RecetaSecreta();
                if (pOpcion == 2)
                    cocina.Cocinar(5);
            }
        }

        public class ProxySeguro:ISujeto
        {
            private CCocina cocina;

            public void Peticion(int pOpcion)
            {
                string password;
                Console.WriteLine("Ingrese Password: ");
                password = Console.ReadLine();
                if (password == "abc123")
                {
                    if (cocina == null)
                    {
                        Console.WriteLine("Activando al Sujeto");
                        cocina = new CCocina();
                    }
                    if (pOpcion == 1)
                        cocina.RecetaSecreta();
                    if (pOpcion == 2)
                        cocina.Cocinar(5);
                }
                else
                {
                    Console.WriteLine("Acceso Denegado");
                }
            }
        }
        
        private class CCocina
        {
            public void RecetaSecreta()
            {
                Console.WriteLine("Pan");
                Console.WriteLine("ACeite de Oliva");
                Console.WriteLine("Especias");
                Console.WriteLine("Queso");
                Console.WriteLine("Champignones");
            }
            public void Cocinar(int n)
            {
                Console.WriteLine("Cocinando {0} recetas", n);
            }
        }
    }
}
