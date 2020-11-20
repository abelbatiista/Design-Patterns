using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Prueba
    {
        public static void Probando()
        {
            /*Este patrón de diseño expresa que, solo podemos crear una instancia de una clase, es decir que, la clase solo tendrá un objeto.
             A sabiendas de esto, debemos comprender que por tanto, las modificaciones a los atributos del objeto serán, recicladas.*/

            //Creación del objeto "object1".
            Singleton object1 = Singleton.Instance;

            //Creación del objeto "object2".
            Singleton object2 = Singleton.Instance;

            //Cada objeto tiene acceso al atributo "name", a través del cual, podrá identificar su nombre.

            object1.name = "Objeto1";
            Console.WriteLine(object1.name + "-. Aquí se muestra el valor puesto por el primer objeto.");
            object2.name = "Objeto2";
            Console.WriteLine(object2.name + "-. Aquí se muestra el valor puesto por el segundo objeto.");

            //Con una impresión por consola (Console.WriteLine()), podemos verificar que:
            //  el atributo "name", es uno solo, y no dos. Por lo que, el nombre final de ambos objetos, será "Objeto2".

            Console.WriteLine(object1.name + " " + object2.name + "-. Aquí se muestra que se tomó el último valor puesto para ambos." + "\n");

            //Por lo que, no es necesario crear más de un objeto en la clase Singleton, ya que, tan solo UNO tiene acceso a modificar los atributos.
        }
    }
}
