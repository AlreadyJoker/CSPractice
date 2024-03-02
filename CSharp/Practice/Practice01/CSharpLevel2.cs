using System.ComponentModel;

namespace Practice.Practice01
{
    public class CSharpLevel2
    {
        public static void Practice()
        {
           Practice09();
        }

        public static void Practice01()
        {
            byte num = 0;
            PrintTitle("枚举");
            //Question01();
            //Question02();
            Question03();

            void Question01()
            {
                PrintSubTitle(ref num);
                Console.WriteLine("请输入一个在线状态：0 在线   1 不在线");
                string input = Console.ReadLine();
                try
                {
                    EQQState inputEnum = (EQQState)int.Parse(input);
                    Console.WriteLine("You qq state is " + inputEnum);
                }
                catch
                {
                    Console.WriteLine("第一题输入错误");
                }
            }

            void Question02()
            {
                PrintSubTitle(ref num);
                do
                {
                    Console.WriteLine("Enter your choice of coffee type: 1 Middle(35$) 2 Big(40$) 3 SuperBig(43$)");
                    int inputInt;
                    if (int.TryParse(Console.ReadLine(), out inputInt))
                    {
                        switch ((ECoffeeTyp)inputInt)
                        {
                            case ECoffeeTyp.Middle:
                                Console.WriteLine("Your choice is Middle. Your cost of coffee is 35$");
                                break;
                            case ECoffeeTyp.Big:
                                Console.WriteLine("Your choice is Big. Your cost of coffee is 40$");
                                break;
                            case ECoffeeTyp.SuperBig:
                                Console.WriteLine("Your choice is SuperBig. Your cost of coffee is 43$");
                                break;
                            default:
                                Console.WriteLine("The number of your input has error");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Question02 is in error");
                    }
                } while (Console.ReadKey().Key == ConsoleKey.Enter);
            }

            void Question03()
            {
                PrintSubTitle(ref num);
                int atk = 0;
                int def = 0;
                string skill;
                string professionName;
                EHeroProfession profession;
                do
                {
                    try
                    {
                        atk = 0;
                        def = 0;
                        InputGender();
                        InputProfession();
                        Console.WriteLine($"你选择了 {professionName}，攻击力：{atk}, 防御力：{def}，职业技能：{skill}");
                    }
                    catch
                    {
                        Console.WriteLine("Question03 is error");
                    }
                } while (Console.ReadKey().Key == ConsoleKey.Enter);
                void InputGender()
                {
                    Console.WriteLine("Please enter your gender: 1 man  2 weman");
                    int inputGender = int.Parse(Console.ReadLine());
                    switch (inputGender)
                    {
                        case 1:
                            atk += 50;
                            def += 100;
                            professionName = "男性";
                            break;
                        case 2:
                            atk += 150;
                            def += 20;
                            professionName = "女性";
                            break;
                        default:
                            InputGender();
                            break;
                    }
                }
                void InputProfession()
                {
                    Console.WriteLine("Please enter your profession: 0 Solder  1 Hunter  2 Magician");
                    profession = (EHeroProfession)int.Parse(Console.ReadLine());
                    switch (profession)
                    {
                        case EHeroProfession.Soldier:
                            atk += 20;
                            def += 100;
                            skill = "冲锋";
                            professionName += "战士";
                            break;
                        case EHeroProfession.Hunter:
                            atk += 120;
                            def += 30;
                            skill = "假死";
                            professionName += "猎人";
                            break;
                        case EHeroProfession.Magician:
                            atk += 200;
                            def += 10;
                            skill = "奥术攻击";
                            professionName += "法师";
                            break;
                        default:
                            InputProfession();
                            break;
                    }
                }
            }
        }

        public static void Practice02()
        {
            byte num = 0;
            PrintTitle("一维数组");
            //Question01();
            //Question02();
            //Question03();
            //Qusetion04();
            //Question05();
            Question06();

            void Question01()
            {
                PrintSubTitle(ref num);
                int[] arr = new int[100];
                for (int i = 0; i < arr.Length; i++) 
                {
                    arr[i] = i;
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine("\n");
                int[] arr2 = new int[100];
                for(int j = 0; j < arr.Length; j++)
                {
                    arr2[j] = arr[j] * 2;
                    Console.Write(arr2[j] + " ");
                }
            }
            void Question02()
            {
                PrintSubTitle(ref num);
                int[] arr = new int[10];
                Random random = new Random();
                int sum = 0;
                int max = 0;
                int min = int.MaxValue;
                for(int i = 0; i < arr.Length; i++)
                {
                    arr[i] = random.Next(0, 101);
                    sum += arr[i];
                    if (arr[i] > max)
                        max = arr[i];
                    else if (arr[i] < min)
                        min = arr[i];
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine($"最大值：{max}，最小值：{min}，总和：{sum}，平均值：{sum / (float)arr.Length}");
            }
            void Question03()
            {
                PrintSubTitle(ref num);
                int[] arr = new int[11];
                Random random = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = random.Next(0, 101);
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine("\n");
                int last = arr.Length - 1;
                for(int j = 0; j < arr.Length / 2; j++)
                {
                    arr[j] += arr[last - j];
                    arr[last - j] = arr[j] - arr[last - j];
                    arr[j] = arr[j] - arr[last - j];
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            void Qusetion04()
            {
                PrintSubTitle(ref num);
                int[] arr = new int[10];
                Random random = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = random.Next(-10, 11);
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
                for(int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                        arr[i] += 1;
                    else if (arr[i] < 0)
                        arr[i] -= 1;
                    Console.Write(arr[i] + " ");
                }
            }
            void Question05()
            {
                PrintSubTitle(ref num);
                int[] arr = new int[10];
                Console.WriteLine("请一次输入10位同学的成绩");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                int max = arr[0];
                int min = arr[0];
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                        max = arr[i];
                    else if (arr[i] < min)
                        min = arr[i];
                    sum += arr[i];
                }
                Console.WriteLine($"最高分: {max}, 最低分：{min}，平均值：{sum / (float)arr.Length}");

            }

            void Question06()
            {
                string[] arr = new string[25];
                for(int i = 0; i < arr.Length; i++)
                {
                    arr[i] = i % 2 == 0 ? "■" : "□";
                }

                for(int i = 0;i < arr.Length; i++)
                {
                    Console.Write(arr[i]);
                    if ((i + 1) % 5 == 0)
                        Console.Write("\n");
                }
            }
        }
        public static void Practice03()
        {
            byte num = 0;
            PrintTitle("二维数组");
            //Question01();
            //Question02();
            //Question03();
            //Question04();
            Question05();
            void Question01()
            {
                PrintSubTitle(ref num);
                int[,] arr = new int[100, 100];
                for(int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = i * 100 + (j + 1);
                    }
                }
                PrintArr(arr);
            }
            void Question02()
            {
                PrintSubTitle(ref num);
                int[,] arr = new int[4, 4];
                Random random = new Random();
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (j > i)
                            arr[i, j] = 0;
                        else
                            arr[i, j] = random.Next(1, 101);
                    }
                }
                PrintArr(arr);
            }
            void Question03()
            {
                PrintSubTitle(ref num);
                int[,] arr = new int[3, 3];
                Random random = new Random();
                int sum = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = random.Next(0, 11);
                        if (j == i)
                            sum += arr[i, j];
                    }
                }
                PrintArr(arr);
                Console.WriteLine("对角线之和为 " + sum);
            }
            void Question04() 
            {
                PrintSubTitle(ref num);
                int[,] arr = new int[5, 5];
                int max = 0;
                int row = 0;
                Random random = new Random();
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = random.Next(0, 101);
                        if (arr[i, j] > max)
                        {
                            max = arr[i, j];
                            row = i + 1;
                        }
                    }
                }
                PrintArr(arr);
                Console.WriteLine($"最大值: {max}, 行号：{row}");
            }
            void Question05()
            {
                PrintSubTitle(ref num);
                int[,] arr = new int[5, 5];
                bool[] arrRow = new bool[5];
                bool[] arrColumn = new bool[5];
                Random random = new Random();
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = random.Next(0, 2);
                        if (arr[i, j] == 1)
                        {
                            arrRow[i] = true;
                            arrColumn[j] = true;
                        }
                    }
                }
                PrintArr(arr);
                Console.WriteLine("-----------------------------------------------");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arrRow[i] || arrColumn[j])
                            arr[i, j] = 1;
                    }
                }
                PrintArr(arr);
            }
        }

        public static void Practice04(int a)
        {
            Console.WriteLine(a++);
            if (a > 10)
                return;
            Practice04(a);
        }
        public static int Practice05(int a)
        {
            if (a == 1)
                return 1;
            return a * Practice05(a - 1);
        }
        public static int Practice06(int a)
        {
            if (a == 1)
                return 1;
            return Practice05(a) + Practice06(a - 1);
        }
        public static void Practice07(float length, int day)
        {
            length /= 2;
            if (day == 10)
            {
                Console.WriteLine($"第{day}天剩下{length}米");
                return;
            }
            Practice07(length, day + 1);
        }
        public static bool Practice08(int num)
        {
            Console.WriteLine(num);

            return num == 200 || Practice08(num + 1);
        }
        public static void Practice09()
        {
            byte num = 0;
            PrintTitle("结构体");
            Qusetion01();
            //Qusetion02();
            //Question03();
            Question04();
            void Qusetion01()
            {
                PrintSubTitle(ref num);
                Student s1 = new Student("张三", true, 18, 1, "计算机");
                s1.Speak();
                Student s2 = new Student();
                s2.Speak();
            }
            void Qusetion02()
            {
                PrintSubTitle(ref num);
                Rectangle r1 = new Rectangle(10, 20);
                r1.Print();
                Rectangle r2 = new Rectangle(20, 30);
                r2.Print();
            }
            void Question03()
            {
                PrintSubTitle(ref num);
                Player player;
                Console.WriteLine("请输入玩家的名字");
                player.name = Console.ReadLine();
                Console.WriteLine("请输入玩家的职业: 战士 猎人 法师");
                player.profession = Console.ReadLine();
                string message = "";
                switch(player.profession)
                {
                    case "战士":
                        message = "冲锋";
                        break;
                    case "猎人":
                        message = "假死";
                        break;
                    case "法师":
                        message = "奥术攻击";
                        break;
                }
                Console.WriteLine($"{player.name}释放了{message}");
            }
            void Question04()
            {
                PrintSubTitle(ref num);
                Monster[] monsters = new Monster[10];
                Random random = new Random();
                for(int i = 0; i < 10; i++)
                {
                    monsters[i].name = "小怪兽" + i;
                    monsters[i].atk = random.Next(1, 101);
                }
                for(int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{monsters[i].name}的攻击力为{monsters[i].atk}");
                }

            }
        }


        static void CalcMax()
        {
            int a = GetRandomNum();
            int b = GetRandomNum();
            Console.WriteLine($"a = {a}, b = {b}, max = {(a >= b ? a : b)}");
        }
        static float[] CalcCircle(int radius)
        {
            return new float[] { 3.14F * radius * radius, 2 * 3.14F * radius };
        }

        static int[] CalaArr(int[] arr)
        {
            int sum = 0;
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (arr[i] > max)
                    max = arr[i];
                else if (arr[i] < min)
                    min = arr[i];
            }
            return new int[4] { sum, max, min, sum / arr.Length };
        }
        static void CalcPrime(int num)
        {
            if (num == 1)
            {
                Console.WriteLine("是质数");
                return;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("不是质数");
                    return;
                }
            }
            Console.WriteLine("是质数");
        }
        static void CalcLeapYear()
        {
            int year = 0;
            Console.WriteLine("Please Enter a year");
            year = int.Parse(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine("润年");
            else
                Console.WriteLine("不是闰年");
        }

        static int GetRandomNum(int min = 0, int max = 101)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        static bool Login(ref string message)
        {
            Console.WriteLine("请输入用户名");
            if (Console.ReadLine() != "admin")
            {
                message = "用户名错误";
                return false;
            }
            Console.WriteLine("请输入密码");
            if (Console.ReadLine() != "8888")
            {
                message = "密码错误";
                return false;
            }
            return true;
        }
        static int Test(int a, int b)
        {
            return 0;
        }
        static void CalcTest01(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("和为 " + sum + "平均值为 " + (sum / (float)arr.Length));
        }
        public static void CalcTest02(params int[] arr)
        {
            int sum01 = 0;
            int sum02 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum01 += arr[i];
                }
                else
                {
                    sum02 += arr[i];
                }
            }
            Console.WriteLine("偶数和为 " + sum01 + "奇数和为 " + sum02);
        }
        public static int CalcMax(int a, int b)
        {
            return a > b ? a : b;
        }
        public static float CalcMax(float a, float b)
        {
            return a > b ? a : b;
        }
        public static double CalcMax(double a, double b)
        {
            return a > b ? a : b;
        }
        public static void CalcMax(params int[] arr)
        {
            int max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            Console.WriteLine("最大值为 " + max);
        }
        public static void CalcMax(params float[] arr)
        {
            float max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            Console.WriteLine("最大值为 " + max);
        }
        public static void CalcMax(params double[] arr)
        {
            double max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            Console.WriteLine("最大值为 " + max);
        }

        enum EQQState
        {
            OnLine,
            UnLine
        }
        enum ECoffeeTyp
        {
            Middle = 1,
            Big,
            SuperBig
        }
        enum EHeroProfession
        {
            Soldier,
            Hunter,
            Magician,
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
        public static void PrintArr(int[,] arr)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.Write("\n");
            }
        }

    }
    struct Student
    {
        public string name;
        public bool gender;
        public int age;
        public byte classNum;
        public string profession;
        public Student(string name, bool gender, int age, byte classNum, string profession)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.classNum = classNum;
            this.profession = profession;            
        }
        public void Speak()
        {
            Console.WriteLine($"我是{name}, 我今年{age}岁，我的名别是{(gender ? "男" : "女")}， 我的班级是{classNum}, 我的专业是{profession}");
        }
    }
    struct Rectangle
    {
        public float length;
        public float width;
        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
        }
        public float GetArea()
        {
            return length * width;
        }
        public float GetPerimeter()
        {
            return (length + width) * 2;
        }
        public void Print()
        {
            Console.WriteLine($"长{length}, 宽{width}, 周长{GetPerimeter()}, 面积{GetArea()}");
        }
    }
    struct Player
    {
        public string name;
        public string profession;
    }
    struct Monster
    {
        public string name;
        public int atk;
    }
    struct Ultraman
    {
        public string name;
        public int atk;
        public int def;
        public int hp;
        public Ultraman(string name, int atk, int def, int hp)
        {
            this.name = name;
            this.atk = atk;
            this.def = def;
            this.hp = hp;
        }
        public void Atk(ref Boss boss)
        {
            boss.hp -= this.atk - boss.def;
            Console.WriteLine($"{name}攻击{boss.name}，造成了{this.atk - boss.def}伤害，剩余血量{boss.hp}");
        }
    }
    struct Boss
    {
        public string name;
        public int atk;
        public int def;
        public int hp;
        public Boss(string name, int atk, int def, int hp)
        {
            this.name = name;
            this.atk = atk;
            this.def = def;
            this.hp = hp;
        }
        public void Atk(ref Ultraman ultraman)
        {
            ultraman.hp -= this.atk - ultraman.def;
            Console.WriteLine($"{name}攻击{ultraman.name}，造成了{this.atk - ultraman.def}伤害，剩余血量{ultraman.hp}");
        }
    }

}
