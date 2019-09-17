using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = @"1.One day, a father and his little son were going home. At this age, the boy was interested in all kinds of things and was always asking questions. 2.Now, he asked, 'What's the meaning of the word 'Drunk', dad?' 'Well, my son,' his father replied, 'look, there are standing two policemen. 3.If I regard the two policemen as four then I am drunk.'";
            int ch = 0; //字母的数量
            int sp = 0; //空格的数量
            int num = 0; //数字的数量
            int other = 0; //其它字符的数量
            char[] c = s.ToCharArray(); //把字符串转换成字符数组
            foreach (char i in c)
            {
                if ((i >= 'a' && i <= 'z') || (i >= 'A' && i <= 'Z'))
                {
                    ch++;
                }
                else if (i >= '0' && i <= '9')
                {
                    num++;
                }
                else if (i == ' ')
                {
                    sp++;
                }
                else other++;
            }
            Console.WriteLine("英文字母有{0}个，空格有{1}个，数字有{2}个，其他字符有{3}个。", ch, sp, num, other);
            Console.ReadLine();
        }
    }
}
