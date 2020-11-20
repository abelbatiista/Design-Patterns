using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class MotocicletaDecorador : IMotocicletaAbstracta
    {
        public MotocicletaDecorador(IMotocicletaAbstracta motocicletaAbstracta)
        {
            _MotocicletaAbstracta = motocicletaAbstracta;
        }

        protected IMotocicletaAbstracta _MotocicletaAbstracta;
        public abstract void Acelerar();
    }
}
