using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        static Moto()
        {
            valorHora = 30;
        }

        public Moto(string patente, int cilindrada)
            :base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = 2;
        }

        public Moto(string patente, int cilindrada, short ruedas)
            :this(patente,cilindrada)
        {
            this.ruedas = ruedas;

        }

        public Moto(string patente,int cilindrada, short ruedas, int valorHora)
            :this(patente,cilindrada,ruedas)
        {
            Moto.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Cilindrada: {this.cilindrada}");
            sb.AppendLine($"Ruedas: {this.ruedas}");
            sb.AppendLine($"Costo por hora: {Moto.valorHora}");

            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            int valorHora = (DateTime.Now.Hour - this.ingreso.Hour) * Moto.valorHora;

            sb.AppendLine(this.ConsultarDatos());
            sb.AppendLine($"Valor hora: {valorHora}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Moto;
        }
    }
}
