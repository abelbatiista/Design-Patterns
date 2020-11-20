using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Ejemplo
    {
        //Aquí mostraremos un ejemplo un poco más práctico.

        //El ejemplo consistirá en una tabla de productos, donde los valores se encontrarán dentro de los atributos.
        public static void Ejemplificación()
        {
            Singleton objectSingleton = Singleton.Instance;
            Show(objectSingleton);
            Console.WriteLine("Aquí podremos apreciar que la tabla muestra los valores puestos en el método constructor de la función. Ahora bien, si cambiamos los valores, podremos apreciar.");
            Console.ReadKey();
            Console.Clear();
            //Aquí podremos apreciar que la tabla muestra los valores puestos en el método constructor de la función. Ahora bien, si cambiamos los valores, podremos apreciar.

            objectSingleton.ProductName = "Almohada";
            objectSingleton.ProductPrice = 85.50;
            objectSingleton.ProductQuantity = 18;
            Show(objectSingleton);
            Console.WriteLine("Aquí podemos notar el cambio DENTRO de los valores de los atributos de la clase, utilizando el mismo objeto.");
            Console.ReadKey();
            Console.Clear();
            //Aquí podemos notar el cambio DENTRO de los valores de los atributos de la clase, utilizando el mismo objeto.

            //Ahora trate usted de cambiar los valores...
            Console.WriteLine("Ahora trate usted de cambiar los valores...\n");
            Console.ReadKey();
            Console.Write("Name: ");
            objectSingleton.ProductName = Console.ReadLine();
            Console.Write("Price: ");
            objectSingleton.ProductPrice = CatchingDoubleError(Console.ReadLine());
            Console.Write("Quantity: ");
            objectSingleton.ProductQuantity = CatchingIntError(Console.ReadLine());
            Console.Clear();
            Show(objectSingleton);
            Console.WriteLine("Aquí podemos apreciar sus valores.");
            Console.ReadKey();
            Console.Clear();


        }

        private static void Show(Singleton objectSingleton)
        {
            Console.WriteLine(
                    "************\n**Products**\n************" +
                    $"\nName: {objectSingleton.ProductName}\nPrice: {objectSingleton.ProductPrice}\nQuantity: {objectSingleton.ProductQuantity}\n"
                );
        }

        public static int CatchingIntError(string parameter)
        {
            int number;
            try
            {
                number = int.Parse(parameter);
                return number;
            }
            catch
            {
                Console.WriteLine("The variable was not INT.");
                return 0;
            }
        }

        public static double CatchingDoubleError(string parameter)
        {
            double number;
            try
            {
                number = double.Parse(parameter);
                return number;
            }
            catch
            {
                Console.WriteLine("The variable was not DOUBLE.");
                return 0;
            }
        }
    }
}
