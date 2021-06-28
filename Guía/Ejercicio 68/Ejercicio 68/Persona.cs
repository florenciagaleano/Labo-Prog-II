using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_68
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona()
        {
            this.nombre = string.Empty;
            this.apellido = string.Empty;
        }

        public string Nombre
        {
            get
            { 
                return this.nombre;
            }
            set 
            {
                if(value != this.nombre)
                {
                    this.nombre = value;
                    this.EventoString.Invoke(this.nombre);
                    
                }
            }
        }

        public string Apellido
        {
            get 
            { 
                return this.apellido; 
            }
            set 
            {
                if(value != this.apellido)
                {
                    this.apellido = value;
                    this.EventoString.Invoke(this.apellido);
                    
                }
            }
        }

        public string Mostrar()
        {
            return $"{this.nombre} {this.apellido}";
        }

        public event DelegadoString EventoString;
    }
}
