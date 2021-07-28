using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Archivos;
using System.IO;

namespace TestsUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArchivoInvalidoException))]
        public void Proueba_Archivo_Invalido_Exception()
        {
            Xml<CentroDeVacunacion> xml = new Xml<CentroDeVacunacion>();

            xml.Leer("hola");//paso ruta inexistente
        }
        
    }
}
