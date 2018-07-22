using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPIPoliza;
using System.Web.Http;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.Net.Http.Formatting;
using DataAccessPoliza;

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
        }

        [TestMethod]
        public void TestSavePoliza()
        {

            // Arrange
            var controller = new WebAPIPoliza.Controllers.PolizaController();

            Poliza poliza = new Poliza();

            poliza.nombre = "Poliza Veìcular";
            poliza.descripcion = "Poliza";
            poliza.idTipoCubrimiento = 1;
            poliza.idTipoRiesgo = 1;
            poliza.porcentajeCubrimiento = 50;
            poliza.inicioVigencia = DateTime.Now;
            poliza.periodoCobertura = 22;
            poliza.precio = 12500032;



            // Act
            var response = controller.PostPoliza(poliza);

            // Assert

            Assert.IsNotNull(response);
        }
    }
}
