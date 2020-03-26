using System;

namespace Ejercicio_Practico_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probando el avion");

            Avion miavion = new Avion();

            miavion.ArrancarMotor("Brrummm Brummm");

            miavion.Despegar();

            miavion.Conducir();

            miavion.Aterrizar();

            miavion.PararMotor("Plooooof");

            Console.WriteLine();

            Console.WriteLine("Probando el coche");

            Coche micoche = new Coche();

           

           

            micoche.ArrancarMotor("grummm grummm");

            micoche.Acelerar();

            micoche.Conducir();

            micoche.Frenar();

            micoche.PararMotor("Chuiiiiii");
            
        }
    }
   
    
}
