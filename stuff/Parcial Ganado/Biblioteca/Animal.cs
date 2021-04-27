using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Animal
    {
        private int kilosAlimento;
        private string nombre;

        protected Animal(string nombre,int volumen)
        {
            this.kilosAlimento = volumen;
            this.nombre = nombre;
        }

        public int KilosAlimento
        {
            get
            {
                return this.kilosAlimento;
            }
        }

        public abstract bool ComeBalanceado { get; }
        public abstract bool ComePasto { get; }

        public virtual string Datos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("{0} come {1}kg",this.nombre,this.KilosAlimento));
            if(this.ComeBalanceado)
            {
                sb.AppendLine("Come balanceado: SI");
            }else
            {
                sb.AppendLine("Come balanceado: NO");
            }

            if(this.ComePasto)
            {
                sb.AppendLine("Consume pasto: SI");
            }else
            {
                sb.AppendLine("Consume pasto: NO");

            }

            return sb.ToString();
        }
    }
}
