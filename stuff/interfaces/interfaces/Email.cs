﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Email: IMensaje
    {
        private string origen;
        private string destino;

        public Email(string origen, string destino)
        {
            this.origen = origen;
            this.destino = destino;
        }

        public string EnviarMensaje()
        {
            return "Ya falta mucho para implementar?";
        }
    }
}
