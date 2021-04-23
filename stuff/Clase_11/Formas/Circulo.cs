using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public sealed class Circulo : Figura
    {
        double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double CalcularSuperficie()
        {
            return radio * radio * 3.14;
        }

        public override double CalcularPerimetro()
        {
            return 2 * 3.14 * radio;
        }

        public override string Dibujar()
        {
            return "Dibujando un circulo";
        }
    }
}
