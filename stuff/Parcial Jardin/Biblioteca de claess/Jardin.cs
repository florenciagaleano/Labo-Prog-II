using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_claess
{
    public class Jardin
    {
        public enum Tipo
        {
            Terrozo, Arenoso
        }

        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;

        #region Constructores
        static Jardin()
        {
            suelo = Tipo.Terrozo;
        }

        private Jardin()
        {
            this.plantas = new List<Planta>();
        }

        public Jardin(int espacioTotal)
            :this()
        {
            this.espacioTotal = espacioTotal;
        }

        #endregion

        #region Propiedades

        public Tipo TipoSuelo
        {
            set
            {
                suelo = value;
            }
        }
        #endregion

        #region Metodos
        private int EspacioOcupado()
        {
            int acumulador = 0;
            foreach (Planta item in this.plantas)
            {
                acumulador += item.Tamanio;
            }
            return acumulador;
        }

        private int EspacioOcupado(Planta planta)
        {
            return this.EspacioOcupado() + planta.Tamanio;
        }

        #endregion

        #region Sobrecargar

        public static bool operator +(Jardin jardin, Planta planta)
        {
            if(jardin.espacioTotal >= jardin.EspacioOcupado(planta))
            {
                jardin.plantas.Add(planta);
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Composicion del jardin: {suelo}");
            //Espacio ocupado XXX de XXX
            sb.AppendLine($"Espacio ocupado {this.EspacioOcupado()}");
            sb.AppendLine("Plantas:");
            foreach(Planta p in this.plantas)
            {
                if(p is Rosal)
                {
                    sb.AppendLine(((Rosal)p).ResumenDeDatos());
                }else if(p is Banano)
                {
                    sb.AppendLine(((Banano)p).ResumenDeDatos());
                }
                else
                {
                    sb.AppendLine(p.ResumenDeDatos());
                }
            }

            return sb.ToString();
        }

        #endregion

    }


}
