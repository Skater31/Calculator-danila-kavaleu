using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Calculator1.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void Add()
        {
            var mainWindow = new MainWindow();

            var result = main

            Assert.AreEqual(2, Equal_Click.Add(1, 1));
            Assert.AreEqual(1.42, calculator.Add(3.14, -1.72), 0.001);
            Assert.AreEqual(2.0 / 3, calculator.Add(1.0 / 3, 1.0 / 3), 0.001);
        }

        //[TestMethod]
        //public void Subtract()
        //{
        //    Assert.AreEqual(0, calculator.Subtract(1, 1));
        //    Assert.AreEqual(4.86, calculator.Subtract(3.14, -1.72), 0.001);
        //    Assert.AreEqual(2.0 / 3, calculator.Subtract(1.0 / 3, -1.0 / 3), 0.001);
        //}

        //[TestMethod]
        //public void Multiply()
        //{
        //    Assert.AreEqual(2, calculator.Multiply(1, 2));
        //    Assert.AreEqual(-5.4008, calculator.Multiply(3.14, -1.72), 0.001);
        //    Assert.AreEqual(0.111, calculator.Multiply(1.0 / 3, 1.0 / 3), 0.001);
        //}

        //[TestMethod]
        //public void Divide()
        //{
        //    Assert.AreEqual(2, calculator.Divide(4, 2));
        //    Assert.AreEqual(-1.826, calculator.Divide(3.14, -1.72), 0.001);
        //    Assert.AreEqual(1, calculator.Divide(1.0 / 3, 1.0 / 3));
        //}

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void DivideException()
        //{
        //    Equal_Click.Divide(2, 0);
        //}
    }
}
