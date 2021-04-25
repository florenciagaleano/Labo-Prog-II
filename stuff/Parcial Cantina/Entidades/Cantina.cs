using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;

        /*El único constructor será privado y se encargará tanto de inicializar la lista como de asignar la cantidad de espacios disponibles para guardar botellas.*/
        private Cantina(int espacios)
        {
            this.botellas = new List<Botella>();
            this.espaciosTotales = espacios;
        }

        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }

        public static Cantina GetCantina(int espacios)
        {
            if(Cantina.singleton is null)
            {
                Cantina.singleton = new Cantina(espacios);
            }else
            {
                Cantina.singleton.espaciosTotales = espacios;
            }

            return Cantina.singleton;
        }

        /*El operador + agregará, siempre y cuando aún no se hayan ocupado todos los espacios disponibles, retornando true si agregó y false en caso contrario.*/
        public static bool operator +(Cantina c, Botella b)
        {
            if(c.botellas.Count < c.espaciosTotales)
            {
                c.botellas.Add(b);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
