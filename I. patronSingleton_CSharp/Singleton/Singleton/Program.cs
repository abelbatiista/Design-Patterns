using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ciclo = true;
            while (ciclo)
            {
                Console.Clear();
                Console.WriteLine("¿Desea observar la demostración de ejemplo? 1 => Aceptar & 0 => Declinar");
                string decision = Console.ReadLine();
                if (decision == "1")
                {
                    Prueba.Probando();
                    Console.WriteLine("¡Perfecto!\nPresione cualquier tecla para continuar.");
                    Console.ReadKey();
                    ciclo = false;
                }
                else if (decision == "0")
                {
                    Console.WriteLine("¡Perfecto!\nPresione cualquier tecla para continuar.");
                    Console.ReadKey();
                    ciclo = false;
                }
                else
                {
                    Console.WriteLine("No ha seguido instrucciones.\nPresione cualquier tecla para continuar.");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            Ejemplo.Ejemplificación();

        }
    }
}
