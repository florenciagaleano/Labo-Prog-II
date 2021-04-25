using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        public enum Posicion
        {
            Arquero,
            Defensor,
            Central,
            Delantero,
        }

        private float altura;
        private float peso;
        private Posicion posicion;

        public Jugador(string nombre, string apellido, int edad, int dni,float peso, float altura, Posicion posicion)
            : base(apellido, dni, edad, nombre)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        public float Peso
        {
            get
            {
                return this.peso;
            }
        }

        public Jugador.Posicion Posicionn
        {
            get
            {
                return this.posicion;
            }
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.Append((this.Peso).ToString());
            sb.Append((this.Altura).ToString());
            sb.Append((this.Posicionn).ToString());

            return sb.ToString();
        }

        //IMC = peso / altura^2 entre 18.5 y 25
        public bool ValidarEstadoFisico()
        {
            double aCuadrado = Math.Pow(this.Altura, 2);
            double masaMusucular = this.Peso / aCuadrado;

            if (masaMusucular < 18.5 || masaMusucular > 25)
            {
                return false;
            }

            return true;
        }

        public override bool ValidarAptitud()
        {
            if(this.ValidarEstadoFisico() && this.Edad < 40)
            {
                return true;
            }

            return false;
        }
    }
}
