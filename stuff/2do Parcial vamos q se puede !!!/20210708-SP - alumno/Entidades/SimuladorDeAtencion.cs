using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public delegate void FinalDelegate(string texto);
    public delegate void SimuladoDelegate<U>(U item);
    public class SimuladorDeAtencion<T>
    {
        public event SimuladoDelegate<T> AvisoDeUso;
        public event FinalDelegate FinDeUso;

        public void SimularVacunacion(object param)
        {
            StringBuilder sb = new StringBuilder();
            //Thread hilo = new Thread(SimularVacunacion);
            //hilo.Start(param);
            if(param.GetType() == typeof(List<T>))
            {
                foreach (T item in (List<T>)param)
                {
                    if(this.AvisoDeUso != null)//hay suscriptores{
                    {
                        sb.AppendLine(item.ToString());
                        this.AvisoDeUso.Invoke(item);
                        Thread.Sleep(1200);
                    }
                }

                if(this.FinDeUso != null)
                {
                    this.FinDeUso.Invoke(sb.ToString());
                }
            }
        }

    }
}
