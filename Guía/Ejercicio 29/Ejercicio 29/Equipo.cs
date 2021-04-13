using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad,string nombre)
            :this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        /*La sobrecarga del operador + agregará jugadores a la lista siempre y cuando este no exista
        aun en el equipo y la cantidad de jugadores no supere el límite establecido por el atributo
        cantidadDeJugadores.*/
        public static bool operator +(Equipo e, Jugador j)
        {
            if(e.jugadores.Count < e.cantidadDeJugadores)
            {
                foreach (Jugador item in e.jugadores)
                {
                    //    cuando hacia el Add no andaba porque como era diferente al 1ero ya entraba y lo agregaba
                    if(item == j)
                    {
                        return false;
                    }
                }

                e.jugadores.Add(j);
                return true;
            }

            return false;
            
        }


    }
}
