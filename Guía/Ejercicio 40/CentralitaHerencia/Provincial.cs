using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//i.Heredará de Llamada
//j. Método Mostrar expondrá, además de los atributos de la clase base, la propiedad
//CostoLlamada y franjaHoraria. Utilizar StringBuilder.
//k. CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo
//de la misma. Los valores serán: Franja_1: 0.99, Franja_2: 1.25 y Franja_3: 0.66.

namespace CentralitaHerencia
{
    public class Provincial:Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        Franja franjaHoraria;
 
        #region Constructores
        public Provincial(Franja miFranja,Llamada llamada)
            :this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        {

        }

        public Provincial(string origen,Franja miFranja,float duracion,string destino)
            :base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }

        #endregion

        #region Propiedades
        public override float CostoLlamada
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
            float num = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    num = (float)0.99 * base.duracion;
                    break;
                case Franja.Franja_2:
                    num = (float)1.25 * base.duracion;
                    break;
                case Franja.Franja_3:
                    num = (float)0.66 * base.duracion;
                    break;
                default:
                    break;
            }
            return num;
        }

        public string Mostrar()
        {
            return base.Mostrar() + $"  Costo llamada: {CostoLlamada}  Franja horaria: {this.franjaHoraria}";
        }
        #endregion

        #region Sobrecargas
        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

    }
}
