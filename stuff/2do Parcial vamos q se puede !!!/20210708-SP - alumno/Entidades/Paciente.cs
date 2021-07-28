using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Paciente
    {
        private string apellido;
        private string nombre;
        private int turno;

        public Paciente() { }

        public Paciente(int turno,string nombre, string apellido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.turno = turno;
        }

        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Turno { get => turno; set => turno = value; }

        public override string ToString()
        {
            return $"{this.apellido}, {this.nombre}";
        }
    }
}
