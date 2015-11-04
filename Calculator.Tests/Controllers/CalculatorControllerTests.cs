using System.Web.Mvc;
using Calculator.Domain.Contracts;
using Calculator.Presentation.Controllers;
using Calculator.Presentation.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Calculator.Tests.Controllers
{
    [TestClass]
    public class CalculatorControllerTests
    {
        [TestMethod]
        [TestCategory("Controllers")]
        public void CalculatorIndex()
        {
            // Arrange
            var mock = new Mock<ICalculator>();

            mock.Setup(calc => calc.Calc(It.IsAny<string>())).Returns(4);

            ICalculator calculator = mock.Object;
            CalculatorController controller = new CalculatorController(calculator);

            // Act
            ViewResult result = controller.Calculate(new MathsView()) as ViewResult;

            // Assert
            Assert.AreEqual("4", (result.Model as MathsView).Result);
        }
    }
}
