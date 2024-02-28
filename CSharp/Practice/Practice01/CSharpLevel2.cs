namespace Practice.Practice01
{
    public class CSharpLevel2
    {
        public static void Practice()
        {
            Practice03();
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
}
