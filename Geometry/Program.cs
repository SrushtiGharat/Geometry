using System;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        { 
            String[] point;
            
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            Console.WriteLine("Enter point 1 separated by comma");
            point = Console.ReadLine().Split(",");
            int x1 = Convert.ToInt32(point[0]);
            int y1 = Convert.ToInt32(point[1]);

            Console.WriteLine("Enter point 2 separated by comma");
            point = Console.ReadLine().Split(",");
            int x2 = Convert.ToInt32(point[0]);
            int y2 = Convert.ToInt32(point[1]);

            double length = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
            Console.WriteLine("The Length of the line is :" + length);




        }
    }
}
