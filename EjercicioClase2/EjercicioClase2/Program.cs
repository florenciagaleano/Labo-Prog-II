using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace EjercicioClase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Cerrito 123", "David", "Bowie", "08001212");
            Mascota perrito = new Mascota("perro","Bruce",new DateTime(2018,11,10));
            Mascota gatito = new Mascota("gato", "Isa", new DateTime(2010, 6, 15));
            Vacuna vacuna = new Vacuna("Antirrabica");

            cliente.AddMascota(gatito);
            cliente.AddMascota(perrito);
            perrito.AddVacuna(vacuna);

            Console.WriteLine("{0} {1} {2} {3}",cliente.getNombreCompleto(),cliente.getDomicilio(),cliente.geTelefono(),cliente.getMascota());
            Console.WriteLine("Vacunas: {0}",vacuna.getName());

            Console.ReadKey();
        }
    }
}
