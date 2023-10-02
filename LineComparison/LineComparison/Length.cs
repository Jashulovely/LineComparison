using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Length
    {
        public void LengthInfo()
        {
            int x = 0;
            int y = 0;
            Console.WriteLine("Enter end point coordinates of the Line 1.");
            Console.WriteLine("Enter x1 : ");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1 : ");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end point coordinates of the Line 2.");
            Console.WriteLine("Enter x2 : ");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2 : ");
            int y2 = int.Parse(Console.ReadLine());
            double lengthL1 = Math.Sqrt(Math.Pow((x-x1), 2) + Math.Pow((y-y1), 2));
            Console.WriteLine("The lenth of the line is : " + lengthL1);
            double lengthL2 = Math.Sqrt(Math.Pow((x - x2), 2) + Math.Pow((y - y2), 2));
            Console.WriteLine("The lenth of the line is : " + lengthL2);
            if (lengthL1 == lengthL2)
            {
                Console.WriteLine("Both lines are equal in length.");
            }
            else
            {
                Console.WriteLine("Both lines are not equal in length.");
            }
        }
    }
}
