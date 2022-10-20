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

        private readonly MainWindow _mainWindow = new MainWindow();

        [TestMethod()]
        public void Plus()
        {
            var number1 = 1;

            var number2 = 2;

            var op = "+";

            var result = $"{number1}{op}{number2}";

            Assert.AreEqual(3, result);
        }
    }
}