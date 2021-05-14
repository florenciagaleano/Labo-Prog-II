using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculadoraString;

namespace Test_Calculadora
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Retorna_0_String_Vacio()
        {
            //Arrange
            int ret = 0;
            Calculadora c = new Calculadora();

            //Act
            ret = c.Add("");

            //Assert
            Assert.AreEqual(0, ret);
        }

        [TestMethod]
        public void Retorna_Numero_Cuando_Hay_Un_Num()
        {
            //Arrange
            int ret = 0;
            Calculadora c = new Calculadora();

            //Act
            ret = c.Add("1");

            //Assert
            Assert.AreEqual(1, ret);
        }

        [TestMethod]
        public void Retorna_Suma_Cuando_recibe_numeros_Separados_Por_Coma()
        {
            //Arrange
            int ret = 0;
            Calculadora c = new Calculadora();

            //Act
            ret = c.Add("40,3\n2");

            //Assert
            Assert.AreEqual(45, ret);
        }

        [TestMethod]
        public void Retorna_Suma_Cuando_Recibe_Cantidad_Indeterminada()
        {
            //Arrange
            int ret = 0;
            Calculadora c = new Calculadora();

            //Act
            ret = c.Add("40,3,40,7");

            //Assert
            Assert.AreEqual(90, ret);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Retorna_Suma_Cuando_Recibe_Cantidad_Nums_Y_Letras()
        {
            //Arrange
            Calculadora c = new Calculadora();

            //Act
            c.Add("40,t,kbgjh,7");

            //Assert
        }

        [TestMethod]
        public void Retorna_Suma_Delimitador_Si_Hay_Barras()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();
            // Act
            int resultado = calculadora.Add("//.1 .2,3,4");

            //Assert
            Assert.AreEqual(10, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionNegativo))]
        public void Tira_Excepcion_Si_Hay_Negativo()
        {
            //Arrange
            Calculadora calculadora = new Calculadora();
            // Act
            int resultado = calculadora.Add("1,-20");

            //Assert
            //Assert.ThrowsException<>
        }
    }
}
