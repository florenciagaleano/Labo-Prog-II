using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        /// <summary>
        /// Constructor de vendedor, inicializa lista de publicaciones vendidad
        /// </summary>
        private Vendedor()
        {
            this.ventas = new List<Publicacion>();
        }

        /// <summary>
        /// constructor de vendedor
        /// </summary>
        /// <param name="nombre"></param>
        public Vendedor(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Constructor de vendedor
        /// </summary>
        /// <param name="v"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator +(Vendedor v,Publicacion p)
        {
            if(p.HayStock)//here
            {
                v.ventas.Add(p);
                p.Stock--;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Retorna una cadena con los datos del vendedor y sus ventas
        /// </summary>
        /// <param name="v">Vendedor cuyos datos se retornaran</param>
        /// <returns>Cadena con los datos del vendedor</returns>
        public static string InformeDeVentas(Vendedor v)
        {
            StringBuilder sb = new StringBuilder();
            float acumulador = 0;

            sb.AppendLine(v.nombre);
            sb.AppendLine();//para que quede un espacio
            foreach (Publicacion item in v.ventas)
            {
                sb.AppendLine(item.Informacion());
                sb.AppendLine("------------------------------------------");
                acumulador += item.Importe;
            }
            sb.AppendLine($"Ganancia Total: ${acumulador}");

            return sb.ToString();
        }
    }
}
