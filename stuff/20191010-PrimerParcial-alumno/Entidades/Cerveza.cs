using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        private Botella.Tipo tipo;

        public Cerveza(int capacidadML, string marca, int contenidoML)
            : this(capacidadML, marca,Botella.Tipo.Vidrio, contenidoML)
        {

        }

        public Cerveza(int capacidadML, string marca,Tipo tipo, int contenidoML)
            : base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }

        //c.ServirMedida gastará unidades de contenido con la misma lógica que agua, sólo que servirá el 80% del valor indicado en la variable MEDIDA, para dejar espacio para la espuma.
//d.GenerarInforme utilizará StringBuilder para retornar todos los datos de la botella de cerveza.

        public override int ServirMedida()
        {
            int loQueSeSirve;
            if (MEDIDA <= this.contenidoML)
            {
                loQueSeSirve = (MEDIDA * 8) /100;
            }
            else
            {
                loQueSeSirve = this.Contenido;
            }

            this.Contenido -= loQueSeSirve;

            return this.Contenido;
        }

        protected new string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.ToString()} ");
            sb.Append(MEDIDA);
            return this.ToString();
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
    }
}
