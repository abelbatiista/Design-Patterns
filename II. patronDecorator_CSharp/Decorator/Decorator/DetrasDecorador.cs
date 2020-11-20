using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class DetrasDecorador : MotocicletaDecorador
    {
        public DetrasDecorador(IMotocicletaAbstracta motocicletaAbstracta) : base(motocicletaAbstracta) { }
        public override void Acelerar()
        {
            _MotocicletaAbstracta.Acelerar(); 
            Console.WriteLine("[HACIA ATRÁS]");
        }
    }
}
