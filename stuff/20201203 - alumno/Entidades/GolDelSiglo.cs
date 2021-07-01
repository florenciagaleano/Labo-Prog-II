using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Audio;

namespace Entidades
{
    public class GolDelSiglo
    {
        private Thread hiloRelato;

        public void CerrarApp()
        {
            if(this.hiloRelato != null && this.hiloRelato.IsAlive)
            {
                this.hiloRelato.Abort();
            }
        }

        public void IniciarJugada()
        { 
if (!(this.hiloRelato is null) &&hiloRelato.IsAlive )
                {
                    throw new JugadaActivaException();
                }
                else
                {
                    this.hiloRelato = new Thread(Relato.VictorHugoMorales);
                    this.hiloRelato.Start();
                }
            
        }
    }
}
