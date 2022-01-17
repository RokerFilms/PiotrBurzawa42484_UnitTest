using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ZadanieUnitTest_PB;

namespace Calculation.UnitTest
{
    class DeltaTests
    {

        // TEST dla mozliwosci Assert.That



        [Test]
        public void Delta_String_WhenReturnDwa()
        {
            double x1, x2, x0;

            double a = 6;
            double b = 10;
            double c = -1;

            //arrange
            var cm = new CalculatorMain();

            //act
            var delta = cm.Delta(a, b, c);


            //assert 

            Assert.That(delta, Is.EqualTo("Dwa pierwiastki rzeczywiste"));
        }
        [Test]
        public void Delta_String_WhenReturnJeden()
        {
            double x1, x2, x0;

            double a = 1;
            double b = -2;
            double c = 1;

            //arrange
            var cm = new CalculatorMain();

            //act
            var delta = cm.Delta(a, b, c);


            //assert 

            Assert.That(delta, Is.EqualTo("Jeden pierwiastek rzeczywisty"));

        }


        [Test]
        public void Delta_String_WhenReturnBrak()
        {
            double x1, x2, x0;

            double a = 2;
            double b = 1;
            double c = 2;

            //arrange
            var cm = new CalculatorMain();

            //act
            var delta = cm.Delta(a, b, c);


            //assert 

            Assert.That(delta, Is.EqualTo("Brak pierwiastkow rzeczywistych"));

        }



        //Testy dla mozliwosci Assert.Equal

        [Test]
        public void Delta_Int_WhenReturnBrak()
        {
            double x1, x2, x0;

            double a = 1;
            double b = -2;
            double c = 1;

            //arrange
            var cm = new CalculatorInt();

            //act
            var delta = cm.Delta(a, b, c);


            //assert

            Assert.AreEqual(1, delta);

        }

        [Test]
        public void Delta_Int_WhenReturnJeden()
        {
            double x1, x2, x0;

            double a = 2;
            double b = 1;
            double c = 2;

            //arrange
            var cm = new CalculatorInt();

            //act
            var delta = cm.Delta(a, b, c);


            //assert

            Assert.AreEqual(0, delta);

        }


        [Test]
        public void Delta_Int_WhenReturnDwa()
        {
            double x1, x2, x0;

            double a = 6;
            double b = 10;
            double c = -1;

            //arrange
            var cm = new CalculatorInt();

            //act
            var delta = cm.Delta(a, b, c);


            //assert

            Assert.AreEqual(2, delta);

        }


// TEST dla mozliwosci Assert.IsTrue


        [Test]
        public void Delta_Bool_WhenReturnDwa()
        {
            double x1, x2, x0;

            double a = 6;
            double b = 10;
            double c = -1;

            //arrange
            var cm = new CalculatorBooleanForDwa();

            //act
            var delta = cm.Delta(a, b, c);


            //assert

            Assert.IsTrue(delta);

        }

        [Test]
        public void Delta_Bool_WhenReturnJeden()
        {
            double x1, x2, x0;

            double a = 6;
            double b = 10;
            double c = -1;

            //arrange
            var cm = new CalculatorBooleanForDwa.CalculatorBooleanForJeden();

            //act
            var delta = cm.Delta(a, b, c);


            //assert

            Assert.IsTrue(delta);

        }

    


    [Test]
    public void Delta_Bool_WhenReturnBrak()
    {
        double x1, x2, x0;

        double a = 3;
        double b = 3;
        double c = 3;

        //arrange
        var cm = new CalculatorBooleanForDwa.CalculatorBooleanForBrak();

        //act
        var delta = cm.Delta(a, b, c);


        //assert

        Assert.IsFalse(delta);

    }

}






}






