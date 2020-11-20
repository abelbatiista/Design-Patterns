using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Motocicleta : IMotocicletaAbstracta
    {
        public void Acelerar()
        {
            Console.WriteLine("Motocicleta");
        }
    }
}
