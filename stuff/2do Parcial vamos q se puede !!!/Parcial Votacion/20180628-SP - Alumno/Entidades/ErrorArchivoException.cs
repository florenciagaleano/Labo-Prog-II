﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ErrorArchivoException : Exception
    {
        public ErrorArchivoException(Exception inner)
            :base("Problemas con los archivos "+inner.Message)
        {

        }
    }
}
