using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class DelanteDecorador : MotocicletaDecorador
    {
        public DelanteDecorador(IMotocicletaAbstracta motocicletaAbstracta) : base(motocicletaAbstracta) { }
        public override void Acelerar()
        {
            Console.WriteLine("|");
            _MotocicletaAbstracta.Acelerar();
            Console.WriteLine("|");
        }
    }
}
