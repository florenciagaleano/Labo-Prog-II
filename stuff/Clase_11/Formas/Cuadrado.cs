using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public sealed class Cuadrado : Figura
    {
        double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public override double CalcularSuperficie()
        {
            return this.lado * this.lado;
        }

        public override double CalcularPerimetro()
        {
            return this.lado * 4;
        }

        public override string Dibujar()
        {
            return "Dibujando un cuadrado";
        }
    }
}
