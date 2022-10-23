using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1.Tests
{
    [TestClass()]
    public class MainWindowTests
    {  

        [TestMethod()]
        public void CalculateTestPlusTwoNumbers()
        {
            Assert.AreEqual(15, MainWindow.Calculate(10, 5, '+'));
        }

        [TestMethod()]
        public void CalculateTestMinusTwoNumbers()
        {
            Assert.AreEqual(5, MainWindow.Calculate(10, 5, '-'));
        }

        [TestMethod()]
        public void CalculateTestDivedTwoNumbers()
        {
            Assert.AreEqual(2, MainWindow.Calculate(10, 5, '/'));
        }

        [TestMethod()]
        public void CalculateTestRemainderOfDivisionTwoNumbers()
        {
            Assert.AreEqual(0, MainWindow.Calculate(10, 5, '%'));
        }

        [TestMethod()]
        public void CalculateTestPlusTwoMinusNumbers()
        {
            Assert.AreEqual(-10, MainWindow.Calculate(-5, -5, '+'));
        }
    }
}