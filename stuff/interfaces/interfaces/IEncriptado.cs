using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public interface IEncriptado
    {
        string EnviarMensaje();
        string Destino { get; }
    }
}
