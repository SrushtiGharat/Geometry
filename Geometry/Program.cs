using System;

namespace Geometry
{
    class Point
    {
        int x;
        int y;
        public Point()
        {
            x = 0; y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getX()
        {
            return this.x;
        }
        public int getY()
        {
            return this.y;
        }

    }
    class Line
    {
        Point p1;
        Point p2;
        public Line()
        {
        }
        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
        public double CalculateLength()
        {
            double lengthOfLine = Math.Sqrt(Math.Pow((p2.getX() - p1.getX()), 2) + Math.Pow((p2.getY() - p1.getY()), 2));
            return lengthOfLine;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Line Comparison Computation Program");
            string[] point;

            Console.WriteLine("Enter co-ordintnates of Line1 separated by comma (x1,y1,x2,y2)");
            point = Console.ReadLine().Split(",");
            int x1 = Convert.ToInt32(point[0]);
            int y1 = Convert.ToInt32(point[1]);
            int x2 = Convert.ToInt32(point[2]);
            int y2 = Convert.ToInt32(point[3]);

            Point P1 = new Point(x1, y1);
            Point P2 = new Point(x2, y2);

            Console.WriteLine("Enter co-ordinates of Line2 separated by comma (x1,y1,x2,y2)");
            point = Console.ReadLine().Split(",");
            int p1 = Convert.ToInt32(point[0]);
            int q1 = Convert.ToInt32(point[1]);
            int p2 = Convert.ToInt32(point[2]);
            int q2 = Convert.ToInt32(point[3]);

            Point P3 = new Point(p1, q1);
            Point P4 = new Point(p2, q2);

            Line l1 = new Line(P1, P2);
            Line l2 = new Line(P3, P4);

            int compare = l1.CalculateLength().CompareTo(l2.CalculateLength());
            if (compare > 0)
            {
                Console.WriteLine("Line1 is greater than Line2");
            }
            else if (compare < 0)
            {
                Console.WriteLine("Line2 is greater than Line1");
            }
            else
            {
                Console.WriteLine("Both Lines are equal");
            }
        }

    }
}

