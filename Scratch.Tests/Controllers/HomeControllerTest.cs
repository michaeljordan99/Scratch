using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scratch;
using Scratch.Controllers;
using Scratch.Repositories;
using Scratch.Services;
using Scratch.Tests.Mocks;

namespace Scratch.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            IMessageService service = new MessageServiceMock();

            // Arrange
            HomeController controller = new HomeController(service);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Home Controller Message from Mock", result.ViewBag.Message);
        }

        [TestMethod]
        public void About()
        {
            IRepository repository = new Repository();

            IMessageService service = new MessageService(repository);

            // Arrange
            HomeController controller = new HomeController(service);

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
