using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Persona
    {
        public delegate void DelegadoEstado(object sender, EventArgs e);

        public event DelegadoEstado InformaEstaddo;
        public static event DelegadoCajero InformaCajero;

        public enum EEstado
        {
            Ingresado,
            Cobrado,
            Atendido
        }

        private List<Factura> facturas;
        private string codigoPersona;
        private EEstado estado;
        private float montoTotal;


        public Persona(string codigoPersona)
        {
            this.facturas = new List<Factura>();
            this.codigoPersona = codigoPersona;
            this.estado = EEstado.Ingresado;
        }

        public Persona()
        {

        }

        public List<Factura> Factura
        {
            get
            {
                return this.facturas;
            }
            set
            {
                this.facturas = value;
            }
        }

        public string Codigo
        {
            get
            {
                return this.codigoPersona;
            }
            set
            {
                this.codigoPersona = value;
            }
        }

        public float MontoTotal
        {
            get
            {
                return this.montoTotal;
            }
            set
            {
                this.montoTotal = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public override string ToString()
        {
            return this.codigoPersona;
        }

        public static Persona HardcodearPersonas()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            Persona p = new Persona(random.Next().ToString());
            for(int i=0; i<random.Next(1,10);i++)
            {
                Factura f = new Factura(random.Next(1000, 10000)/100,random.Next());
                p.facturas.Add(f);
            }
            Thread.Sleep(100);
            return p;
        }

        public void MockClicloCajero()
        {
            while(this.estado != EEstado.Atendido)
            {
                switch(this.estado)
                {
                    case EEstado.Ingresado:
                        Thread.Sleep(2000);
                        this.estado = EEstado.Cobrado;
                        this.InformaEstaddo.Invoke(this, EventArgs.Empty);
                        break;
                    case EEstado.Cobrado:
                        Thread.Sleep(2000);
                        this.estado = EEstado.Atendido;
                        this.InformaEstaddo.Invoke(this, EventArgs.Empty);
                        break;
                    default:
                        break;
                }
            }
            try
            {
                InformaCajero.Invoke(this);
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
