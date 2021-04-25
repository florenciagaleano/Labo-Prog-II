using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Clase Botella:
//a.Será abstracta.
//b.Tanto la capacidad como el contenido están expresados en mililitros.
//c.Tendrá un único constructor, en el cual se validará que si la capacidad es menor al contenido, el contenido será reemplazado por la por la variable de capacidad.Así nunca se podrá tener más contenido en una botella que la capacidad que ésta es capaz de guardar.
//d.La propiedad CapacidadLitros retornará la capacidad convertida a litros (dividir por 1000).
//e.Utilizar regla de 3 simple para retornar el valor de la propiedad PorcentajeContenido.
//f. ServirMedida será abstracto.
//g. GenerarInforme utilizará StringBuilder para retornar todos los datos de la botella.
//h. ToString retornará GenerarInforme.

namespace Entidades
{
    public abstract class Botella
    {
        public enum Tipo
        {
            Plastico, Vidrio
        }

        #region Atributos
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        /*100 -> capacidad
            X -> contenido*/
        #endregion

        #region Constructores
        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.marca = marca;
            this.capacidadML = capacidadML;
            if(capacidadML < contenidoML)
            {
                this.contenidoML = capacidadML;
            }else
            {
                this.contenidoML = contenidoML;
            }
        }
        #endregion

        #region Propiedades
        public int CapacidadLitros
        {
            get
            {
                return this.capacidadML / 1000;
            }

        }

        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }

        float PorcentajeContenido
        {
            get
            {
                return (this.contenidoML * this.capacidadML) / 100;
            }
        }
        #endregion

        #region Metodos
        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.marca} ");
            sb.Append($"{this.capacidadML} ");
            sb.Append($"{this.contenidoML} ");
            sb.Append($"{this.CapacidadLitros} ");
            sb.Append($"{this.PorcentajeContenido} ");

            return sb.ToString();
        }

        public abstract int ServirMedida();

        public override string ToString()
        {
            return GenerarInforme();
        }

        #endregion
    }
}
