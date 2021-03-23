using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mascota
    {
        //especie, su nombre, su fecha de nacimiento y su historial de vacunación
        private string especie;
        private string nombre;
        private DateTime nacimiento;
        private Vacuna[] vacunas;

        public Mascota(string especie,string nombre,DateTime nacimiento)
        {
            this.especie = especie;
            this.nacimiento = nacimiento;
            this.nombre = nombre;
        }

        public string getName()
        {
            return this.nombre;
        }

        public DateTime getBirth()
        {
            return this.nacimiento;
        }

        public string getEspecie()
        {
            return this.especie;
        }

        public void AddVacuna(Vacuna vacuna)
        {
            if (this.vacunas is null)
            {
                this.vacunas = new Vacuna[1];//inicializo en el proximo indice
            }
            else
            {
                int nuevoTam = this.vacunas.Length + 1;//lo voy agrandando
                Array.Resize(ref this.vacunas, nuevoTam);
            }

            for (int i = 0; i < this.vacunas.Length; i++)
            {
                if (this.vacunas[i] is null)
                {
                    this.vacunas[i] = vacuna;
                    break;
                }
            }
        }

        public string getVacuna()
        {
            string ret = "";//vacia si no hay nada

            if (this.vacunas != null)
            {
                foreach (Vacuna vacuna in this.vacunas)
                {
                    ret += vacuna.getName();
                }
            }

            return ret;
        }
    }
}
