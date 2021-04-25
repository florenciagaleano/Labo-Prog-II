using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//e.Heredará de Llamada.
//f. Método Mostrar expondrá, además de los atributos de la clase base, la propiedad
//CostoLlamada. Utilizar StringBuilder.
//g. CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo
//de la misma.
//h. La propiedad CostoLlamada retornará el precio, que se calculará en el método
//CalcularCosto.

namespace CentralitaHerencia
{
    public class Local:Llamada
    {
        private float costo;

        #region Constructores
        public Local(Llamada llamada,float costo)
            :this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
            
        }

        public Local(string origen,float duracion, string destino,float costo)
            :base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        #endregion

        #region Propiedades
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }

        public string Mostrar()
        {
            return base.Mostrar() + $"Costo llamada: {this.costo}";
        }
        #endregion


    }
}
