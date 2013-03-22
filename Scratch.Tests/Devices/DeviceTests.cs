using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scratch.Models.Devices;
using Scratch.Services;
using Scratch.Controllers;
using System.Web.Mvc;
using Scratch.Models.Transactions;

namespace Scratch.Tests.Devices
{
    [TestClass]
    public class DeviceTests
    {
        public DeviceTests()
        {
        }

        [TestMethod]
        public void Our_Device_Test()
        {
            IDevice device = new OurDevice();

            // Arrange
            var controller = new DeviceController(device);

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Scratch.Models.Devices.OurDevice", result.ViewBag.DeviceTypeName);
        }

        [TestMethod]
        public void Their_Device_Test()
        {
            IDevice device = new TheirDevice();

            // Arrange
            var controller = new DeviceController(device);

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Scratch.Models.Devices.TheirDevice", result.ViewBag.DeviceTypeName);
        }
    }
}
