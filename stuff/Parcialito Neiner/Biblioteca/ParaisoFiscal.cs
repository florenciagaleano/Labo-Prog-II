using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ParaisoFiscal
    {
        public enum eParaisosFiscales
        {
            Anguila, Belice, Delaware, Gibraltar, Hong_Kong, Mauricio, Panama, Seychelles, Singapur, Suiza,
        }

        private List<CuentaOffShore> listadoCuentas;
        private eParaisosFiscales lugar;
        public static int cantidadDeCuentas;
        public static DateTime fechaInicio;

        static ParaisoFiscal()
        {
            cantidadDeCuentas = 0;
            fechaInicio = DateTime.Now;
        }

        private ParaisoFiscal()
        {
            this.listadoCuentas = new List<CuentaOffShore>();
        }

        private ParaisoFiscal(eParaisosFiscales lugar)
            :this()
        {
            this.lugar = lugar;
        }

        public void MostrarParaiso()
        {
            StringBuilder paraisos = new StringBuilder();
            paraisos.Append("Lugar:");
            paraisos.AppendLine(Convert.ToString(this.lugar));
            paraisos.Append("Cantidad de cuentas: ");
            paraisos.AppendLine(Convert.ToString(cantidadDeCuentas));
            paraisos.Append("Fecha de inicio: ");
            paraisos.AppendLine(Convert.ToString(fechaInicio));

            Console.WriteLine(paraisos.ToString());

            foreach (CuentaOffShore item in this.listadoCuentas)
            {
                Console.Write(Cliente.RetornarDatos(item.Dueño));
                Console.WriteLine(item.Saldo);
            }
        }

        public static implicit operator ParaisoFiscal(eParaisosFiscales epf)
        {
            //private ParaisoFiscal(eParaisosFiscales lugar)
            return new ParaisoFiscal(epf);
        }

        public static ParaisoFiscal operator -(ParaisoFiscal pf,CuentaOffShore cos)
        {
            if (pf == cos)
            {
                pf.listadoCuentas.RemoveAt(pf.listadoCuentas.IndexOf(cos));
                cantidadDeCuentas--;
            }

            return pf;
        }

        public static ParaisoFiscal operator +(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if(pf != cos)
            {
                pf.listadoCuentas.Add(cos);
                cantidadDeCuentas++;
            }

            return pf;
        }

        public static bool operator ==(ParaisoFiscal pf, CuentaOffShore cos)
        {
            for (int i = 0; i < pf.listadoCuentas.Count(); i++)
            {
                if (pf.listadoCuentas[i] == cos)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return !(pf == cos);
        }


    }
}
