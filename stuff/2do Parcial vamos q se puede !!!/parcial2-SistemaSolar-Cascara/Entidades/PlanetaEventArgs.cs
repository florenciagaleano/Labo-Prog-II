﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlanetaEventArgs
    {
        private short avance;
        private short radioRespectoSol;

        public PlanetaEventArgs(short avance, short radio)
        {
            this.avance = avance;
            this.radioRespectoSol = radio;
        }

        public short Avance
        {
            get
            {
                return this.avance;
            }
        }

        public short RadioRespectoSol
        {
            get
            {
                return this.radioRespectoSol;
            }
        }
    }
}
