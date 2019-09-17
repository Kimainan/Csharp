using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s3_1
{
    public class Point
    {
        private double x;
        private double y;
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static void Distance(Point p1, Point p2)
        {
            double xx = p1.x - p2.x;
            double yy = p1.y - p2.y;
            Console.WriteLine("两点之间的距离为：");
            Console.WriteLine(Math.Sqrt(xx * xx + yy * yy));
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个点的坐标：");
            double x1 = Double.Parse(Console.ReadLine());
            double y1 = Double.Parse(Console.ReadLine());
            Point p1 = new Point(x1,y1);
            Console.WriteLine("请输入第二个点的坐标：");
            double x2 = Double.Parse(Console.ReadLine());
            double y2 = Double.Parse(Console.ReadLine());
            Point p2 = new Point(x2,y2);
            Point.Distance(p1, p2);
        }
    }
}
