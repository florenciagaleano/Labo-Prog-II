using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_claess
{
    public class Banano : Planta
    {
        private string codigo;

        public Banano(string nombre,int tamanio, string codigo)
            :base(nombre,tamanio)
        {
            this.codigo = codigo;
        }

        public override bool TieneFlores
        {
            get
            {
                return true;
            }
        }
        public override bool TieneFrutos
        {
            get
            {
                return true;
            }
        }

        public override string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ResumenDeDatos());
            sb.AppendLine(string.Format("Codigo Internacional: {0}",this.codigo));

            return sb.ToString();
        }
    }
}
