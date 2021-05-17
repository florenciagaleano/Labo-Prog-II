using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_30_36_46_49;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia<VehiculoDeCarrera> c = new Competencia<VehiculoDeCarrera>(10, 3, Competencia<VehiculoDeCarrera>.TipoCompetencia.F1);
            List<VehiculoDeCarrera> lista = new List<VehiculoDeCarrera>();
            VehiculoDeCarrera[] autos = new VehiculoDeCarrera[6];
            try
            {
                autos[0] = new AutoF1(1, "Toyota", 8);
                autos[1] = new AutoF1(1, "Toyota", 8);
                autos[2] = new MotoCross(3, "Chevrolet", 9);
                autos[3] = new AutoF1(4, "Mercedes", 7);
                autos[4] = new AutoF1(5, "Ford", 5);

                for (int i = 0; i < 5; i++)
                {
                    bool seAgrego = c + autos[i];
                }

            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }
            //bool borro = c - autos[0];
            Console.WriteLine(c.MostrarDatos());
            Console.ReadKey();
        }
    }
}
