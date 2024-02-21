using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public static class CSharpLevel1
    {
        public static void Practice()
        {
            //Prcatice1();
            //Practice2();
            //Practice3();
            //Practice4();
            //Practice5();
            Practice6();
        }
        public static void Prcatice1()
        {
            Console.WriteLine("Please enter your user name");
            Console.ReadLine();
            Console.WriteLine("Please enter your age");
            Console.ReadLine();
            Console.WriteLine("Please enter your class");
            Console.ReadLine();
        }
        public static void Practice2()
        {
            Console.WriteLine("Please enter your favorite sport");
            string temp = Console.ReadLine();
            Console.WriteLine("I like " + temp + " too");
        }
        public static void Practice3()
        {
            for(int i = 0; i < 10; i++)
            {
                if(i == 0 || i == 9)
                    Console.WriteLine("**********");
                else
                    Console.WriteLine("*        *");
            }
        }
        public static void Practice4()
        {
            string name = "孙志炜";
            byte age = 18;
            bool gender = true;
            float height = 1.80F;
            float weight = 75.0F;
            string address = "槐树庄";
            Console.WriteLine("I am " + name + ", I am " + age + " years old, " + "my gender is " + (gender ? "boy," : "girl,")
                + " My height is " + height + ", My weight is " + weight + ", My address is " + address);
        }
        public static void Practice5()
        {
            byte math = 80;
            byte chinese = 78;
            byte english = 98;
            Console.WriteLine("My math score is " + math);
            Console.WriteLine("My chinese score is " + chinese);
            Console.WriteLine("My english score is " + english);
        }
        public static void Practice6()
        {
            ConsoleKey key = default(ConsoleKey);
            while(key != ConsoleKey.Z)
            {
                key = Console.ReadKey().Key;
                switch(key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("我是小明");
                        Console.WriteLine("我今年18");
                        Console.WriteLine("我的爱好是制作游戏");
                        Console.WriteLine("我要好好学习，天天向上");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("s 我是小明\n我今年18\n我的爱好是制作游戏\n我要好好学习，天天向上\n");
                        break;
                   
                }
            }
        }

    }
}
