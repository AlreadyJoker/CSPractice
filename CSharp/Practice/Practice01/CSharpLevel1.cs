using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public static class CSharpLevel1
    {
        public static void Practice()
        {
            Practice12();
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
        public static void Practice7()
        {
            int a = '王';
            int b = '明';
            int c = '伟';

            Console.WriteLine(a + " " + b + " " + c);
        }

        //显示类型转换练习题
        public static void Practice8()
        {
            byte num = 0;
            PrintTitle("");
            Question01();
            Question02();
            void Question01()
            {
                PrintSubTitle(ref num);
                int a = 24069;
                Console.WriteLine(a.ToString());
            }
            void Question02()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入名字");
                Console.ReadLine();
                Console.WriteLine("请输入数学成绩");
                int math = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入语文成绩");
                int chinese = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入英语成绩");
                int english = int.Parse(Console.ReadLine());
                Console.WriteLine("总分为 " + (math + chinese + english));
            }
        }
        //try catch练习题
        public static void Practice9() 
        {
            PrintTitle("try catch");
            byte num = 0;
            Question01();
            Question02();
            void Question01()
            {
                PrintSubTitle(ref num);               
                Console.WriteLine("请输入一个数字");
                try
                {
                    int result = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("输入错误");
                }
                finally
                {
                    Console.WriteLine("结束");
                }
            }
            void Question02()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入名字");
                Console.ReadLine();
                try
                {
                    Console.WriteLine("请输入数学成绩");
                    int math = int.Parse(Console.ReadLine());
                    Console.WriteLine("请输入语文成绩");
                    int chinese = int.Parse(Console.ReadLine());
                    Console.WriteLine("请输入英语成绩");
                    int english = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("成绩输入错误");
                }
            }
        }

        //算数运算符练习题
        public static void Practice10()
        {
            PrintTitle("算数运算符");
            byte num = 0;
            Question01();
            Question02();
            Question03();
            Question04();
            Question05();
            Question06();
            void Question01()
            {
                PrintSubTitle(ref num);
                int age = 10;
                Console.WriteLine($"我的年龄是{age}, 我十年后的年龄是{age + 10}");
            }
            void Question02()
            {
                PrintSubTitle(ref num);
                Console.WriteLine($"半径为5的圆的面积为{5 * 5 * 3.14F}，周长为{2 * 3.14F * 5}");
            }
            void Question03()
            {
                PrintSubTitle(ref num);
                int math = 80;
                int chinese = 90;
                int english = 70;
                Console.WriteLine($"总分为 {math + chinese + english}，平均分为 {(math + chinese + english) / 3F}");
            }
            void Question04()
            {
                PrintSubTitle(ref num);
                Console.WriteLine($"2件T恤3条裤子共 {2 * 285 + 3 * 720}, 3.8折后 {(2 * 285 + 3 * 720) *0.38}");
            }
            void Question05()
            {
                PrintSubTitle(ref num);
                int a = 99;
                int b = 87;
                int temp = a;
                a = b;
                b = temp;
                Console.WriteLine($"交换1 a {a} b {b}" );
                int c = 99;
                int d = 87;
                c += d;
                d = c - d;
                c = c - d;
                Console.WriteLine($"交换2 c {c} d {d}");
            }
            void Question06()
            {
                PrintSubTitle(ref num);
                int day = 987652 / (24 * 60 * 60);
                int hour = (987652 % (24 * 60 * 60)) / (60 * 60);
                int minute = ((987652 % (24 * 60 * 60)) % (60 * 60)) / 60;
                int second = ((987652 % (24 * 60 * 60)) % (60 * 60)) % 60;
                Console.WriteLine($"987652秒是 {day}天 {hour}小时 {minute}分钟 {second}秒");
            }
        }

        public static void Practice11()
        {
            byte num = 0;
            PrintTitle("字符串拼接");
            Question01();
            Question02();
            Question03();
            Question04();

            void Question01()
            {
                PrintSubTitle(ref num);
                string name = "明东";
                Console.WriteLine("你好，{0}", name);
            }
            void Question02()
            {
                PrintSubTitle(ref num);
                string name = "段浩";
                byte age = 18;
                Console.WriteLine("{0}{1}岁了", name, age);
            }
            void Question03()
            {
                PrintSubTitle(ref num);
                string name = "段浩";
                byte age = 18;
                string email = "1223@qq.com";
                string address = "莱山";
                int salery = 13000;
                Console.WriteLine("我是{0}，{1}岁，邮箱{2}，地址{3}，期望薪资{4}", name, age, email, address, salery);
            }
            void Question04()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("我是{0}，{1}岁，班级{2}", Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            }
        }

        public static void Practice12()
        {
            byte num = 0;
            PrintTitle("三目运算符");
            Question01();
            Question02();
            Question03();
            Question04();
            void Question01()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入两个数字 ");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("较大值为 " + (a > b ? a : b));
            }
            void Question02()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入姓名");
                string name = Console.ReadLine();
                Console.WriteLine(name == "帅哥" ? "帅哥" : "美女");
            }
            void Question03()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入姓名");
                Console.WriteLine("请输入C#成绩");
                byte score = byte.Parse(Console.ReadLine());
                Console.WriteLine("请输入Unity成绩");
                byte score02 = byte.Parse(Console.ReadLine());
                Console.WriteLine(score >= 90 && score02 >= 90 ? "毕业" : "不毕业");
            }

            void Question04()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入一个年份");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine(year % 400 == 0 || (year % 4 == 0 && year % 100 != 0) ? "是闰年" : "不是闰年");
            }

        }

        public static void PrintTitle(string title) 
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(title + "练习题");
        }
        public static void PrintSubTitle(ref byte num)
        {
            num++;
            Console.WriteLine();
            Console.WriteLine($"第{num}题");
            Console.ReadKey();
        }
    }
}
