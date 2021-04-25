using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua:Botella
    {
        //Clase Agua:
        //a.MEDIDA será una constante con el valor 400.
        //b.ServirMedida gastará unidades de contenido con la siguiente lógica:
        //i.Si la constante MEDIDA es menor o igual al contenido, gastará MEDIDA.
        //ii.Si MEDIDA es mayor al contenido, tomará contenido.
        //c.Generar una sobrecarga que reciba una cantidad a gastar que pueda ser diferente de MEDIDA.No repetir código.
        //d.GenerarInforme utilizará StringBuilder para retornar todos los datos de la botella de agua.

        private const int MEDIDA = 400;

        public Agua(int capacidadML, string marca,int contenidoML)
            :base(marca,capacidadML,contenidoML)
        {

        }

        public override int ServirMedida()
        {
            int loQueSeSirve;
            if(MEDIDA <= this.contenidoML)
            {
                loQueSeSirve = MEDIDA;
            }else
            {
                loQueSeSirve = this.Contenido;
            }

            this.Contenido -= loQueSeSirve;

            return this.Contenido;
        }
        //i.Si la constante MEDIDA es menor o igual al contenido, gastará MEDIDA.
        //ii.Si MEDIDA es mayor al contenido, tomará contenido.
        //c.Generar una sobrecarga que reciba una cantidad a gastar que pueda ser diferente de MEDIDA.No repetir código.
        //d.GenerarInforme utilizará StringBuilder para retornar todos los datos de la botella de agua.
       protected new string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.ToString()} ");
            sb.Append(MEDIDA);
            return this.ToString();
        }

    }
}
