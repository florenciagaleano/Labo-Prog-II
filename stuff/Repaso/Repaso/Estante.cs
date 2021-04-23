using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
        private int ubicacion;
        Producto[] productos;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad,int ubicacion) :this(capacidad)
        {
            this.ubicacion = ubicacion;
        }

        /*El método público de clase MostrarEstante, retornará una cadena con toda la información del estante, incluyendo el
        detalle de cada uno de sus productos. Reutilizar código. SIEMPRE QUE DIGA DE CLASE ES ESTATICO*/
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto p in e.productos)
            {
                if(!object.ReferenceEquals(p,null))//si item no es null dice
                {
                    sb.Append(Producto.MostrarProducto(p));
                    sb.Append("\n");
                }
            }

            return sb.ToString();
        }

        /*Sobrecarga de operadores:
        Igualdad, retornará true, si es que el producto ya se encuentra en el estante, false, caso contrario.*/
        public static bool operator ==(Estante e,Producto p)
        {
            foreach (Producto producto in e.productos)
            {
                if(p == producto)
                {
                    return true;
                    break;
                }
            }

            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        /*Adición, retornará true y agregará el producto si el estante posee capacidad de almacenar al menos un producto más y
        dicho producto no se encuentra en él; false, caso contrario. Reutilizar código.
        Sustracción (Estante, Producto), retornará un estante sin el producto, siempre y cuando el producto se encuentre en el
        listado. Reutilizar código.*/

        public static bool operator + (Estante e,Producto p)
        {
            if(e!=p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }

            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            for(int i=0; i<e.productos.Length; i++)
            {
                if(e.productos[i] == p)
                {
                    e.productos[i] = null;
                }
            }

            return e;
        }
    }
}
