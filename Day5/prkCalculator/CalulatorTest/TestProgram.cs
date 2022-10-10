using CalculatorModelLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using prjCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalulatorTest
{
    [TestClass]
    public class TestProgram
    {
        [TestMethod]
        public void TestCalculate()
        {
            //Arrange
            Mock<MyNumbers> mockNumbers = new Mock<MyNumbers>();
            mockNumbers.Setup(num => num.Number1).Returns(20);
            mockNumbers.Setup(num => num.Number2).Returns(10);
            //Act
            Calculator calculator = new Calculator();
            Program program = new Program(mockNumbers.Object,calculator);
            var result = program.Calculate(2);
            //Assert
            Assert.IsTrue(result);
        }
    }
}
