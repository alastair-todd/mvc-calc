using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests.Components
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CanAddTwoNumbers()
        {
            var expr = "2+2";

            var result = new Domain.Core.Calculator().Calc(expr);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TyposThrowAnError()
        {
            var expr = "2+oups";

            var result = new Domain.Core.Calculator().Calc(expr);

            Assert.AreEqual(4, result);
        }
    }
}
