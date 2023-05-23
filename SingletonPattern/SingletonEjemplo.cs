using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonEjemplo
    {
        private static SingletonEjemplo singleton = null;
        public string texto = String.Empty;
        public int numero = -1;
        public SingletonEjemplo(string valor)
        {
            texto = valor;
            numero = 2;
        }

        public static SingletonEjemplo Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = new SingletonEjemplo("Creado");
                return singleton;
            } 
            set => singleton = value; 
        }
    }
}
