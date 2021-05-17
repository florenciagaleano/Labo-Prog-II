using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30_36_46_49
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1(short numero,string escuderia)
            :base(numero,escuderia)
        {

        }

        public AutoF1(short numero,string escuderia,short caballosDeFuera)
            :this(numero,escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }set
            {
                this.caballosDeFuerza = value;
            }
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if(a1 == a2 && a1.CaballosDeFuerza ==a2.CaballosDeFuerza)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Caballos de fuerza: {this.CaballosDeFuerza}");

            return sb.ToString();
        }
    }
}
