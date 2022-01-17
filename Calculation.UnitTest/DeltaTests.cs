using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ZadanieUnitTest_PB;

namespace Calculation.UnitTest
{
    class DeltaTests
    {
        [Test]
        public void CheckDelta()
        {
            double x1, x2, x0;

            double a = 4;
            double b = 5;
            double c = 3;

            //arrange
            var cm = new CalculatorMain();

            //act
            var delta = cm.Delta(a, b, c);

            //assert
            Assert.AreEqual(2, delta);
        }
    }
}
