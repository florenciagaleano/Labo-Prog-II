﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public interface IAcciones
    {
        ConsoleColor Color { get; set; }
        double UnidadesDeEscritura{ get; set; }

        EscrituraWrapper Escribir(string texto);

        bool Recargar(int unidades);
        
    }
}
