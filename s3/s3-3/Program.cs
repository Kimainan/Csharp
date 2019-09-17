using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s3_3
{
    public class Account
    {
        private decimal saving;
        //默认构造函数
        public Account()
        {
            this.saving = 100;
        }
        public Account(decimal saving)
        {
            this.saving = saving;
        }
        //存款
        public void depositMoney(decimal money)
        {
            if (money > 0)
            {
                saving += money;
                Console.WriteLine("存款成功！本次存款{0}，余额为{1}", money, saving);
            }
            else
            {
                Console.WriteLine("存款数必须大于0！");
            }
        }
        //取款
        public void drawMoney(decimal money)
        {
            if (money > saving)
            {
                Console.WriteLine("取款数大于余额，取款失败！\n当前余额为:{0}", saving);
            }
            else
            {
                saving -= money;
                Console.WriteLine("取款成功!本次取款{0}，余额为{1}", money, saving);
            }
        }
        public decimal Saving
        {
            get { return saving; }
            private set { }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account account;
            Console.WriteLine("请放入存款以便开户：");
            decimal money = Convert.ToDecimal(Console.ReadLine());
            while (money < 100)
            {
                Console.WriteLine("开户失败，最低存款额为100！");
                Console.WriteLine("输入任意键继续...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("请放入存款以便开户：");
                money = Convert.ToDecimal(Console.ReadLine());
            }
            account = new Account(money);
            Console.WriteLine("开户成功！当前账户余额为{0}。", account.Saving);
            Console.WriteLine("输入任意键继续...");
            Console.ReadKey();
            Console.Clear();
            while (true)
            {
                Console.WriteLine("\n**********欢迎光临**********");
                Console.WriteLine("  1.存款");
                Console.WriteLine("  2.取款");
                Console.WriteLine("  3.查询");
                Console.WriteLine("  4.退出");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("请放入存款数：");
                        money = Convert.ToDecimal(Console.ReadLine());
                        account.depositMoney(money);
                        break;
                    case "2":
                        Console.WriteLine("请输入取款数：");
                        money = Convert.ToDecimal(Console.ReadLine());
                        account.drawMoney(money);
                        break;
                    case "3":
                        Console.WriteLine("当前存款余额是{0}", account.Saving);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("指令输入错误！");
                        break;
                }
                Console.WriteLine("输入任意键继续...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
