using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class CentroDeVacunacion
    {
        private List<Paciente> personas;

        public CentroDeVacunacion()
        {
            this.personas = new List<Paciente>();
        }

        public CentroDeVacunacion(List<Paciente> personas)
            :this()
        {
            this.personas = personas;
        }

        public List<Paciente> Personas { get => personas; set => personas = value; }
    }
}
