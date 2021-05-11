using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        public Publicacion(string nombre)
        {
            this.nombre = nombre;            
        }
        public Publicacion(string nombre, int stock)
            :this(nombre)
        {
            this.Stock = stock;
        }
        public Publicacion(string nombre, int stock, float importe)
            :this(nombre,stock)
        {
            this.importe = importe;
        }

        protected abstract bool EsColor { get; }

        public virtual bool HayStock
        {
            get
            {
                if(this.importe > 0 && this.stock > 0)
                {
                    return true;
                }else
                {
                    return false;
                }
            }
        }

        public float Importe
        {
            get
            {
                return this.importe;
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }set
            { 
                if(value >= 0)
                {
                    this.stock = value;
                }
            }
        }

        public override string ToString()
        {
            return this.nombre;
        }

        /// <summary>
        /// Devuelve una cadena con toda la informacion de un publicacion
        /// </summary>
        /// <returns>cadena con toda la informacion</returns>
        public string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0}", this.nombre);
            sb.Append($"\nStock: {this.Stock}\n");
            if(!this.EsColor)//here
            {
                sb.AppendLine("Tiene color: NO");
            }else
            {
                sb.AppendLine("Tiene color: SI");

            }

            sb.AppendLine($"Importe: ${this.importe}");

            return sb.ToString().ToUpper();
        }
    }
}
