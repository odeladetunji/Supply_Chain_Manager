using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Supply_Manager;
using Supply_Manager.Controllers;

namespace Supply_Manager.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = (ViewResult)controller.Index();

            System.Reflection.AssemblyName mvcName = typeof(Controller).Assembly.GetName();
            bool isMono = Type.GetType("Mono.Runtime") != null;

            string expectedVersion = mvcName.Version.Major + "." + mvcName.Version.Minor;
            string expectedRuntime = isMono ? "Mono" : ".NET";

            // Assert
            Assert.AreEqual(expectedVersion, result.ViewData["Version"]);
            Assert.AreEqual(expectedRuntime, result.ViewData["Runtime"]);
        }
    }
}
