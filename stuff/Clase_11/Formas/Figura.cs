using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5. Método CalcularPerimetro:
//a.Deberá ser implementado de manera obligatoria por las clases derivadas.
//b. Debe devolver un double con el resultado del cálculo del perímetro para la figura en particular.
//6. En el método Main:
//a.Crear una lista de figuras.
//b. Agregar a la lista una figura de cada tipo.
//c. Recorrer la lista mostrando el resultado del método Dibujar, el área y el perímetro de cada figura
//(con una precisión de 2 decimales), y el tipo (GetType()).

namespace Formas
{
    public abstract class Figura
    {
        public virtual string Dibujar()
        {
            return "Dibujando forma...";
        }

        public abstract double CalcularSuperficie();
        public abstract double CalcularPerimetro();

    }
}
