using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace s4_3
{
    public abstract class Door
    {
        public abstract void openDoor();
        public abstract void closeDoor();
    }
    interface function
    {
        void theftproof();
        void waterproof();
        void bulletproof();
        void fireproof();
        void rustproof();
    }
    public class Theftproof : Door, function
    {
        public override void openDoor()
        {
            Console.WriteLine("防盗门已打开");
        }
        public override void closeDoor()
        {
            Console.WriteLine("防盗门已关闭");
        }
        public void theftproof()
        {
            Console.WriteLine("我具有防盗功能哦");
        }
        public void waterproof()
        {
            Console.Write("");
        }
        public void bulletproof()
        {
            Console.Write("");
        }
        public void fireproof()
        {
            Console.Write("");
        }
        public void rustproof()
        {
            Console.Write("");
        }
    }
    public class Waterproof : Door, function
    {
        public override void openDoor()
        {
            Console.WriteLine("防水门已打开");
        }
        public override void closeDoor()
        {
            Console.WriteLine("防水门已关闭");
        }
        public void theftproof()
        {
            Console.Write("");
        }
        public void waterproof()
        {
            Console.WriteLine("我具有防水功能哦");
        }
        public void bulletproof()
        {
            Console.Write("");
        }
        public void fireproof()
        {
            Console.Write("");
        }
        public void rustproof()
        {
            Console.Write("");
        }
    }
    public class Bulletproof : Door, function
    {
        public override void openDoor()
        {
            Console.WriteLine("防弹门已打开");
        }
        public override void closeDoor()
        {
            Console.WriteLine("防弹门已关闭");
        }
        public void theftproof()
        {
            Console.Write("");
        }
        public void waterproof()
        {
            Console.Write("");
        }
        public void bulletproof()
        {
            Console.WriteLine("我具有防弹功能哦");
        }
        public void fireproof()
        {
            Console.Write("");
        }
        public void rustproof()
        {
            Console.Write("");
        }
    }
    public class Fireproof : Door, function
    {
        public override void openDoor()
        {
            Console.WriteLine("防火门已打开");
        }
        public override void closeDoor()
        {
            Console.WriteLine("防火门已关闭");
        }
        public void theftproof()
        {
            Console.Write("");
        }
        public void waterproof()
        {
            Console.Write("");
        }
        public void bulletproof()
        {
            Console.Write("");
        }
        public void fireproof()
        {
            Console.WriteLine("我具有防火功能哦");
        }
        public void rustproof()
        {
            Console.Write("");
        }
    }
    public class Rustproof : Door, function
    {
        public override void openDoor()
        {
            Console.WriteLine("防锈门已打开");
        }
        public override void closeDoor()
        {
            Console.WriteLine("防锈门已关闭");
        }
        public void theftproof()
        {
            Console.Write("");
        }
        public void waterproof()
        {
            Console.Write("");
        }
        public void bulletproof()
        {
            Console.Write("");
        }
        public void fireproof()
        {
            Console.Write("");
        }
        public void rustproof()
        {
            Console.WriteLine("我具有防锈功能哦");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Theftproof tpDoor = new Theftproof();
            tpDoor.openDoor();
            tpDoor.closeDoor();
            tpDoor.theftproof();
            Waterproof wpDoor = new Waterproof();
            wpDoor.openDoor();
            wpDoor.closeDoor();
            wpDoor.waterproof();
            Bulletproof bpDoor = new Bulletproof();
            bpDoor.openDoor();
            bpDoor.closeDoor();
            bpDoor.bulletproof();
            Fireproof fpDoor = new Fireproof();
            fpDoor.openDoor();
            fpDoor.closeDoor();
            fpDoor.fireproof();
            Rustproof rpDoor = new Rustproof();
            rpDoor.openDoor();
            rpDoor.closeDoor();
            rpDoor.rustproof();
            Console.ReadLine();
        }
    }
}
