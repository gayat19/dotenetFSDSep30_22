using CalculatorModelLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using prjCalculator;
using System;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CalulatorTest
{
    [TestClass]
    public class clsTestCalulator
    {
        

        //[TestMethod]
        //[TestCase(10,20)]
        //[TestCase(30,0)]
        //[TestCase(-10,40)]
        //public void TestAdd(int n1,int n2)
        //{
        //    //Arrange
        //    MyNumbers numbers = new MyNumbers() { Number1=n1, Number2=n2 };
        //    Calculator calculator = new Calculator();
        //    //Act
        //    var result = calculator.Add(numbers);
        //    //Assert
        //    Assert.AreEqual(result,30);

        //}
        [TestMethod]
        public void TestAddBasic()
        {
            //Arrange
            MyNumbers numbers = new MyNumbers() { Number1 = 10, Number2 = 20 };
            Calculator calculator = new Calculator();
            //Act
            var result = calculator.Add(numbers);
            //Assert
            Assert.AreEqual(result, 30);

        }
    }
}
