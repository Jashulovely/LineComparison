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
            Console.WriteLine("Enter the coordinates of the Line.");
            Console.WriteLine("Enter x1 : ");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1 : ");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x2 : ");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2 : ");
            int y2 = int.Parse(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
            Console.WriteLine("The lenth of the line is : " + length);
        }
    }
}
