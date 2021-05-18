using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Interfaces
{
    public class GestionImpuestos
    {
        public List<IAduana> recaudoImpuestosAduana;
        public List<IAfip> recaudoImpuestosAfip;

        public GestionImpuestos()
        {
            this.recaudoImpuestosAduana = new List<IAduana>();
            this.recaudoImpuestosAfip = new List<IAfip>();
        }

        public double CalcularImpuestosTotalesAduana()
        {
            double resultado = 0;

            foreach (IAduana item in recaudoImpuestosAduana)
            {
                resultado += item.CalcularImpuesto();
            }

            return resultado;
        }

        public double CalcularImpuestosTotalesAfip()
        {
            double resultado = 0;

            foreach (IAfip item in recaudoImpuestosAfip)
            {
                resultado += item.CalcularImpuesto();
            }

            return resultado;
        }
    }
}
