using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Test_SumOfAll()
        {
            // Arrange
            decimal exampleLouis = 53.54M;
            decimal exampleCarter = 50.23M;
            decimal exampleDavid = 113.41M;
            decimal expected = 217.18M;



            // Act
            decimal actual = SumOfAll(exampleLouis, exampleCarter, exampleDavid);

            // Assert
            Assert.AreEqual(expected, actual);


        }

        public static decimal SumOfAll(decimal x, decimal y, decimal z)
        {
            return x + y + z;
        }
    }
}
