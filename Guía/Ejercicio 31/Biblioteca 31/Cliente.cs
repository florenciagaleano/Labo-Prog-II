using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_31
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        #region Constructores
        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero,string nombre) 
            :this(numero)
        {
            this.nombre = nombre;
        }
        #endregion

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
    }
}
