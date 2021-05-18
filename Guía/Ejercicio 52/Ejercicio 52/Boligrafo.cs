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
        private float tinta;

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

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }set
            {
                this.tinta = value;
            }
        }
    }
}
