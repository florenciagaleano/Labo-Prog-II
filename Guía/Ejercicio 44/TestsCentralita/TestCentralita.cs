using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CentralitaHerencia;

namespace TestsCentralita
{
    [TestClass]
    public class TestCentralita
    {
        [TestMethod]
        public void Lista_De_Llamadas_Esta_Instanciada()
        {
            //Arrange
            Centralita c = new Centralita();
            //Add

            //Assert
            Assert.AreNotEqual(c.Llamadas, null);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void Excepcion_Segunda_Llamada_Mismo_Origen_Y_Destino_Provincial()
        {
            //arrange
            Centralita c = new Centralita();
            Provincial p1 = new Provincial("1234", Provincial.Franja.Franja_1, 60, "4523056");
            Provincial p2 = new Provincial("1234", Provincial.Franja.Franja_2, 70, "4523056");
            //add
            c = c + p1;
            c = c + p2;

            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void Excepcion_Segunda_Llamada_Mismo_Origen_Y_Destino_Local()
        {
            //arrange
            Centralita c = new Centralita();
            Local l1 = new Local("123", 45, "8910", 100);
            Local l2 = new Local("123", 7, "8910", 200);
            //add
            c = c + l1;
            c = c + l2;

            //assert
        }

        [TestMethod]
        public void Instancias_Iguales()//malismo el nombre
        {
            //Arrange
            Local l1 = new Local("123", 45, "8910", 100);
            Local l2 = new Local("123", 45, "8910", 200);
            Provincial p1 = new Provincial("123", Provincial.Franja.Franja_1, 45, "8910");
            Provincial p2 = new Provincial("123", Provincial.Franja.Franja_2, 45, "8910");
            //Add
            //Assert
            Assert.AreEqual(l1, l2);
            Assert.AreEqual(p1, p2);
            Assert.AreNotEqual(l1, p1);
            Assert.AreNotEqual(l2, p2);
            Assert.AreNotEqual(l1, p2);
            Assert.AreNotEqual(l2, p1);

        }
    }
}
