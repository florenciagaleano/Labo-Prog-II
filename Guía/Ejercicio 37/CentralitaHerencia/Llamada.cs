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
    public class Llamada
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
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Duracion: {this.duracion}  Nro destino: {this.nroDestino}  Nro origen: {this.nroOrigen}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return (int)(llamada1.duracion - llamada2.duracion);
        }

        #endregion
    }
}
