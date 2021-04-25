using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//b.La clase Llamada, tendrá todos sus atributos con el modificador protected. Crear las
//propiedades de sólo lectura para exponer estos atributos.
//c. OrdenarPorDuracion es un método de clase que recibirá dos Llamadas. Se utilizará para
//ordenar una lista de llamadas de forma ascendente.
//d. Mostrar es un método de instancia. Utiliza StringBuilder.

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #region Constructores
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region Propiedades
        public abstract float CostoLlamada { get; }
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroDestino;
            }
        }

        #endregion

        #region Metodos
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.duracion}  {this.nroDestino}  {this.nroOrigen}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return (int)(llamada1.duracion - llamada2.duracion);
        }

        #endregion

        #region sobrecarga
        //El operador == comparará dos llamadas y retornará true si las llamadas son del mismo tipo
        //(utilizar método Equals, sobrescrito en las clases derivadas) y los números de destino y
        //origen son iguales en ambas llamadas.
        public static bool operator ==(Llamada l1,Llamada l2)
        {
            if(l1.nroDestino == l2.nroDestino)
            {
                return l1.Equals(l2);
            }

            return false;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1==l2);
        }
        #endregion
    }
}
