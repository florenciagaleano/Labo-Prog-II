using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public delegate bool DelegadoCajero(Persona persona);
    public class Cajero
    {
        private List<Thread> hiloCajas;
        public static Queue<Persona> personas;

        public Cajero()
        {
            this.hiloCajas = new List<Thread>();
            personas = new Queue<Persona>();
        }

        public void Cobrar(Persona p, Cajero c)
        {
            float montoTotal = 0;
            foreach (Factura item in p.Factura)
            {
                montoTotal += item.Precio;
            }
            p.MontoTotal = montoTotal;
            Thread nuevoHilo = new Thread(p.MockClicloCajero);
            c.hiloCajas.Add(nuevoHilo);

            nuevoHilo.Start();
        }

        public void CerarCajero()
        {
            foreach (Thread item in this.hiloCajas)
            {
                if (item.IsAlive)
                    item.Abort();
            }
        }
    }
}
