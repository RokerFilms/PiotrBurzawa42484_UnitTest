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
        public void Delta_WhenReturnDelta()
        {
            double x1, x2, x0;

            double a = 6;
            double b = 10;
            double c = -1;

            //arrange
            var cm = new CalculatorMain();

            //act
            var delta = cm.Delta(a, b, c);


            //assert oraz metoda

            Assert.That(delta, Is.EqualTo("Dwa pierwiastki rzeczywiste"));







        }
    }
}
