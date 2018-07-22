using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPIPoliza;
using System.Web.Http;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.Net.Http.Formatting;

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

        [TestMethod]
        public void TestGetAllPolizas()
        {

            var config = new HttpConfiguration();
            //configure web api
            config.MapHttpAttributeRoutes();

            using (var server = new HttpServer(config))
            {

                var client = new HttpClient(server);

                string url = "http://localhost:60741/api/Poliza";

                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri(url),
                    Method = HttpMethod.Get
                };

                //request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                using (var response = client.SendAsync(request))
                {
                    Assert.AreEqual(HttpStatusCode.OK, response.Status);
                }
            }
        }
    }
}
