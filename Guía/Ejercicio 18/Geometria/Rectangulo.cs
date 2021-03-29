using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*La clase Rectangulo tiene los atributos de tipo Punto vertice1, vertice2, vertice3 y vertice4
(que corresponden a los cuatro vértices del rectángulo).
c. La base de todos los rectángulos de esta clase será siempre horizontal. Por lo tanto, debe
tener un constructor para construir el rectángulo por medio de los vértices 1 y 3 (utilizar el
método Abs de la clase Math, dicho método retorna el valor absoluto de un número, para
obtener la distancia entre puntos). PREGUNTAR constructores estaticos ¿¿?¿?¿*/

namespace Geometria
{
    public class Rectangulo
    {
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        private float perimetro;
        private float area;

        public Rectangulo(Punto v1,Punto v3)
        {
            this.vertice1 = v1;
            this.vertice3 = v3;
            this.vertice2 = new Punto(v1.GetX(),v3.GetY());
            this.vertice4 = new Punto(v3.GetX(), v1.GetY());
            this.area = Math.Abs(vertice1.GetX() - vertice3.GetX()) * Math.Abs(vertice1.GetY() - vertice3.GetY());
            this.perimetro = (Math.Abs(vertice1.GetX() - vertice3.GetX()) + Math.Abs(vertice1.GetY() - vertice3.GetY())) * 2;
        }

        //Realizar los métodos getters para los atributos privados área y perímetro
        public float GetArea()
        {
            return this.area;
        }

        public float GetPerimetro()
        {
            return this.perimetro;
        }


    }
}
