using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30_36_46_49
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustile;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustile = 0;
            this.vueltasRestantes = 0;
        }

        public short CantidadCombustile
        {
            get
            {
                return this.cantidadCombustile;
            }
            set
            {
                this.cantidadCombustile = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public static bool operator ==(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            if (a1.escuderia == a2.escuderia && a1.numero == a2.numero)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return !(a1 == a2);
        }
        //private short cantidadCombustile;
        //private bool enCompetencia;
        //private string escuderia;
        //private short numero;
        //private short vueltasRestantes;
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Numero: {this.numero}");
            sb.AppendLine($"Escuderia: {this.escuderia}");
            sb.AppendLine($"En competencia: {this.EnCompetencia}");
            sb.AppendLine($"Cantidad de combustible: {this.CantidadCombustile}");
            sb.AppendLine($"Vueltas restantes: {this.VueltasRestantes}");

            return sb.ToString();
        }
    }
}
