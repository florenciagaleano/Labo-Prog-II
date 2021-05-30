using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Lapiz : IAcciones
    {
        private double tamanioMina;

        public Lapiz(int unidades)
        {
            this.UnidadesDeEscritura = unidades;
        }

        public ConsoleColor Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public double UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        //EscrituraWrapper IAcciones.Escribir(string texto)//explicita
        public EscrituraWrapper Escribir(string texto)
        {
            double reduccion = texto.Length * 0.1; 
            this.tamanioMina = this.tamanioMina - reduccion;
            return new EscrituraWrapper(texto, ConsoleColor.Cyan);
        }

        //bool IAcciones.Recargar(int unidades)
        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lapiz");
            sb.AppendLine(this.Color.ToString());
            sb.AppendLine(this.tamanioMina.ToString());

            return sb.ToString();

        }
    }
}
