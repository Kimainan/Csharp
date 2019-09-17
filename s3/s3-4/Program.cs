using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s3_4
{
    public class Auto
    {
        private int tyre;
        private string color;
        private double weight;  //单位t
        private double speed;   //单位km/h
        public Auto(int t = 0, string c = null, double w = 0, double s = 0)
        {
            tyre = t;
            color = c;
            weight = w;
            speed = s;
        }
        public void print()
        {
            string res = "";
            if (tyre != 0)
            {
                res += "轮胎" + Convert.ToString(tyre) + "个  ";
            }
            if (color != null)
            {
                res += color + "  ";
            }
            if (weight != 0)
            {
                res += "车身重" + Convert.ToString(weight) + "t  ";
            }
            if (speed != 0)
            {
                res += "车速为" + Convert.ToString(speed) + "km/h  ";
            }
            Console.WriteLine(res);
        }
        public void speed_up()
        {
            Console.WriteLine("Auto正在加速");
        }
        public void speed_out()
        {
            Console.WriteLine("Auto正在减速");
        }
        public void stop()
        {
            Console.WriteLine("Auto停车");
        }
    }
    public class Car : Auto
    {
        private string aircondition;
        private string CD;
        public Car(int t = 0, string c = null, double w = 0, double s = 0, string a = null, string cd = null):base(t, c, w, s)
        {
            aircondition = a;
            CD = cd;
        }
        public void print()
        {
            base.print();
            string res = "";
            if (aircondition != null)
            {
                res += "aircondition" + aircondition +"  ";
            }
            if (CD != null)
            {
                res += "CD" + CD;
            }
            Console.WriteLine(res);
        }
        public void speed_up()
        {
            Console.WriteLine("Car正在加速");
        }
        public void speed_out()
        {
            Console.WriteLine("Car正在减速");
        }
        public void stop()
        {
            Console.WriteLine("Car停车");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto(4, "black", 1.5);
            Console.WriteLine("auto1：");
            auto1.print();
            auto1.speed_up();
            auto1.speed_out();
            auto1.stop();
            Auto auto2 = new Auto(4, "white");
            Console.WriteLine("auto2：");
            auto2.print();
            auto2.speed_up();
            auto2.speed_out();
            auto2.stop();
            Auto auto3 = new Auto(4, "red", 1, 50);
            Console.WriteLine("auto3：");
            auto3.print();
            auto3.speed_up();
            auto3.speed_out();
            auto3.stop();
            Car car1 = new Car(4, "white", 1, 60, "良好", "良好");
            Console.WriteLine("car1：");
            car1.print();
            car1.speed_up();
            car1.speed_out();
            car1.stop();
            Console.ReadLine();
        }
    }
}
