using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineModelling
{
    public class Length
    {
        public static void CalculateLength()
        {
            Console.WriteLine("Give the coordinates of the two points that make Line 2");
            Console.WriteLine("Enter x1 for Line 1: ");
            int x1_line1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 for Line 1: ");
            int y1_line1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 for Line 1: ");
            int x2_line1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 for Line 1: ");
            int y2_line1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give the coordinates of the two points that make Line 2");

            Console.WriteLine("Enter x1 for Line 2: ");
            int x1_line2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 for Line 2: ");
            int y1_line2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 for Line 2: ");
            int x2_line2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 for Line 2: ");
            int y2_line2 = Convert.ToInt32(Console.ReadLine());

            double length1 = Math.Sqrt(Math.Pow((x2_line1 - x1_line1), 2) + Math.Pow((y2_line1 - y1_line1), 2));
            double length2 = Math.Sqrt(Math.Pow((x2_line2 - x1_line2), 2) + Math.Pow((y2_line2 - y1_line2), 2));

            Console.WriteLine("Length of Line 1: " + length1);
            Console.WriteLine("Length of Line 2: " + length2);

            if (length1 == length2)
            {
                Console.WriteLine("The lengths of Line 1 and Line 2 are equal.");
            }
            else if (length1 > length2)
            {
                Console.WriteLine("Line 1 is greater in length than line 2");
            }
            else
            {
                Console.WriteLine("Line 2 is greater in length than line 1");
            }
        }
    }
}
