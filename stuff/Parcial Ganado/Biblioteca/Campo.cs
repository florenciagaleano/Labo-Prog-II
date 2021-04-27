using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Campo
    {
        public enum ETipo
        {
            Pastoreo,
            Engorde
        }

        private int alimentoDisponible;
        private List<Animal> animales;
        private static ETipo tipo;

        static Campo()
        {
            Campo.tipo = ETipo.Engorde;
        }

        private Campo()
        {
            this.animales = new List<Animal>();
        }

        public Campo(int alimento)
            :this()
        {
            this.alimentoDisponible = alimento;
        }

        public static ETipo TipoServicio
        {
            set
            {
                Campo.tipo = value;
            }
        }

        public static bool operator +(Campo campo,Animal animal)
        {
            if(campo.alimentoDisponible > campo.AlimentoComprometido(animal))
            {
                campo.animales.Add(animal);
                return true;
            }

            return false;
        }

        private int AlimentoComprometido()
        {
            int acumulador = 0;
            foreach (Animal item in this.animales)
            {
                acumulador += item.KilosAlimento;
            }

            return acumulador;
        }

        private int AlimentoComprometido(Animal animal)
        {
            return AlimentoComprometido() + animal.KilosAlimento;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Servicio del campo: {Campo.tipo}");
            sb.AppendLine($"Alimento Comprometido: {this.AlimentoComprometido()}");
            sb.AppendLine("LISTA ANIMALES:");
            foreach (Animal item in this.animales)
            {
                sb.AppendLine(item.Datos());
            }

            return sb.ToString();
        }
    }
}
