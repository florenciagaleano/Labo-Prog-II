using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*La clase Punto ha de tener dos atributos privados con acceso de sólo lectura (sólo con
getters), que serán las coordenadas del punto. También un constructor que reciba los
parámetros x e y.*/

namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }

        /*Los atributos área (base * altura) y perímetro ((base + altura)*2) se deberán calcular sólo
        una vez, al llamar por primera vez a su correspondiente método getter (GetArea y
        GetPerimetro de la clase Rectángulo creados en el punto anterior). Luego, cada vez que se
        invoque a los métodos Area y Perimetro, se deberá retornar siempre el valor calculado
        anteriormente.*/


    }
}
