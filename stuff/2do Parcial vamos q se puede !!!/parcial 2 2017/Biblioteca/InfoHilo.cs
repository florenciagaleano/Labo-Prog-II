using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Threading;

namespace Biblioteca
{
    public class InfoHilo
    {
        private IRespuesta<int> callback;
        private Thread hilo;
        private int id;
        private static Random randomizer;

        private void Ejecutar()
        {
            Thread.Sleep(randomizer.Next(1000, 5000));
            this.callback.RespuestaHilo(id);
        }

        public InfoHilo(int id, IRespuesta<int> callback)
        {
            this.hilo = new Thread(Ejecutar);
            this.callback = callback;
            this.id = id;

            this.hilo.Start();
        }

        static InfoHilo()
        {
            randomizer = new Random();
        }


    }
}
