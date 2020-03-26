using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Practico_Herencia
{
    class Vehiculo
    {

        public void ArrancarMotor(string SonidoAlArrancar)
        {
            Console.WriteLine($"Arranca el motor: {SonidoAlArrancar}");
        }

        public void PararMotor(string sonidoAlParar)
        {
            Console.WriteLine($"Sonido al parar {sonidoAlParar}");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Este es el codigo generico para el metodo conducir");
        }
    }
}
