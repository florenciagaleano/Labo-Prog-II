using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Cuervo : AnimalVolador, IMensaje,IEncriptado
    {
        public Cuervo(string nombre):base(nombre)
        {

        }

        string IMensaje.EnviarMensaje()
        {
            return "Llego el invierno";
        }

        string IEncriptado.EnviarMensaje()
        {
            return "El otro mensaje";
        }

        public string Destino
        {
            get
            {
                return "Desembarco del rey";
            }
        }
    }
}
