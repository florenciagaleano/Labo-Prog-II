using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        static Automovil()
        {
            valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color)
            : base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora)
            : this(patente, color)
        {
            Automovil.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Color: {this.color}");
            sb.AppendLine($"Costo por hora: {Automovil.valorHora}");


            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            int valorHora = (DateTime.Now.Hour - base.ingreso.Hour) * Automovil.valorHora;

            sb.AppendLine(this.ConsultarDatos());
            sb.AppendLine($"Valor hora: {valorHora}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Automovil;
        }
    }
}
