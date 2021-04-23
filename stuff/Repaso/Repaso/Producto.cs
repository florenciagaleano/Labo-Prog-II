using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Todos sus atributos son privados. Posee sólo un constructor de instancia. El método GetMarca, retornará el valor
correspondiente del atributo marca : string. El método GetPrecio, retornará el valor asociado al atributo precio : float.
También poseerá el atributo codigoDeBarras : string, el cual se publicará sólo a través de la conversión explísita nombrada
más adelante.
El método de clase (estático) MostrarProducto(Producto), es público y retornará una cadena detallando los atributos de la
clase.*/

namespace Repaso
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Código de barras:{p.codigoDeBarra}");
            sb.Append($"  Marca:{p.marca}");
            sb.Append($"  Precio:{p.precio}");

            return sb.ToString();
        }

        /*La clase Producto posee sobrecarga de operadores:
        Explícito. Realizará la conversión de un objeto Producto a string. Sólo retornará el atributo codigoDeBarras del producto.*/
        public  static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }


        /*Igualdad(Producto, Producto). Retornará true, si las marcas y códigos de barras son iguales, false, caso contrario.
       Igualdad(Producto, string). Retornará true, si la marca del producto coincide con la cadena pasada por parámetro, false,
      caso contrario.*/

        /*public static bool operator ==(Producto p1,Producto p2)
        {
            if(p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }*/
         public static bool operator ==(Producto p1, Producto p2)
        {
            if (!(p1 is null || p2 is null))
            {
                return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
            }
            return false;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, string auxStr)
        {
            return p.codigoDeBarra == auxStr;
        }
        public static bool operator !=(Producto p, string auxStr)
        {
            return !(p == auxStr);
        }

    }
}
