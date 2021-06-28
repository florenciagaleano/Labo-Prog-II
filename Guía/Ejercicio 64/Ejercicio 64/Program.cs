using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja c1 = new Caja();
            Caja c2 = new Caja();

            Negocio negocio = new Negocio(c1,c2);

            negocio.Clientes.Add("Flor");
            negocio.Clientes.Add("Ariana");
            negocio.Clientes.Add("Robert");
            negocio.Clientes.Add("Agus");

            Thread asignarCajas = new Thread(negocio.AsignarCaja);
            asignarCajas.Name = "im so gonna desaprobar";

            Thread caja1 = new Thread(c1.AtenderCaja);
            caja1.Name = "Caja 1";

            Thread caja2 = new Thread(c2.AtenderCaja);
            caja2.Name = "Caja 2";

            asignarCajas.Start();
            asignarCajas.Join();
            caja1.Start();
            caja2.Start();

            Console.ReadKey();
        }
    }
}
