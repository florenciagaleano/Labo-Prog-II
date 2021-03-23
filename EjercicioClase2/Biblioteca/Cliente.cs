using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        // domicilio, el nombre y apellido y un teléfono
        private string domicilio;
        private string nombre;
        private string apellido;
        private string telefono;
        private Mascota[] mascotas;

        public Cliente(string domicilio,string nombre, string apellido,string telefono)
        {
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.telefono = telefono;
            //this.mascotas = new Mascota[10];
        }



       public void AddMascota(Mascota mascota)
        {
            if(this.mascotas is null)
            {
                this.mascotas = new Mascota[1];//inicializo en el proximo indice
            }else
            {
                int nuevoTam = this.mascotas.Length + 1;//lo voy agrandando
                Array.Resize(ref this.mascotas, nuevoTam);
            }

            for(int i=0; i < this.mascotas.Length;i++)
            {
                if(this.mascotas[i] is null)
                {
                    this.mascotas[i] = mascota;
                    break;
                }
            }
        }

        //getters
        public string getDomicilio()
        {
            return this.domicilio;
        }

        public string getNombreCompleto()
        {
            return $"{this.nombre} {this.apellido}";
        }

        public string geTelefono()
        {
            return this.telefono;
        }

        public string getMascota()
        {
            string ret = "";//vacia si no hay nada

            if(this.mascotas != null)
            {
                foreach (Mascota mascota in this.mascotas)
                {
                    ret += mascota.getName();
                }
            }

            return ret;
        }
    }

}
