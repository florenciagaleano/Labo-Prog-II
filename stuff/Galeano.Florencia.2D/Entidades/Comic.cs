using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comic : Publicacion
    {
        private bool esColor;

        /// <summary>
        /// Constructor de Comic
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="esColor"></param>
        /// <param name="stock"></param>
        /// <param name="valor"></param>
        public Comic(string nombre, bool esColor,int stock, float valor)
            :base(nombre,stock,valor)
        {
            this.esColor = esColor;
        }

        /// <summary>
        /// Propiedad de solo lectura que retorna el valor del atributo 
        /// </summary>
        protected override bool EsColor
        {
            get
            {
                return this.esColor;
            }
        }
    }
}
