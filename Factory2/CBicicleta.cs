using System;

namespace Factory2
{
    class CBicicleta : IVehiculo
    {
        public void Encender ()
        {
            Console.WriteLine("Las Bicis no necesitan encendido");
        }

        public void Acelerar()
        {
            Console.WriteLine("Pedalea fuerte para acelerar");
        }

        public void Frenar()
        {
            Console.WriteLine("Presiona el freno trasero primero");
        }

        public void Girar()
        {
            Console.WriteLine("Usa el manubrio");
        }
    }
}
