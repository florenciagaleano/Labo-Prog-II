﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente("Flor","Galeano");

            System.Console.WriteLine("Cliente: {0}",c.getNombreYApellido());

            Console.ReadKey();
        }
    }
}
