using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s4_2
{
    interface IHabit
    {
        void CatchFood();
        string Food { get; set; }
        string Area { get; set; }
        string Sleep { get; set; }
        string Sociality { get; set; }
    }
    public class Cat : IHabit
    {
        private string food;
        private string area;
        private string sleep;
        private string sociality;
        public Cat(string food = null, string area = null, string sleep = null, string sociality = null)
        {
            this.food = food;
            this.area = area;
            this.sleep = sleep;
            this.sociality = sociality;            
        }
        public void CatchFood()
        {
            Console.WriteLine("Cat is catching food!");
        }
        public string Food
        {
            get { return food; }
            set { food = value; }
        }
        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        public string Sleep
        {
            get { return sleep; }
            set { sleep = value; }
        }
        public string Sociality
        {
            get { return sociality; }
            set { sociality = value; }
        }
    }
    public class Tiger : IHabit
    {
        private string food;
        private string area;
        private string sleep;
        private string sociality;
        public Tiger(string food = null, string area = null, string sleep = null, string sociality = null)
        {
            this.food = food;
            this.area = area;
            this.sleep = sleep;
            this.sociality = sociality;
        }
        public void CatchFood()
        {
            Console.WriteLine("Tiger is catching food!");
        }
        public string Food
        {
            get { return food; }
            set { food = value; }
        }
        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        public string Sleep
        {
            get { return sleep; }
            set { sleep = value; }
        }
        public string Sociality
        {
            get { return sociality; }
            set { sociality = value; }
        }
    }
    public class Lion : IHabit
    {
        private string food;
        private string area;
        private string sleep;
        private string sociality;
        public Lion(string food = null, string area = null, string sleep = null, string sociality = null)
        {
            this.food = food;
            this.area = area;
            this.sleep = sleep;
            this.sociality = sociality;
        }
        public void CatchFood()
        {
            Console.WriteLine("Lion is catching food!");
        }
        public string Food
        {
            get { return food; }
            set { food = value; }
        }
        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        public string Sleep
        {
            get { return sleep; }
            set { sleep = value; }
        }
        public string Sociality
        {
            get { return sociality; }
            set { sociality = value; }
        }
    }
    public class Elephant : IHabit
    {
        private string food;
        private string area;
        private string sleep;
        private string sociality;
        public Elephant(string food = null, string area = null, string sleep = null, string sociality = null)
        {
            this.food = food;
            this.area = area;
            this.sleep = sleep;
            this.sociality = sociality;
        }
        public void CatchFood()
        {
            Console.WriteLine("Elephant is catching food!");
        }
        public string Food
        {
            get { return food; }
            set { food = value; }
        }
        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        public string Sleep
        {
            get { return sleep; }
            set { sleep = value; }
        }
        public string Sociality
        {
            get { return sociality; }
            set { sociality = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("肉食", "散养", "多眠性", "独居");
            cat.CatchFood();
            Console.WriteLine(cat.Food);
            Console.WriteLine(cat.Area);
            Console.WriteLine(cat.Sleep);
            Console.WriteLine(cat.Sociality);

            Tiger tiger = new Tiger("捕食大型哺乳动物", "山地林栖，分布范围广", "昼伏夜出", "独居");
            tiger.CatchFood();
            Console.WriteLine(tiger.Food);
            Console.WriteLine(tiger.Area);
            Console.WriteLine(tiger.Sleep);
            Console.WriteLine(tiger.Sociality);

            Lion lion = new Lion("肉食", "生活在热带稀树草原和草地，也出现于灌木和旱林", "昼伏夜出", "群居");
            lion.CatchFood();
            Console.WriteLine(lion.Food);
            Console.WriteLine(lion.Area);
            Console.WriteLine(lion.Sleep);
            Console.WriteLine(lion.Sociality);

            Elephant elephant = new Elephant("以植物为食，食量极大", "广泛分布在非洲撒哈拉沙漠以南和南亚及东南亚，以至中国南部边境的热带及亚热带地区", "睡眠时间短", "群居");
            elephant.CatchFood();
            Console.WriteLine(elephant.Food);
            Console.WriteLine(elephant.Area);
            Console.WriteLine(elephant.Sleep);
            Console.WriteLine(elephant.Sociality);
            Console.ReadLine();
        }
    }
}
