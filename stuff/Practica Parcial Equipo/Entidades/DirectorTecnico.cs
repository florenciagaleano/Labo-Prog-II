using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public DirectorTecnico(string nombre,string apellido,int edad,int dni,int añosExperiencia)
            :base(apellido,dni,edad,nombre)
        {
            this.AñosExperiencia = añosExperiencia;
        }

        public int AñosExperiencia 
        { 
            get
            {
                return this.añosExperiencia;
            }
            set
            {
                this.añosExperiencia = value;
            }
        }

        //ValidarAptitud validará que el Director Técnico sea menor a 65 años y tenga al menos 2 años de experiencia.
        public override bool ValidarAptitud()
        {
            if(this.Edad < 65 && this.AñosExperiencia >= 2)
            {
                return true;
            }

            return false;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.Append($" {this.AñosExperiencia}");

            return sb.ToString();
        }
    }
}
