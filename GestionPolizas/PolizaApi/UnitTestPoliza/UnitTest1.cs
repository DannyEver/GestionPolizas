using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPIPoliza;

namespace UnitTestPoliza
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAllPolizas()
        {

            // Arrange
            var controller = new WebAPIPoliza.Controllers.PolizaController();

            // Act
            var listPolizas = controller.GetPolizas();

            // Assert

            Assert.IsNotNull(listPolizas);
            Assert.IsNotNull(listPolizas.Count);
        }
    }
}
