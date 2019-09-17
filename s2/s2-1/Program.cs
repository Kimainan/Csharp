using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            for (int i = 100; i <= 999; i++)
            {
                a = i % 10; //个位数字
                b = i / 10 % 10; //十位数字
                c = i / 100; //百位数字
                if (Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3) == i)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
