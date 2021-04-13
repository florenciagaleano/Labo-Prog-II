using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        #region Constructores
        private Jugador()
        {
           // this.dni = 0; no cuenta como dato estadistico right ¿?
            this.partidosJugados = 0;
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni,string nombre)
            :this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni,string nombre,int totalGoles,int totalPartidos)
            :this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        #endregion

        public float GetPromedioGoles()
        {
            return (float)this.totalGoles / this.partidosJugados;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Promedio goles: {(this.GetPromedioGoles()).ToString()}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1,Jugador j2)
        {
            if(j1.dni == j2.dni)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
