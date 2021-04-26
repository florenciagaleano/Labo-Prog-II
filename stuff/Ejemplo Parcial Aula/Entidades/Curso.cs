using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Division division;
        private Profesor profesor;

        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        public Curso(short anio,Division division,Profesor profesor)
            :this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public string AnioDivision
        {
            get
            {
                return $"{this.anio}º{this.division}";
            }
        }

        //El operador explícito retornará los datos del curso y todos sus alumnos,
        //utilizando StringBuilder para compilar dicha información.
        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Curso: {c.AnioDivision}");
            sb.AppendLine($"Profesor: {c.profesor}");
            sb.AppendLine("Alumnos:");
            foreach (Alumno alumno in c.alumnos)
            {
                sb.Append(alumno.ExponerDatos());
            }

            return sb.ToString();
        }
        /*El operador == entre Curso y Alumno informará true si el alumno pertenece al mismo 
         * Año y División que el curso.*/
        public static bool operator ==(Curso c, Alumno a)
        {
            if(a.AnioDivision == c.AnioDivision)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        //El operador + entre Curso y Alumno agregará al alumno al curso siempre
        //y cuando su Año y División coincidan.
        public static Curso operator +(Curso c, Alumno a)
        {
            if(c == a)
            {
                c.alumnos.Add(a);
            }

            return c;
        }
    }
}
