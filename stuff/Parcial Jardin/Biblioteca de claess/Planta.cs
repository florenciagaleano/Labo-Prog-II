using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_claess
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;

        public Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }

        public int Tamanio
        {
            get
            {
                return this.tamanio;
            }
        }

        public abstract bool TieneFlores{ get; }
        public abstract bool TieneFrutos { get; }

        //a.Los métodos y propiedades marcados en cursiva son abstractos.
        //b.ResumenDeDatos retornará los datos de la Planta utilizando StringBuilder y String.Format.
        //Completar las palabras en mayúscula con los datos de cada planta según corresponda:
        //NOMBRE tiene un tamaño de TAMANIO
        //Tiene flores SI/NO
        //Tiene fruto SI/NO
        public virtual string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Nombre:{0}  Tamaño;{1}", this.nombre, this.Tamanio));

            if(this.TieneFlores)
                sb.AppendLine(string.Format("Tiene flores: {0}", "SI"));
            else
                sb.AppendLine(string.Format("Tiene flores: {0}", "NO"));

            if (this.TieneFrutos)
                sb.AppendLine(string.Format("Tiene fruto: {0}", "SI"));
            else
                sb.AppendLine(string.Format("Tiene fruto: {0}", "NO"));

            return sb.ToString();
        }
    }
}
