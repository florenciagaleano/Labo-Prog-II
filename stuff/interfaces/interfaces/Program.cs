using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
           // IMensaje<string> mensaje = new Paloma("Nombre", "aaaa");
            List<IMensaje> mensajes = new List<IMensaje>();

            Paloma paloma = new Paloma("Azir", "Shurima");
            Courier courier = new Courier("Juan", "Perez", "4344745");
            Carta carta = new Carta("A4", 1, "Lobo");
            Email mail = new Email("Flor@gmail.com", "hola@gmail.com");
            Cuervo cuervo = new Cuervo("Bloodraven");

            mensajes.Add(paloma);
            mensajes.Add(courier);
            mensajes.Add(carta);
            mensajes.Add(mail);

            foreach (IMensaje item in mensajes)
            {
                Console.WriteLine(item.EnviarMensaje());
            }

            Console.WriteLine(((IMensaje)cuervo).EnviarMensaje());

            Console.ReadKey();

        }
    }
}
