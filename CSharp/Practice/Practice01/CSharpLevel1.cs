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
            Practice15();
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

        public static void Practice13()
        {
            byte num = 0;
            PrintTitle("分支与循环");
            Question01();
            Question02();
            Question03();
            Question04();
            Question05();
            Question06();
            Question07();
            Question08();
            Question09();
            void Question01()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入学习时间");
                int minute;
                try
                {
                    minute = int.Parse(Console.ReadLine());
                    if (minute > 60)
                        Console.WriteLine("今天学习了{0}分钟，看来你离成功又近了一步！", minute);
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("第一题输入格式错误");
                }
               
            }
            void Question02()
            {
                PrintSubTitle(ref num);
                int chinese;
                int math;
                int english;
                try
                {
                    Console.WriteLine("请输入语文成绩");
                    chinese = int.Parse(Console.ReadLine());
                    Console.WriteLine("请输入数学成绩");
                    math = int.Parse(Console.ReadLine());
                    Console.WriteLine("请输入英语成绩");
                    english = int.Parse(Console.ReadLine());

                    if ((chinese > 70 && math > 80 && english > 90) || (chinese == 100 || english == 100 || math == 100) || (chinese > 90 && (math > 70 || english > 70)))
                        Console.WriteLine("非常棒，继续加油");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("第二题输入格式错误");
                }
            }
            void Question03()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入小赵的Unity成绩");
                int score;
                try
                {
                    score = int.Parse(Console.ReadLine());
                    if (score >= 90)
                        Console.WriteLine("奖励100");
                    else
                        Console.WriteLine("不能玩游戏");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("第三题输入格式错误");
                }
            }
            void Question04()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入两个数字");
                int a;
                int b;
                try
                {
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    if ((a + b) > 100 || (a > b) ? a % b == 0 : b % a == 0)
                        Console.WriteLine("a的值为 " + a);
                    else
                        Console.WriteLine("b的值为 " + b);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("第四题输入格式错误");
                }
            }
            void Question05()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入一个整数");
                int num01;
                try
                {
                    num01 = int.Parse(Console.ReadLine());
                    if (num01 % 2 == 0)
                        Console.WriteLine("Your print is even");
                    else
                        Console.WriteLine("You print is odd");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("第五题输入格式错误");
                }

            }
            void Question06()
            {
                PrintSubTitle(ref num);
                int a = 10;
                int b = 20;
                int c = 98;
                if (a > b && a > c)
                    Console.WriteLine("最大值为a " + a);
                else if(b > a && b > c)
                    Console.WriteLine("最大值为b " + b);
                else
                    Console.WriteLine("最大值为c " + c);
            }
            void Question07()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入一个字符");
                char a;
                try
                {
                    a = char.Parse(Console.ReadLine());
                    if (a >= '0' && a <= '9')
                        Console.WriteLine("您输入了一个数字");
                    else
                        Console.WriteLine("这不是一个数字");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("第七题输入格式错误");
                }

            }
            void Question08()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入用户名");
                string userName = Console.ReadLine();
                Console.WriteLine("请输入密码");
                string password = Console.ReadLine();
                if(userName == "admin")
                {
                    if (password == "8888")
                        Console.WriteLine("正确");
                    else
                        Console.WriteLine("密码错误");
                }
                else
                    Console.WriteLine("用户名不存在");

            }
            void Question09()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入年龄");
                int age;
                try
                {
                    age = int.Parse(Console.ReadLine());
                    if (age < 13)
                        Console.WriteLine("不能查看");
                    else if (age >= 18)
                        Console.WriteLine("可以查看");
                    else if(age >= 13 && age < 18)
                    {
                        Console.WriteLine("继续查看 yse / no");
                        string temp = Console.ReadLine();
                        if (temp == "yes")
                            Console.WriteLine("查看内容");
                        else if (temp == "no")
                            Console.WriteLine("退出查看");
                        else
                            Console.WriteLine("输入错误");

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("第一题输入格式错误");
                }

            }
        }

        public static void Practice14()
        {
            byte num = 0;
            PrintTitle("分支Switch");
            Question01();
            Question02();
            Question03();
            Question04();
            void Question01()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入唐老师的评级");
                char level = char.Parse(Console.ReadLine());
                short salery = 4000;
                switch (level)
                {
                    case 'A':
                        salery += 500;
                        break;
                    case 'B':
                        salery += 0;
                        break;
                    case 'C':
                        salery -= 300;
                        break;
                    case 'D':
                        salery -= 500;
                        break;
                    case 'E':
                        salery -= 800;
                        break;
                    default:
                        Console.WriteLine("请输入A - E");
                        break;
                }
                Console.WriteLine("唐老师的工资是{0}", salery);
            }
            void Question02()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请选择:\n\t1 中杯 5￥\n\t2 大杯7￥\n\t3 超大杯 11￥");
                int cost = int.Parse(Console.ReadLine());
                switch(cost)
                {
                    case 1:
                        Console.WriteLine("还剩{0}", 10 - 5);
                        break;
                    case 2:
                        Console.WriteLine("还剩{0}", 10 - 7);
                        break;
                    case 3:
                        Console.WriteLine("钱不够");
                        break;
                    default:
                        Console.WriteLine("输入错误");
                        break;
                }
            }
            void Question03()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入学生的成绩");
                int score = int.Parse(Console.ReadLine());
                char level;
                score /= 10;
                switch (score)
                {
                    case 10:
                    case 9:
                        Console.WriteLine("你的成绩是A");
                        break;
                    case 8:
                        Console.WriteLine("你的成绩是B");
                        break;
                    case 7:
                        Console.WriteLine("你的成绩是C");
                        break;
                    case 6:
                        Console.WriteLine("你的成绩是D");
                        break;
                    default:
                        Console.WriteLine("你的成绩是E");
                        break;
                }
            }
            void Question04()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入0 - 9");
                byte temp = byte.Parse(Console.ReadLine());
                switch (temp)
                {
                    case 0:
                        Console.WriteLine("零");
                        break;
                    case 1:
                        Console.WriteLine("一");
                        break;
                    case 2:
                        Console.WriteLine("二");
                        break;
                    case 3:
                        Console.WriteLine("三");
                        break;
                    case 4:
                        Console.WriteLine("四");
                        break;
                    case 5:
                        Console.WriteLine("五");
                        break;
                    case 6:
                        Console.WriteLine("六");
                        break;
                    case 7:
                        Console.WriteLine("七");
                        break;
                    case 8:
                        Console.WriteLine("八");
                        break;
                    case 9:
                        Console.WriteLine("九");
                        break;
                    default:
                        Console.WriteLine("输入错误");
                        break;
                }

            }
        }

        public static void Practice15()
        {
            byte num = 0;
            PrintTitle("while循环");
            //Question01();
            //Question02();
            //Question03();
            //Question04();
            //Question05();
            //Question06();
            //Question07();
            Question08();
            
            void Question01()
            {
                PrintSubTitle(ref num);
                int i = 0;
                while(i < 100)
                {
                    Console.WriteLine(++i);
                }
            }
            void Question02()
            {
                PrintSubTitle(ref num);
                int i = 0;
                int sum = 0;
                while (i != 100)
                {
                    i++;
                    sum += i;
                }
                Console.WriteLine("1 - 100的和为 " + sum);
            }
            void Question03()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入一个数判断是不是素数");
                int temp;
                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    if (temp == 1)
                        Console.WriteLine("不是素数");
                    else
                    {
                        int index = 2;
                        while(index != temp)
                        {
                            if (temp % index == 0)
                            {
                                Console.WriteLine("是素数");
                                return;
                            }
                            index++;
                        }
                        Console.WriteLine("不是素数");
                    }
                }
            }
            void Question04()
            {
                PrintSubTitle(ref num);
                string userName = "";
                string password = "";
                while(userName != "admin" || password != "8888")
                {
                    Console.WriteLine("请输入用品户名");
                    userName = Console.ReadLine();
                    Console.WriteLine("请输入密码");
                    password = Console.ReadLine();
                }               
            }
            void Question05()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入班级人数");
                int num01 = int.Parse(Console.ReadLine());
                int index = 1;
                int sum = 0;
                while(index <= num01)
                {
                    Console.WriteLine("请输入第{0}位同学的成绩", index);
                    sum += int.Parse(Console.ReadLine());
                    index++;
                }
                Console.WriteLine("{0}位同学的总成绩是{1}", num01, sum);
            }
            void Question06()
            {
                PrintSubTitle(ref num);
                int sum = 0;
                int index = 0;
                while(sum <= 500)
                {
                    index++;
                    sum += index;
                }
                Console.WriteLine("加到{0}可以大于500", index);
            }
            void Question07()
            {
                PrintSubTitle(ref num);
                float sum = 100;
                int index = 0;
                while (sum < 1000)
                {
                    sum += sum * 0.2F;
                    index++;
                }
                Console.WriteLine("第{0}个月", index);
            }
            void Question08()
            {
                PrintSubTitle(ref num);
                int first = 1;
                int last = 1;
                int index = 2;
                while(index < 20)
                {
                    index++;
                    if(index % 2 !=0)
                        first += last;
                    else
                        last += first;
                }
                Console.WriteLine("第20位是{0}", last);
            }
            void Question09()
            {
                PrintSubTitle(ref num);
                for (int i = 2; i < 100; i++)
                {
                    bool isPrime = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                        Console.WriteLine(i);
                }

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
