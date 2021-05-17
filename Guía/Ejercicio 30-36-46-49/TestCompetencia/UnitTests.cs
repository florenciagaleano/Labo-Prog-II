using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Ejercicio_30_36_46_49;

namespace TestCompetencia
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ListaVehiculosInstanciada()
        {
            //arrange
            Competencia<VehiculoDeCarrera> c = new Competencia<VehiculoDeCarrera>(8,4,Competencia<VehiculoDeCarrera>.TipoCompetencia.F1);
            //add

            //assert
            Assert.IsNotNull(c.Vehiculos);
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Excepcion_Al_agregar_Vehiculo_No_Del_Tipo_Competencia()
        {
            //arrange
            Competencia<VehiculoDeCarrera> c = new Competencia<VehiculoDeCarrera>(8, 4, Competencia<VehiculoDeCarrera>.TipoCompetencia.F1);
            MotoCross m = new MotoCross(8, "NoConozco");
            //add
            bool ok = c + m;
        }

       /* [TestMethod]
        public void No_Excepcion_Carrera_Motocross()
        {
            //arrange
            Competencia c = new Competencia(8, 4, Competencia.TipoCompetencia.MotoCross);
            MotoCross m = new MotoCross(8, "NoConozco");
            //add
            bool ok = c + m;
            //assert
            Assert.IsTrue(ok);
        }*/
    }
}
