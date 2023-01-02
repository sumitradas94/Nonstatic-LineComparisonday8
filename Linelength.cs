using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linecomparisonproblem
{
    public class Linelength
    {
        public static void length()
        {
            /* A Length as 2 Points(x1, y1) and(x2, y2) - 
                 Length of a Line = sqrt((x2 - x1) ^ 2 + (y2- y1) ^ 2)
                 */
            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            double Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(Length);
        }
    }
}

