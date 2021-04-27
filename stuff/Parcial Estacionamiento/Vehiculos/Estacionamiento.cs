using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre,int espacioDisponible)
            :this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre:{e.nombre}");
            sb.AppendLine($"Espacio disponible: {e.espacioDisponible}");

            foreach(Vehiculo item in e.vehiculos)
            {
                sb.AppendLine(item.ImprimirTicket());
            }

            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach (Vehiculo item in estacionamiento.vehiculos)
            {
                if(item == vehiculo)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento != vehiculo && vehiculo.Patente != null && estacionamiento.espacioDisponible > estacionamiento.vehiculos.Count())
            {
                estacionamiento.vehiculos.Add(vehiculo);
            }

            return estacionamiento;
        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            string retorno = "El vehiculo no es parte del estacionamiento";

            if(estacionamiento.vehiculos.Remove(vehiculo))
            {
                retorno = vehiculo.ImprimirTicket();
            }

            return retorno;
        }


    }
}
