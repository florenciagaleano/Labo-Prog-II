using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if(value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

       // El operador explícito retornará los datos del equipo, 
       // su director técnico(en caso de no tener uno asignado aún, 
       // mostrar en su lugar el string "Sin DT asignado") y todos sus jugadores, 
       //utilizando StringBuilder para compilar dicha información.
        public static explicit operator string(Equipo equipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Equipo: {equipo.Nombre} ");
            if (equipo.directorTecnico != null)
            {
                sb.Append($"DT: {equipo.directorTecnico.Mostrar()}");
            }
            else
            {
                sb.Append("Sin DT asignado ");
            }

            foreach (Jugador item in equipo.jugadores)
            {
                sb.AppendLine(item.Mostrar());
            }


            return sb.ToString();
        }

        /*El operador == entre Equipo y Jugador informará true si 
         * esa instancia de Jugador ya se encuentra agregada al equipo.*/
        public static bool operator ==(Equipo e, Jugador j)
        {
            foreach (Jugador item in e.jugadores)
            {
                if(item == j)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        //El operador + entre Equipo y Jugador agregará el jugador al equipo siempre y cuando:
        //i.Este no haya sido agregado aún.
        //ii.No haya sido superada la cantidad de integrantes.
        //iii.Cumpla las condiciones de aptitud.

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && j.ValidarAptitud() && cantidadMaximaJugadores > e.jugadores.Count())
            {
                e.jugadores.Add(j);
                return e;
            }

            return e;
        }

        //ValidarEquipo: Método de clase que retorna true en caso de que un equipo sea válido, para lo cual debe cumplir con las siguientes condiciones:
        //i.Tener un Director Técnico asignado.
        //ii.Tener al menos un jugador de c/posición.
        //iii.Tener sólo 1 arquero.
        //iv.Cumplir con la cantidad de integrantes completa(la cantidad de jugadores agregados a la lista debe ser igual a la constante “cantidadMaximaJugadores”).

        public static bool ValidarEquipo(Equipo e)
        {
            int contadorValidacion = 0;
            int contArquero = 0;
            bool[] flag = new bool[4];//hay 4 posiciones

            if(e.directorTecnico != null && e.jugadores.Count() == cantidadMaximaJugadores)
            {
                foreach (Jugador item in e.jugadores)
                {
                    if(item.Posicionn is Jugador.Posicion.Arquero)
                    {
                        if(!flag[0])
                        {
                            contadorValidacion++;
                            flag[0] = true;
                        }
                        contArquero++;
                    }else if (item.Posicionn is Jugador.Posicion.Defensor && !flag[1])
                    {
                        contadorValidacion++;
                        flag[1] = true;
                    }
                    else if (item.Posicionn is Jugador.Posicion.Central && !flag[2])
                    {
                        contadorValidacion++;
                        flag[2] = true;
                    }
                    else if (item.Posicionn is Jugador.Posicion.Delantero && !flag[3])
                    {
                        contadorValidacion++;
                        flag[3] = true;
                    }

                }

                if(contArquero == 1 && flag[0] && flag[1] && flag[2] && flag[3] )
                {
                    return true;
                }
            }
            return false;
        }
    }
}
