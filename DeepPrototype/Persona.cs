using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepPrototype
{
    class Persona:ICloneable
    {
        int altura;
        int peso;

        DetallePersona detalle= new DetallePersona();

        public int Altura { get => altura; set => altura = value; }
        public int Peso { get => peso; set => peso = value; }
        internal DetallePersona Detalle { get => detalle; set => detalle = value; }
        
        private object CopiaSuperficial()
        {
            return this.MemberwiseClone();
        }

        public object CopiaProfunda()
        {
            Persona clon = this.MemberwiseClone() as Persona;
            clon.detalle= new DetallePersona();

            clon.detalle.ColorOjos = this.detalle.ColorOjos;
            clon.detalle.EstaCalvo = this.detalle.EstaCalvo;

            return clon;
        }

        public object Clone()
        {
            return CopiaProfunda();
        }
    }

    class DetallePersona
    {
        string colorOjos;
        bool estaCalvo;

        public string ColorOjos { get => colorOjos; set => colorOjos = value; }
        public bool EstaCalvo { get => estaCalvo; set => estaCalvo = value; }
    }
}
