using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrigonometriLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrigonometriLibrary.Tests
{
    [TestClass()]
    public class PythagorasTests
    {
        [TestMethod()]
        public void CalculateLengthOfCTest()
        {
            // Arrange
            Pythagoras p = new Pythagoras();
            double a = 3.0;
            double b = 4.0;

            // Act
            double c = p.CalculateLengthOfC(a, b);
            
            // Assert
            Assert.AreEqual(5.0, c);
        }
    }
}