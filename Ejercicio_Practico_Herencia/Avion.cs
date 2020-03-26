using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Practico_Herencia
{
    class Avion : Vehiculo
    {

        public void Aterrizar()
        {
            Console.WriteLine("El avion esta aterrizando");
        }

        public void Despegar()
        {
            Console.WriteLine("El avion esta despegando");
        }
    }
}
