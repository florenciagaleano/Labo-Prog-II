using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Centralita:
//l.CalcularGanancia será privado.Este método recibe un Enumerado TipoLlamada y retornará
//el valor de lo recaudado, según el criterio elegido (ganancias por las llamadas del tipo Local,
//Provincial o de Todas según corresponda).
//m.El método Mostrar expondrá la razón social, la ganancia total, ganancia por llamados locales
//y provinciales y el detalle de las llamadas realizadas.
//n. La lista sólo se inicializará en el constructor por defecto Centralita().
//o.Las propiedades GananciaPorTotal, GananciaPorLocal y GananciaPorProvincial retornarán el
//precio de lo facturado según el criterio. Dichos valores se calcularán en el método
//CalcularGanancia().

namespace CentralitaHerencia
{
    public class Centralita : IGuardar<string>
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;

        #region Constructores
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            :this()
        {
            this.razonSocial = nombreEmpresa;
        }

        #endregion

        #region Propiedades

        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciaPorTotal
        {
            get
            {
                return this.GananciaPorLocal + this.GananciaPorProvincial;
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }


        #endregion

        #region Metoodos

        public void AgregarLlamada(Llamada llamada)
        {
            this.listaDeLlamadas.Add(llamada);
        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gananciaP = 0;
            float gananciaL = 0;
            float retorno = 0;

            foreach (Llamada item in this.listaDeLlamadas)
            {
                if(item is Local)
                {
                    gananciaL += ((Local)item).CostoLlamada;
                }else if(item is Provincial)
                {
                    gananciaP += ((Provincial)item).CostoLlamada;
                }
            }

            switch(tipo)
            {
                case Llamada.TipoLlamada.Local:
                    retorno = gananciaL;
                    break;
                case Llamada.TipoLlamada.Provincial:
                    retorno = gananciaP;
                    break;
                default:
                    retorno = gananciaP + gananciaL;
                    break;
            }

            return retorno;
        }

        private string Mostrar()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine($"La razon social es: ***** {this.razonSocial} *****");
            returnAux.AppendLine($"La ganancia provincial es : {this.GananciaPorProvincial}");
            returnAux.AppendLine($"La ganancia local es : {this.GananciaPorLocal}");
            returnAux.AppendLine($"La ganancia total es : {this.GananciaPorTotal}");
            returnAux.AppendLine("-------------------------------------------------------\n\n***** Listado de llamadas *****");
            foreach (Llamada llamada in this.Llamadas)
            {
                if(llamada is Local)
                {
                    returnAux.AppendLine(llamada.ToString());
                }else
                {
                    returnAux.AppendLine(llamada.ToString());
                }
            }
            return returnAux.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach (Llamada item in c.listaDeLlamadas)
            {
                if(item == llamada)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada llamada)
        {
            if (c != llamada)
            {
                c.AgregarLlamada(llamada);
                if(!c.Guardar())
                {
                    throw new FalloLogException();
                }
            }
            else
            {
                throw new CentralitaException("Esa llamada ya esta registrada en el sistema", "Centralita", "public static Centralita operator +");
            }

            return c;
        }

        #endregion

        #region ImplementacionInterfaz

        public string RutaDeArchivo
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory;
            }set
            {
                
            }
        }
        //DateTime.Now.ToString("dddd dd de MMMM de yyyy HH:mmhs") + " - Se realizo una llamada";
        public bool Guardar()
        {
            string nombreArchivo = "Llamadas realizadas";
            try { 
                using (StreamWriter sw = new StreamWriter(this.RutaDeArchivo + nombreArchivo))
                {
                    if (!File.Exists(this.RutaDeArchivo + nombreArchivo))
                    {
                        File.Create(this.RutaDeArchivo + nombreArchivo);
                    }

                    sw.WriteLine(DateTime.Now.ToString("dddd dd 'de' MMMM 'de' yyyy HH':'mm'hs'") + " - Se realizo una llamada");
                    return true;
                }
            }catch(Exception)
            {
                return false;
            }
        }
        //rutaFile = AppDomain.CurrentDomain.BaseDirectory + nombreFile;//devuelve la ruta del bin del proyecto
        public string Leer()
        {
            using(StreamReader sr = new StreamReader(this.RutaDeArchivo + "Llamadas realizadas"))
            {
                return sr.ReadToEnd();
            }
        }

        #endregion
    }
}

