using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Caballo : Animal
    {
        private bool corredor;

        public Caballo(string nombre, int kilosAlimento, bool corredor)
            :base(nombre,kilosAlimento)
        {
            this.corredor = corredor;
        }

        public override bool ComeBalanceado
        {
            get
            {
                return false;
            }
        }
        public override bool ComePasto
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Retorna una cadena con todos los datos de caballo
        /// </summary>
        /// <returns>Cadena con los datos de un caballo</returns>
        public override string Datos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Datos());
            if(this.corredor)
            {
                sb.AppendLine($"Es corredor: SI");
            }else
            {
                sb.AppendLine($"Es corredor: NO");
            }

            return sb.ToString();
        }
    }
}
