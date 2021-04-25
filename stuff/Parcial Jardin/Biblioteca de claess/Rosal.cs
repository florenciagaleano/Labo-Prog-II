using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//a.Su ResumenDeDatos incorporará el concepto "Flores de color: XXXXX".
//b. Tiene flores y no tiene fruto.

namespace Biblioteca_de_claess
{
    public class Rosal : Planta
    {
        public enum Color
        {
            Roja,
            Blanca,
            Amarilla,
            Rosa,
            Azul
        }

        private Color florColor;

        public Rosal(string nombre,int tamanio)
            :base(nombre,tamanio)
        {

        }

        public Rosal(string nombre, int tamanio,Color florColor)
            :this(nombre,tamanio)
        {
            this.florColor = florColor;
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
                return false;
            }
        }

        public override string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ResumenDeDatos());
            sb.AppendLine(string.Format("Flores de color: {0}", this.florColor));

            return sb.ToString();
        }
    }
}
