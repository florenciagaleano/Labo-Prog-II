using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoDat : Archivo
    {
        private string contenido;

        public string Contenido
        {
            get
            {
                return this.contenido;
            }set
            {
                this.contenido = value;
            }
        }

        public bool Guardar(string ruta,PuntoDat objeto)
        {

        }

        public bool GuardarComo(string ruta, PuntoDat objeto)
        {

        }

        public PuntoDat Leer(string ruta)
        {

        }

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            if(base.ValidarArchivo(ruta,validaExistencia) && System.IO.Path.GetExtension(ruta) == ".dat")
            {
                return true;
            }

            return false;
        }
    }
}
