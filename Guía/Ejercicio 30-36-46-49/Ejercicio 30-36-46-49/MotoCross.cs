using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30_36_46_49
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero, string escuderia)
            :base(numero,escuderia)
        { }

        public MotoCross(short numero, string escuderia,short cilindrada)
            :this(numero,escuderia)
        {
            this.Cilindrada = cilindrada;
        }

        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }set
            {
                this.cilindrada = value;
            }
        }

        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            if (a1 == a2 && a1.Cilindrada == a2.Cilindrada)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Cilindrada: {this.Cilindrada}");

            return sb.ToString();
        }
    }
}
