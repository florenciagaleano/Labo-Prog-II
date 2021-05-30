using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private double tinta;

        public Boligrafo(int unidades,ConsoleColor color)
        {

        }

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }set
            {
                this.colorTinta = value;
            }
        }

        public double UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }set
            {
                this.tinta = value;
            }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            this.tinta -= texto.Length * 0.3;

            return new EscrituraWrapper(texto, ConsoleColor.Gray);
        }
        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Boligrafo");
            sb.AppendLine(this.colorTinta.ToString());
            sb.AppendLine(this.tinta.ToString());

            return sb.ToString();

        }
    }
}
