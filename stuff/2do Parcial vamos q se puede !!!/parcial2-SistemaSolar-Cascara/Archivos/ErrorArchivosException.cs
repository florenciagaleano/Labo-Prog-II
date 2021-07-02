﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class ErrorArchivosException : Exception
    {
        public ErrorArchivosException(string mensaje, Exception inner)
            :base(mensaje,inner)
        {

        }

        public ErrorArchivosException(string mensaje)
            :base(mensaje)
        {

        }
    }

}
