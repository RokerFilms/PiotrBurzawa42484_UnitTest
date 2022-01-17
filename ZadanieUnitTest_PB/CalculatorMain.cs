using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieUnitTest_PB
{


    //Ponizej klasa przeznaczona dla wyjscia Assert.That dla string


    public class CalculatorMain
        {
        public double x1, x2, x0;
            public string Delta(double a, double b, double c)
            {
                double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                delta = (Math.Sqrt(delta));
                x1 = (-b - delta) / (2 * a);
                x2 = (-b + delta) / (2 * a);
                Console.WriteLine("Sa dwa pierwiastki: " + x1 + " oraz " + x2);
                return "Dwa pierwiastki rzeczywiste";
            }
            else if (delta == 0)
            {
                delta = (Math.Sqrt(delta));
                x0 = -b / (2 * a);
                Console.WriteLine("Jeden pierwiastek rzeczywisty: " + x0);
                return "Jeden pierwiastek rzeczywisty";
            }
            else
                Console.WriteLine("Brak pierwiastkow");
                return "Brak pierwiastkow rzeczywistych";


            return a.ToString();
            return b.ToString();
            return c.ToString();

        }
        }





    //Ponizej klasa przeznaczona dla wyjscia Assert.AreEqual z uzyciem int




    public class CalculatorInt
    {
        public double x1, x2, x0;
        public int Delta(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                delta = (Math.Sqrt(delta));
                x1 = (-b - delta) / (2 * a);
                x2 = (-b + delta) / (2 * a);
                Console.WriteLine("Sa dwa pierwiastki: " + x1 + " oraz " + x2);
                return 2;
            }
            else if (delta == 0)
            {
                delta = (Math.Sqrt(delta));
                x0 = -b / (2 * a);
                Console.WriteLine("Jeden pierwiastek rzeczywisty: " + x0);
                return 1;
            }
            else
                Console.WriteLine("Brak pierwiastkow");
            return 0;


        }
    }








    //Ponizej klasy przeznaczone dla wyjscia Assert.IsTrue dla boolean






    public class CalculatorBooleanForDwa
    {
        public double x1, x2, x0;
        public bool Delta(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                delta = (Math.Sqrt(delta));
                x1 = (-b - delta) / (2 * a);
                x2 = (-b + delta) / (2 * a);
                Console.WriteLine("Sa dwa pierwiastki: " + x1 + " oraz " + x2);
                return true;
            }
            else
                return false;

        }



        public class CalculatorBooleanForJeden
        {
            public double x1, x2, x0;
            public bool Delta(double a, double b, double c)
            {
                double delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    delta = (Math.Sqrt(delta));
                    x0 = -b / (2 * a);
                    Console.WriteLine("Jeden pierwiastek rzeczywisty: " + x0);
                    return true;
                }
                else
                    return false;

            }
        }



        public class CalculatorBooleanForBrak
        {
            public double x1, x2, x0;
            public bool Delta(double a, double b, double c)
            {
                double delta = b * b - 4 * a * c;
                if (delta > 0 || delta == 0)
                {
                    return true;
                }
                else
                    Console.WriteLine("Brak pierwiastkow rzeczywistych");
                    return false;

            }
        }




    }
    }
