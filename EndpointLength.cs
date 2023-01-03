using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linecomparisonproblem
{
    public class EndpointLength
    {
        public void Point()
        {
            double a1 = Convert.ToDouble(Console.ReadLine());
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double Lentgh1 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            Console.WriteLine(Lentgh1);

            Console.WriteLine("=====================================================");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            double Lentgh2 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(Lentgh2);

            if (Lentgh1 > Lentgh2)
            {
                Console.WriteLine("\nline1_length is greater than line2_length");
            }
            else if (Lentgh1 < Lentgh2)
            {
                Console.WriteLine("\nline1_length is less than line2_length");
            }
            else
            {
                Console.WriteLine("\nBoth lines are not equal");
            }
        }
    }
}
