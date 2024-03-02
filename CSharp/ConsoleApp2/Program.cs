using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static EGameState gameState = EGameState.Start;
        static bool isEnd = false;
        const int width = 60;
        const int height = 40;
        static void Main(string[] args)
        {
           InitProject();
           while (!isEnd)
           {
               switch (gameState)
                {
                   case EGameState.Start:
                       StartPanel();
                       break;
                   case EGameState.Game:
                       Game();
                       break;
                   case EGameState.End:
                       EndPanel();
                       break;
               }
           }
        }
        static void InitProject()
        {
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
            Console.CursorVisible = false;
            PrintLoading();
            void PrintLoading()
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                for (int i = 0; i < 6; i++)
                {
                    Console.SetCursorPosition(20, 10);
                    if (i % 3 == 0)
                        Console.WriteLine("ConsoleApp Loading.");
                    else if (i % 3 == 1)
                        Console.WriteLine("ConsoleApp Loading..");
                    else
                        Console.WriteLine("ConsoleApp Loading...");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static void StartPanel()
        {
            bool isEndStartPanel = false;
            bool isStartGame = true;
            ConsoleKey input;
            Console.Clear();
            Console.SetCursorPosition(27, 8);
            Console.WriteLine("飞行棋");

            while(!isEndStartPanel)
            {
                Console.SetCursorPosition(26, 11);
                Console.ForegroundColor = isStartGame ? ConsoleColor.Red : ConsoleColor.White;
                Console.WriteLine("开始游戏");
                Console.SetCursorPosition(26, 13);
                Console.ForegroundColor = isStartGame ? ConsoleColor.White : ConsoleColor.Red;
                Console.WriteLine("退出游戏");
                input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.W:
                        isStartGame = true;
                        break;
                    case ConsoleKey.S:
                        isStartGame = false;
                        break;
                    case ConsoleKey.Enter:
                        if(isStartGame)                       
                            gameState = EGameState.Game;                     
                        else                        
                            isEnd = true;                       
                        isEndStartPanel = true;
                        break;
                }
            }
        }
        static void Game()
        {
            bool isEndGame = false;
            Console.Clear();
            PrintWall();
            PrintHitInfo();
            Map map = new Map(19, 5, 90);
            map.Draw();
            Player player = new Player(EPlayerType.Player);
            Player ai = new Player(EPlayerType.AI);
            DrawPlayer();
            while(true)
            {
                Console.ReadKey(true);
                isEndGame = RandomMove(ref player, ref ai);
                map.Draw();
                DrawPlayer();
                if(isEndGame)
                {
                    Console.ReadKey(true);
                    gameState = EGameState.End;
                    break;
                }
                Console.ReadKey(true);
                isEndGame = RandomMove(ref ai, ref player);
                map.Draw();
                DrawPlayer();
                if (isEndGame)
                {
                    Console.ReadKey(true);
                    gameState = EGameState.End;
                    break;
                }
            }

            void PrintWall()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                for(int i = 0; i < height; i++)
                {
                    if(i == height - 1 || i == height - 7 || i == height - 12 || i == 0)
                    {
                        for(int j = 0; j < width / 2; j++)
                        {
                            Console.Write("■");
                        }
                    }
                    else
                    {
                        Console.Write("■");
                        Console.SetCursorPosition(width - 2, i);
                        Console.Write("■");
                    }
                }
            }
            void PrintHitInfo()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(2, height - 11);
                Console.Write("□:普通格子");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(2, height - 10);
                Console.Write("‖:暂停，一回合不动    ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("●:炸弹，倒退5格");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(2, height - 9);
                Console.Write("¤:时空隧道，随机倒退，暂停，换位置");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(2, height - 8);
                Console.Write("★:玩家   ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("▲:电脑   ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("◎:玩家电脑重合");

                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(2, height - 6);
                Console.Write("按任意键开始扔色子");
            }
            void DrawPlayer()
            {
                if(player.nowIndex == ai.nowIndex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(map.grids[player.nowIndex].position.x, map.grids[player.nowIndex].position.y);
                    Console.Write("◎");
                }
                else
                {
                    player.Draw(map);
                    ai.Draw(map);
                }
            }
            bool RandomMove(ref Player player1, ref Player player2)
            {
                Console.SetCursorPosition(2, height - 6);
                Console.Write("                                            ");
                Console.SetCursorPosition(2, height - 5);
                Console.Write("                                            ");
                Console.SetCursorPosition(2, height - 4);
                Console.Write("                                            ");
                Console.SetCursorPosition(2, height - 3);
                Console.Write("                                            ");
                Console.ForegroundColor = player1.type == EPlayerType.Player ? ConsoleColor.Cyan : ConsoleColor.Magenta;

                if (player1.isPause)
                {
                    Console.SetCursorPosition(2, height - 6);
                    Console.Write("处于暂停点，" + (player1.type == EPlayerType.Player ? "玩家暂停一回合" : "电脑暂停一回合"));
                    player1.isPause = false;
                    return false;
                }

                Random random = new Random();
                int randomNum = random.Next(1, 7);
                player1.nowIndex += randomNum;
                Console.SetCursorPosition(2, height - 6);
                Console.Write("{0}扔出的点数为: {1}", (player1.type == EPlayerType.Player ? "玩家" : "电脑"), randomNum);

                if (player1.nowIndex >= map.grids.Length - 1)
                {
                    player1.nowIndex = map.grids.Length - 1;
                    Console.SetCursorPosition(2, height - 5);
                    if(player1.type == EPlayerType.Player)                    
                        Console.Write("恭喜你，你先到达终点");                    
                    else                   
                        Console.Write("很遗憾，电脑先到达终点");
                    Console.SetCursorPosition(2, height - 4);
                    Console.Write("按任意键结束游戏");
                    return true;
                }
                else
                {
                    Grid grid = map.grids[player1.nowIndex];
                    switch (grid.type)
                    {
                        case EGridType.Normal:
                            Console.SetCursorPosition(2, height - 5);
                            Console.Write("{0}到达了安全的位置", (player1.type == EPlayerType.Player ? "玩家" : "电脑"));
                            Console.SetCursorPosition(2, height - 4);
                            Console.Write("请按任意键让{0}扔筛子", (player1.type == EPlayerType.AI ? "玩家" : "电脑"));
                            break;
                        case EGridType.Pause:
                            Console.SetCursorPosition(2, height - 5);
                            Console.Write("踩到了暂停，{0}下局暂停一回合", (player1.type == EPlayerType.Player ? "玩家" : "电脑"));
                            player1.isPause = true;                           
                            break;
                        case EGridType.Bomb:
                            player1.nowIndex -= 5;
                            Console.SetCursorPosition(2, height - 5);
                            Console.Write("{0}踩到了炸弹，退后5格", (player1.type == EPlayerType.Player ? "玩家" : "电脑"));
                            Console.SetCursorPosition(2, height - 4);
                            Console.Write("请按任意键让{0}扔筛子", (player1.type == EPlayerType.AI ? "玩家" : "电脑"));
                            if (player1.nowIndex < 0)
                                player1.nowIndex = 0;
                            break;
                        case EGridType.TimeTunnel:
                            Console.SetCursorPosition(2, height - 5);
                            Console.Write("{0}踩到了时空隧道", (player1.type == EPlayerType.Player ? "玩家" : "电脑"));
                            int randomIndex = random.Next(0, map.grids.Length);
                            if(randomIndex < 30)
                            {
                                player1.nowIndex -= 5;
                                if (player1.nowIndex < 0)
                                    player1.nowIndex = 0;
                                Console.SetCursorPosition(2, height - 4);
                                Console.Write("触发了倒退5格");
                            }
                            else if(randomIndex >= 30 && randomIndex < 60)
                            {
                                player1.isPause = true;
                                Console.SetCursorPosition(2, height - 4);
                                Console.Write("触发暂停1回合");

                            }
                            else
                            {
                                int temp = player1.nowIndex;
                                player1.nowIndex = player2.nowIndex;
                                player2.nowIndex = temp;
                                Console.SetCursorPosition(2, height - 4);
                                Console.Write("双方交换位置");
                            }
                            Console.SetCursorPosition(2, height - 3);
                            Console.Write("请按任意键让{0}扔筛子", (player1.type == EPlayerType.AI ? "玩家" : "电脑"));
                            break;
                    }
                }
                return false;
            }

        }
        static void EndPanel()
        {
            bool isEndEndPanel = false;
            bool isRestart = true;
            ConsoleKey input;
            Console.Clear();
            Console.SetCursorPosition(26, 8);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("结束游戏");

            while (!isEndEndPanel)
            {
                Console.SetCursorPosition(26, 11);
                Console.ForegroundColor = isRestart ? ConsoleColor.Red : ConsoleColor.White;
                Console.WriteLine("开始游戏");
                Console.SetCursorPosition(26, 13);
                Console.ForegroundColor = isRestart ? ConsoleColor.White : ConsoleColor.Red;
                Console.WriteLine("退出游戏");
                input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.W:
                        isRestart = true;
                        break;
                    case ConsoleKey.S:
                        isRestart = false;
                        break;
                    case ConsoleKey.Enter:
                        if (isRestart)                       
                            gameState = EGameState.Start;                                                   
                        else                        
                            isEnd = true;                       
                        isEndEndPanel = true;
                        break;
                }
            }
        }

        private enum EGameState
        {
            Start,
            Game,
            End
        }
        enum EGridType
        {
            Normal,
            Pause,
            Bomb,
            TimeTunnel
        }
        struct Grid
        {
            public Vector2 position;
            public EGridType type;
            public Grid(int x, int y, EGridType type)
            {
                this.position.x = x;
                this.position.y = y;
                this.type = type;
            }
            public void Draw()
            {
                Console.SetCursorPosition(position.x, position.y);
                switch (type)
                {
                    case EGridType.Normal:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("□");
                        break;
                    case EGridType.Pause:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("‖");
                        break;
                    case EGridType.Bomb:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("●");
                        break;
                    case EGridType.TimeTunnel:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("¤");
                        break;
                }
            }
        }
        struct Vector2
        {
            public int x;
            public int y;
            public Vector2(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        struct Map
        {
            public Grid[] grids;
            public Map(int x, int y, int num)
            {
                Random random = new Random();
                int randomNum;
                int indexX = 0;
                int indexY = 0;
                bool isAdd = true;
                grids = new Grid[num];
                for(int i = 0; i < num; i++)
                {
                    randomNum = random.Next(1, 101);
                    if (randomNum < 85 || i == 0 || i == num - 1)
                        grids[i].type = EGridType.Normal;
                    else if(randomNum >= 85 && randomNum < 90)                   
                        grids[i].type = EGridType.Pause;                   
                    else if(randomNum >= 90 && randomNum < 95)                    
                        grids[i].type = EGridType.Bomb;                  
                    else
                        grids[i].type = EGridType.TimeTunnel;
                    if (indexX != 0 && indexX % 10 == 0 && indexY < 1)
                    {
                        indexY++;
                        y++;
                        isAdd = !isAdd;
                    }
                    else
                    {
                        if (indexY == 1)
                        {
                            y++;
                            indexY = 0;
                        }
                        else
                        {
                            x = isAdd ? x + 2 : x - 2;
                        }
                        indexX++;
                    }
                    grids[i].position.x = x;
                    grids[i].position.y = y;
                }
            }

            public void Draw()
            {
                for(int i = 0; i < grids.Length; i++)
                {
                    grids[i].Draw();
                }
            }
        }
        struct Player
        {
            public EPlayerType type;
            public int nowIndex;
            public bool isPause;
            public Player(EPlayerType type)
            {
                this.nowIndex = 0;
                this.type = type;
                this.isPause = false;
            }
            public void Draw(Map map)
            {
                Console.SetCursorPosition(map.grids[nowIndex].position.x, map.grids[nowIndex].position.y);
                Console.ForegroundColor = type == EPlayerType.AI ? ConsoleColor.DarkMagenta : ConsoleColor.Cyan;
                Console.Write(type == EPlayerType.AI ? "▲" : "★");
            }
        }
        enum EPlayerType
        {
            Player,
            AI
        }
    }
}
