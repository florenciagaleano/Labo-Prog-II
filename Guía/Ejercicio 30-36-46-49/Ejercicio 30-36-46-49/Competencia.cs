using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30_36_46_49
{
    public class Competencia<T> where T : VehiculoDeCarrera
    {
        public enum TipoCompetencia
        {
            F1, MotoCross
        }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<T> competidores;
        private TipoCompetencia tipo;

        public Competencia(short cantidadVueltas, short cantidadCompetidores,TipoCompetencia tipo)
            :this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }

        private Competencia()
        {
            this.competidores = new List<T>();
        }

        public List<T> Vehiculos
        {
            get
            {
                return this.competidores;
            }set
            {
                this.competidores = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"***COMPETENCIA DE AUTOS***");
            sb.AppendLine($"Cantidad de competidores: {this.cantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {this.cantidadVueltas}");
            sb.AppendLine("Competidores:");
            foreach (T item in this.competidores)
            {
                sb.AppendLine($"-{item.MostrarDatos()}");
            }

            return sb.ToString();
        }

        public static bool operator ==(Competencia<T> c, T a)
        {
            if(a is AutoF1 && c.tipo == TipoCompetencia.F1 || a is MotoCross && c.tipo == TipoCompetencia.MotoCross)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Competencia<T> c, T a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia<T> c, T a)
        {
            bool yaEsta = false;

            foreach (T item in c.competidores)
            {
                if(item == a)
                {
                    yaEsta = true;
                }
            }

            if (!yaEsta && c.competidores.Count < c.cantidadCompetidores && c == a)
            {
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustile = (short)new Random().Next(15,100);
                return true;
            }

            if(c!= a)
            {
                throw new CompetenciaNoDisponibleException("Competencia no disponible", "Competencia", "Sobrecarga operador +");
            }

            return false;
        }

        public static bool operator -(Competencia<T> c, T a)
        {
            if(c == a)
            {
                c.Vehiculos.Remove(a);
                return true;
            }

            return false;
        }

    }
}
