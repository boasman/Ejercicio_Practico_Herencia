using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Practico_Herencia
{
    class Coche : Vehiculo
    {
        

        public void Acelerar()
        {
            Console.WriteLine("Acelerando");
        }
        public void Frenar()
        {
            Console.WriteLine("Frenando");
        }
    }
}
