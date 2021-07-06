using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Archivos;
using Entidades;

namespace TestsUnitarios
{
    [TestClass]
    public class Prueba
    {
        [TestMethod]
        public void Test_Guardar_Xml()
        {
            Xml<Planeta> xml = new Xml<Planeta>();
            Planeta p = new Planeta(3,2,5,null);
            Planeta aux = new Planeta();

            xml.Guardar("prueba", p);
            xml.Leer("prueba", out aux);
           
            Assert.IsTrue(p.Equals(aux));
        }
    }
}
