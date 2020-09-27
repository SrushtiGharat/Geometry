using System;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            String[] point;

            Console.WriteLine("Enter point 1 of Line1 separated by comma");
            point = Console.ReadLine().Split(",");
            int x1 = Convert.ToInt32(point[0]);
            int y1 = Convert.ToInt32(point[1]);

            Console.WriteLine("Enter point 2 of Line1 separated by comma");
            point = Console.ReadLine().Split(",");
            int x2 = Convert.ToInt32(point[0]);
            int y2 = Convert.ToInt32(point[1]);

            Console.WriteLine("Enter point 1 of Line2 separated by comma");
            point = Console.ReadLine().Split(",");
            int p1 = Convert.ToInt32(point[0]);
            int q1 = Convert.ToInt32(point[1]);

            Console.WriteLine("Enter point 2 of Line2 separated by comma");
            point = Console.ReadLine().Split(",");
            int p2 = Convert.ToInt32(point[0]);
            int q2 = Convert.ToInt32(point[1]);

            double lengthOfLine1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double lengthOfLine2 = Math.Sqrt(Math.Pow((p2 - p1), 2) + Math.Pow((q2 - q1), 2));
            
            if (lengthOfLine1.Equals(lengthOfLine2))
            {
                Console.WriteLine("The two lines are equal");
            }
            else
            {
                Console.WriteLine("The two lines are not equal");
            }


        }
    }
}
