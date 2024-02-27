namespace CSharp
{
    internal class Program
    {
        //static void Main(string[] args)
        //{ 
        //    Console.WriteLine("Hello, World!");
        //    int a = 1;
        //    Console.WriteLine(35 << 4);
        //    Console.WriteLine(66 >> 1);
        //    Console.WriteLine(99 ^ 33);
        //    Console.WriteLine(76 | 85);
        //}


        static void Main(string[] args)
        {
            #region 1 控制台基础设置
            //隐藏光标
            Console.CursorVisible = false;
            //通过两个变量来存储 舞台的大小
            int w = 50;
            int h = 30;
            //设置舞台（控制台）的大小
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);
            #endregion

            #region 2 多个场景
            //当前所在场景的编号
            int nowSceneID = 1;
            #region 9 结束场景相关
            //结束场景显示的 文字提示内容
            string gameOverInfo = "";
            #endregion
            while (true)
            {
                //不同的场景ID 进行不同的逻辑处理
                switch (nowSceneID)
                {
                    //开始场景
                    case 1:
                        Console.Clear();
                        #region 3 开始场景逻辑
                        Console.SetCursorPosition(w / 2 - 7, 8);
                        Console.Write("唐老狮营救公主");
                        //当前选项的编号
                        int nowSelIndex = 0;
                        //因为要输入 我们可以构造一个 开始界面自己的 死循环
                        //专门用来处理 开始场景相关的逻辑
                        while (true)
                        {
                            //用一个标识  来处理 想要在while循环内部的switch逻辑执行时 希望退出外层while循环时
                            // 改变标识即可
                            bool isQuitWhile = false;
                            // 显示 内容
                            //先设置光标位置 再显示内容
                            Console.SetCursorPosition(w / 2 - 4, 13);
                            //根据当前选择的编号 来决定 是否变色
                            Console.ForegroundColor = nowSelIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("开始游戏");
                            Console.SetCursorPosition(w / 2 - 4, 15);
                            Console.ForegroundColor = nowSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");
                            // 检测 输入
                            // 检测玩家 输入的一个键内容 并且不会再控制台上显示输入的内容
                            char input = Console.ReadKey(true).KeyChar;
                            switch (input)
                            {
                                case 'W':
                                case 'w':
                                    --nowSelIndex;
                                    if (nowSelIndex < 0)
                                    {
                                        nowSelIndex = 0;
                                    }
                                    break;
                                case 'S':
                                case 's':
                                    ++nowSelIndex;
                                    if (nowSelIndex > 1)
                                    {
                                        nowSelIndex = 1;
                                    }
                                    break;
                                case 'J':
                                case 'j':
                                    if (nowSelIndex == 0)
                                    {
                                        //1.改变当前选择的场景ID
                                        nowSceneID = 2;
                                        //2.要退出 内层while循环
                                        isQuitWhile = true;
                                    }
                                    else
                                    {
                                        //关闭控制台
                                        Environment.Exit(0);
                                    }
                                    break;
                            }

                            if (isQuitWhile)
                            {
                                break;
                            }
                        }
                        #endregion
                        break;
                    //游戏场景
                    case 2:
                        Console.Clear();
                        #region 4 不变的红墙
                        //设置颜色为红色
                        Console.ForegroundColor = ConsoleColor.Red;
                        //画墙
                        //上方墙
                        for (int i = 0; i < w; i += 2)
                        {
                            //上方墙
                            Console.SetCursorPosition(i, 0);
                            Console.Write("■");
                            //下方墙
                            Console.SetCursorPosition(i, h - 1);
                            Console.Write("■");
                            //中间墙
                            Console.SetCursorPosition(i, h - 6);
                            Console.Write("■");
                        }
                        //左边的墙
                        for (int i = 0; i < h; i++)
                        {
                            //左边的墙
                            Console.SetCursorPosition(0, i);
                            Console.Write("■");
                            //右边的墙
                            Console.SetCursorPosition(w - 2, i);
                            Console.Write("■");
                        }
                        #endregion

                        #region 5 boss属性相关
                        int bossX = 24;
                        int bossY = 15;
                        int bossAtkMin = 7;
                        int bossAtkMax = 13;
                        int bossHp = 100;
                        string bossIcon = "■";
                        //申明一个 颜色变量
                        ConsoleColor bossColor = ConsoleColor.Green;
                        #endregion

                        #region 6 玩家属性相关
                        int playerX = 4;
                        int playerY = 5;
                        int playerAtkMin = 8;
                        int playerAtkMax = 12;
                        int playerHp = 100;
                        string playerIcon = "●";
                        ConsoleColor playerColor = ConsoleColor.Yellow;
                        //玩家输入的内容 外面申明 节约性能
                        char playerInput;
                        #endregion

                        #region 8 公主相关
                        int princessX = 24;
                        int princessY = 5;
                        string princessIcon = "★";
                        ConsoleColor princessColor = ConsoleColor.Blue;
                        #endregion

                        #region 7 玩家战斗相关
                        //战斗状态
                        bool isFight = false;
                        //作用是 从while循环内部的switch 改变标识 用来跳出外层的while循环
                        bool isOver = false;
                        #endregion

                        //游戏场景的死循环 专门用来 检测 玩家输入相关循环
                        while (true)
                        {
                            #region 5 boss属性相关
                            //boss活着时才绘制
                            if (bossHp > 0)
                            {
                                //绘制boss图标
                                Console.SetCursorPosition(bossX, bossY);
                                Console.ForegroundColor = bossColor;
                                Console.Write(bossIcon);
                            }
                            #endregion
                            #region 8 公主相关
                            else
                            {
                                Console.SetCursorPosition(princessX, princessY);
                                Console.ForegroundColor = princessColor;
                                Console.Write(princessIcon);
                            }
                            #endregion
                            #region 6 玩家移动相关
                            //画出玩家
                            Console.SetCursorPosition(playerX, playerY);
                            Console.ForegroundColor = playerColor;
                            Console.Write(playerIcon);
                            //得到玩家输入
                            playerInput = Console.ReadKey(true).KeyChar;
                            #endregion

                            //战斗状态处理什么逻辑
                            if (isFight)
                            {
                                #region 7 玩家战斗相关
                                //如果是战斗状态 你做什么
                                //只会处理J键 
                                if (playerInput == 'J' || playerInput == 'j')
                                {
                                    //在这判断 玩家或者怪物 是否死亡 如果死亡了 继续之后的流程
                                    if (playerHp <= 0)
                                    {
                                        //游戏结束
                                        //输掉了 应该直接显示 我们的 游戏结束界面
                                        nowSceneID = 3;
                                        gameOverInfo = "游戏失败";
                                        break;
                                    }
                                    else if (bossHp <= 0)
                                    {
                                        //去营救公主
                                        //boss擦除
                                        Console.SetCursorPosition(bossX, bossY);
                                        Console.Write("  ");
                                        isFight = false;
                                    }
                                    else
                                    {
                                        //去处理按J键打架
                                        // 玩家打怪物
                                        Random r = new Random();
                                        //得到随机攻击了
                                        int atk = r.Next(playerAtkMin, playerAtkMax);
                                        //血量减对应的攻击力
                                        bossHp -= atk;
                                        //打印信息
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        //先擦除这一行 上次显示的内容
                                        Console.SetCursorPosition(2, h - 4);
                                        Console.Write("                                           ");
                                        //再来写新的信息
                                        Console.SetCursorPosition(2, h - 4);
                                        Console.Write("你对boss造成了{0}点伤害，boss剩余血量为{1}", atk, bossHp);
                                        // 怪物打玩家
                                        if (bossHp > 0)
                                        {
                                            //得到随机攻击了
                                            atk = r.Next(bossAtkMin, bossAtkMax);    
                                            playerHp -= atk;

                                            //打印信息
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            //先擦除这一行 上次显示的内容
                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write("                                           ");
                                            //再来写新的信息
                                            //boss如果把玩家打死了 做什么
                                            if (playerHp <= 0)
                                            {
                                                Console.SetCursorPosition(2, h - 3);
                                                Console.Write("很遗憾，你未能通过boss的试炼，战败了");
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(2, h - 3);
                                                Console.Write("boss对你造成了{0}点伤害，你的剩余血量为{1}", atk, playerHp);
                                            }
                                        }
                                        else
                                        {
                                            //擦除之前的战斗信息
                                            Console.SetCursorPosition(2, h - 5);
                                            Console.Write("                                           ");
                                            Console.SetCursorPosition(2, h - 4);
                                            Console.Write("                                           ");
                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write("                                           ");
                                            //显示恭喜胜利的信息
                                            Console.SetCursorPosition(2, h - 5);
                                            Console.Write("你战胜了boss，快去营救公主");
                                            Console.SetCursorPosition(2, h - 4);
                                            Console.Write("前往公主身边按J键继续");
                                        }
                                    }
                                }
                                #endregion
                            }
                            //非战斗状态处理什么逻辑
                            else
                            {
                                #region 6 玩家移动相关
                                //擦除
                                Console.SetCursorPosition(playerX, playerY);
                                Console.Write("  ");
                                //改位置
                                switch (playerInput)
                                {
                                    case 'W':
                                    case 'w':
                                        --playerY;
                                        if (playerY < 1)
                                        {
                                            playerY = 1;
                                        }
                                        //位置如果和boss重合了 并且boss没有死
                                        else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        {
                                            //拉回去
                                            ++playerY;
                                        }
                                        else if (playerX == princessX && playerY == princessY && bossHp <= 0)
                                        {
                                            //拉回去
                                            ++playerY;
                                        }
                                        break;
                                    case 'A':
                                    case 'a':
                                        playerX -= 2;
                                        if (playerX < 2)
                                        {
                                            playerX = 2;
                                        }
                                        else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        {
                                            //拉回去
                                            playerX += 2;
                                        }
                                        else if (playerX == princessX && playerY == princessY && bossHp <= 0)
                                        {
                                            //拉回去
                                            playerX += 2;
                                        }
                                        break;
                                    case 'S':
                                    case 's':
                                        ++playerY;
                                        if (playerY > h - 7)
                                        {
                                            playerY = h - 7;
                                        }
                                        else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        {
                                            //拉回去
                                            --playerY;
                                        }
                                        else if (playerX == princessX && playerY == princessY && bossHp <= 0)
                                        {
                                            //拉回去
                                            --playerY;
                                        }
                                        break;
                                    case 'D':
                                    case 'd':
                                        playerX += 2;
                                        if (playerX > w - 4)
                                        {
                                            playerX = w - 4;
                                        }
                                        else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        {
                                            //拉回去
                                            playerX -= 2;
                                        }
                                        else if (playerX == princessX && playerY == princessY && bossHp <= 0)
                                        {
                                            //拉回去
                                            playerX -= 2;
                                        }
                                        break;
                                    case 'J':
                                    case 'j':
                                        #region 7 玩家战斗相关
                                        //开始战斗
                                        //要让玩家不能再移动
                                        //下方能够显示信息
                                        if ((playerX == bossX && playerY == bossY - 1 ||
                                            playerX == bossX && playerY == bossY + 1 ||
                                            playerX == bossX - 2 && playerY == bossY ||
                                            playerX == bossX + 2 && playerY == bossY) && bossHp > 0)
                                        {
                                            isFight = true;
                                            //可以开始战斗
                                            Console.SetCursorPosition(2, h - 5);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Write("开始和Boss战斗了，按J键继续");
                                            Console.SetCursorPosition(2, h - 4);
                                            Console.Write("玩家当前血量为{0}", playerHp);
                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write("boss当前血量为{0}", bossHp);
                                        }
                                        #endregion
                                        #region 8 公主相关
                                        //判断是否在公主身边按J键
                                        else if ((playerX == princessX && playerY == princessY - 1 ||
                                            playerX == princessX && playerY == princessY + 1 ||
                                            playerX == princessX - 2 && playerY == princessY ||
                                            playerX == princessX + 2 && playerY == princessY) && bossHp <= 0)
                                        {
                                            //改变 场景ID
                                            nowSceneID = 3;
                                            gameOverInfo = "游戏通关";
                                            //跳出 游戏界面的while循环 回到主循环
                                            isOver = true;
                                        }
                                        #endregion
                                        break;
                                }
                                #endregion
                            }
                            #region 8 公主相关
                            //外层while循环逻辑
                            if (isOver)
                            {
                                //就是和while配对
                                break;
                            }
                            #endregion
                        }
                        break;
                    //结束场景
                    case 3:
                        Console.Clear();
                        #region 9 结束场景逻辑
                        //标题的显示
                        Console.SetCursorPosition(w / 2 - 4, 5);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("GameOver");
                        //可变内容的显示 根据失败或者 成功显示的内容不一样
                        Console.SetCursorPosition(w / 2 - 4, 7);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(gameOverInfo);

                        int nowSelEndIndex = 0;
                        while (true)
                        {
                            bool isQuitEndWhile = false;

                            Console.SetCursorPosition(w / 2 - 6, 9);
                            Console.ForegroundColor = nowSelEndIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("回到开始界面");
                            Console.SetCursorPosition(w / 2 - 4, 11);
                            Console.ForegroundColor = nowSelEndIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");

                            char input = Console.ReadKey(true).KeyChar;

                            switch (input)
                            {
                                case 'W':
                                case 'w':
                                    --nowSelEndIndex;
                                    if (nowSelEndIndex < 0)
                                    {
                                        nowSelEndIndex = 0;
                                    }
                                    break;
                                case 'S':
                                case 's':
                                    ++nowSelEndIndex;
                                    if (nowSelEndIndex > 1)
                                    {
                                        nowSelEndIndex = 1;
                                    }
                                    break;
                                case 'J':
                                case 'j':
                                    if (nowSelEndIndex == 0)
                                    {
                                        nowSceneID = 1;
                                        isQuitEndWhile = true;
                                    }
                                    else
                                    {
                                        Environment.Exit(0);
                                    }
                                    break;
                            }

                            //为了 从switch中跳出上一层的 while循环 加的标识
                            if (isQuitEndWhile)
                            {
                                break;
                            }
                        }
                        #endregion
                        break;
                }
            }
            #endregion
        }
    }
}
 