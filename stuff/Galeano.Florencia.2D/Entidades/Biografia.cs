using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biografia : Publicacion
    {
        /// <summary>
        /// Asigna un nombre al atributo nombre de Biografica
        /// </summary>
        /// <param name="nombre">nombre que se asignara</param>
        public Biografia(string nombre)
            :base(nombre)
        {
            
        }

        /// <summary>
        /// Asigna un nombre y el stock a losmismos atributos de Biografia
        /// </summary>
        /// <param name="nombre">nombre a asignar</param>
        /// <param name="stock">stock a asignar</param>
        public Biografia(string nombre, int stock)
            :base(nombre,stock)
        {
   
        }

        /// <summary>
        /// Asigna nombre, stock e importe a los atributos de la clase Biografia
        /// </summary>
        /// <param name="nombre">nombre a asigna</param>
        /// <param name="stock">stock a asignar</param>
        /// <param name="importe">importe a asignar</param>
        public Biografia(string nombre, int stock, float importe)
            :base(nombre,stock,importe)
        {

        }

        /// <summary>
        /// Propiedad de solo lectura que retorna false
        /// </summary>
        protected override bool EsColor
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura que retorna true si el stock es mayor a 0 y sino false
        /// </summary>
        public override bool HayStock
        {
            get
            {
                return base.Stock > 0;
            }
        }

        /// <summary>
        /// Metodos que retorna un nuevo objeto de tipo Biografia
        /// </summary>
        /// <param name="nombre">nombre que se le asignara al atributo nombre de la nueva biografia</param>
        public static explicit operator Biografia(string nombre)
        {
            Biografia b= new Biografia(nombre);
            b.Stock += 1;
            return b;
        }
    }
}
