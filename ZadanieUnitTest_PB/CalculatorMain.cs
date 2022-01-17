using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieUnitTest_PB
{
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
            else if (delta == 1)
            {
                delta = (Math.Sqrt(delta));
                x0 = -b / (2 * a);
                Console.WriteLine("Jeden pierwiastek rzeczywisty: " + x0);
                return "Dwa pierwiastki rzeczywiste";
            }
            else
                Console.WriteLine("Brak pierwiastkow");


            return a.ToString();
            return b.ToString();
            return c.ToString();

        }
        }
}
