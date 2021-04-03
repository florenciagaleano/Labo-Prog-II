using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private string apellido;

        public Cliente (string nombre,string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string getNombreYApellido()
        {
            return $"{ this.nombre} {this.apellido}";
        }
        
    }
}
