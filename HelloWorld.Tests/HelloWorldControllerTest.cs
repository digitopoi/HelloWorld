using System;
using System.Web.Http.Results;
using HelloWorld.WebAPI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Tests
{
    [TestClass]
    public class HelloWorldControllerTest
    {
        [TestMethod]
        public void TestGet()
        {
            //  Arrange
            var testController = new HelloWorldController();

            //  Act
            var getResult = testController.Get() as OkNegotiatedContentResult<string>;
            var stringResult = getResult.Content;

            //  Assert
            Assert.IsNotNull(getResult);
            Assert.AreEqual("Hello World", stringResult);
        }
    }
}
