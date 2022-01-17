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
        public void Delta_WhenReturnDwa()
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
        [Test]
        public void Delta_WhenReturnJeden()
        {
            double x1, x2, x0;

            double a = 1;
            double b = -2;
            double c = 1;

            //arrange
            var cm = new CalculatorMain();

            //act
            var delta = cm.Delta(a, b, c);


            //assert oraz metoda

            Assert.That(delta, Is.EqualTo("Jeden pierwiastek rzeczywisty"));

        }


        [Test]
        public void Delta_WhenReturnBrak()
        {
            double x1, x2, x0;

            double a = 2;
            double b = 1;
            double c = 2;

            //arrange
            var cm = new CalculatorMain();

            //act
            var delta = cm.Delta(a, b, c);


            //assert oraz metoda

            Assert.That(delta, Is.EqualTo("Brak pierwiastkow rzeczywistych"));

        }


    }
}
