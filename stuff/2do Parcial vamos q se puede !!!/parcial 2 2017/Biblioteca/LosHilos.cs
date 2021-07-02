using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Interfaces;

namespace Biblioteca
{
    public class LosHilos : IRespuesta<int>
    {
        public delegate void AvisoFinCallback(string mensaje);

        private int id;
        private List<InfoHilo> misHilos;
        public event AvisoFinCallback AvisoFin;

        public LosHilos()
        {
            this.id = 0;
            this.misHilos = new List<InfoHilo>();
        }

        public string Bitacora
        {
            get
            {
                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Bitacora.txt"))
                {
                    File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Bitacora.txt");
                }

                using (StreamReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Bitacora.txt"))
                {
                    return reader.ReadToEnd();
                }
            }
            set
            {
                /*if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "Bitacora.txt"))
                {
                    File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "Bitacora.txt");
                }*/

                using (StreamWriter writer = new StreamWriter((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Bitacora.txt"), true))
                {
                    writer.WriteLine(value);
                }
            }
        }

        private static LosHilos AgregarHilo(LosHilos hilos)
        {
            hilos.id++;
            hilos.misHilos.Add(new InfoHilo(hilos.id, (Interfaces.IRespuesta<int>)hilos));

            return hilos;
        }

        public static LosHilos operator +(LosHilos hilos,int cantidad)
        {
            if(cantidad < 1)
            {
                throw new CantidadInvalidaException();
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    LosHilos.AgregarHilo(hilos);
                }
            }

            return hilos;
        }

        public void RespuestaHilo(int id)
        {
            string mensaje = $"Terminó el hilo {this.id}";
            this.Bitacora = mensaje;
            this.AvisoFin.Invoke(mensaje);
        }
    }
}
