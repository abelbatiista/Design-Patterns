using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esta será una ejemplificación del Patrón de Diseño "Decorador", en que mostraremos su funcionalidad a través de la consola.

            DetrasDecorador motocicletaHaciaDetras = new DetrasDecorador(new Motocicleta());
            DelanteDecorador motocicletaHaciaDelanteYHaciaDetras = new DelanteDecorador(motocicletaHaciaDetras);
            motocicletaHaciaDelanteYHaciaDetras.Acelerar();
            Console.WriteLine();

            DelanteDecorador motocicletaHaciaDelante = new DelanteDecorador(new Motocicleta());
            motocicletaHaciaDelante.Acelerar();
            Console.WriteLine();

            DelanteDecorador motocicletaMuyHaciaDelante = new DelanteDecorador(motocicletaHaciaDelante);
            motocicletaMuyHaciaDelante.Acelerar();
            Console.WriteLine();

            DelanteDecorador motocicletaMuyHaciaDelanteYHaciaDetras = new DelanteDecorador(new DelanteDecorador(motocicletaHaciaDetras));
            motocicletaMuyHaciaDelanteYHaciaDetras.Acelerar();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
