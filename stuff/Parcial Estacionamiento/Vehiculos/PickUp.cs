using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private static int valorHora;

        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp (string patente,string modelo)
            :base(patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo,int valorHora)
            :this(patente,modelo)
        {
            PickUp.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Modelo: {this.modelo}");
            sb.AppendLine($"Costo por hora: {PickUp.valorHora}");

            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            int valorHora = (DateTime.Now.Hour - base.ingreso.Hour) * PickUp.valorHora;

            sb.AppendLine(this.ConsultarDatos());
            sb.AppendLine($"Valor hora: {valorHora}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is PickUp;
        }
    }
}
