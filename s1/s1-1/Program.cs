using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            string s = Console.ReadLine();
            while (s != "q")
            {
                int temp = Convert.ToInt32(s);
                if (temp > max)
                {
                    max = temp;
                }
                s = Console.ReadLine();
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
