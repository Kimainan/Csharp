using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s4_1
{
    public abstract class Vehicle
    {
        public abstract string NoOfWheels();//抽象方法，该方法没有实现部分
    }
    public class Car : Vehicle
    {
        public override string NoOfWheels()
        {
            return "四轮车";
        }
    }
    public class Motorbike : Vehicle
    {
        public override string NoOfWheels()
        {
            return "双轮车";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Motorbike motorbike = new Motorbike();
            Console.WriteLine("car：" + car.NoOfWheels());
            Console.WriteLine("motorbike：" + motorbike.NoOfWheels());
            Console.ReadLine();
        }
    }
}
