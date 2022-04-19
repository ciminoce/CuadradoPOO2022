using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CuadradoPOO2022.Entidades;

namespace CuadradoPOO2022.Testing
{
    [TestClass]
    public class CuadradoTesting
    {
        [TestMethod]
        public void CuadradoEsValido()
        {
            //Arrange
            int valorLado = 10;
            //Act
            Cuadrado c=new Cuadrado(valorLado);
            //Assert
            Assert.IsTrue(c.Validar());
        }
        [TestMethod]
        public void CuadradoNoEsValido()
        {
            //Arrange
            int valorLado = -10;
            //Act
            Cuadrado c = new Cuadrado(valorLado);
            //Assert
            Assert.IsFalse(c.Validar());
        }
        [TestMethod]
        public void CuadradoGetPerimetro()
        {
            //Arrange
            int valorLado = 10;
            //Act
            Cuadrado c = new Cuadrado(valorLado);
            //Assert
            Assert.AreEqual(40,c.GetPerimetro());
        }
        [TestMethod]
        public void CuadradoGetSuperficie()
        {
            //Arrange
            int valorLado = 10;
            //Act
            Cuadrado c = new Cuadrado(valorLado);
            //Assert
            Assert.AreEqual(100, c.GetSuperficie());
        }
    }
}
