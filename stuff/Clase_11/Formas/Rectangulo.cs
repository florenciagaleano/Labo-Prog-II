using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Rectangulo : Figura
    {
        private double ancho;
        private double altura;

        public Rectangulo(double ancho, double altura)
        {
            this.ancho = ancho;
            this.altura = altura;
        }

        public override double CalcularSuperficie()
        {
            return ancho * altura;
        }

        public override double CalcularPerimetro()
        {
            return ancho * 2 + altura * 2;
        }

        public override string Dibujar()
        {
            return "Dibujando un rectangulo";
        }
    }
}
