namespace ConsoleApp1
{
    internal class Program
    {
        static bool isEnd;
        static ConsoleKey key;
        const int windowWidth = 60;
        const int windowHeight = 40;
        static GameState state;
        static string gameEndStr = "";
        static void Main(string[] args)
        {
            InitProject();
            while(!isEnd)
            {
                switch (state)
                {
                    case GameState.StartPanel:
                        StartPanel();
                        break;
                    case GameState.Game:
                        Game();
                        break;
                    case GameState.EndPanel:
                        EndPanel();
                        break;
                }
            }
            void InitProject()
            {
                Console.SetWindowSize(windowWidth, windowHeight);
                Console.SetBufferSize(windowWidth, windowHeight);
                Console.CursorVisible = false;
            }
        }
        public static void StartPanel()
        {
            Console.Clear();
            PrintPanel(true);
            ConsoleKey key;
            bool isStart = true;
            bool isEndPanel = false;
            while(!isEndPanel)
            {
                key = Console.ReadKey(true).Key;
                switch(key)
                {
                    case ConsoleKey.W:
                        PrintPanel(true);
                        break;
                    case ConsoleKey.S:
                        PrintPanel(false);
                        break;
                    case ConsoleKey.Enter:
                        isEndPanel = true;
                        if (isStart)
                            state = GameState.Game;
                        else      
                            isEnd = true;                       
                        break;
                }
            }
            void PrintPanel(bool isStartToggle)
            {
                isStart = isStartToggle;
                Console.SetCursorPosition(23, 10);
                Console.Write("唐老狮营救公主");
                Console.ForegroundColor = isStartToggle ? ConsoleColor.Red : ConsoleColor.White;
                Console.SetCursorPosition(26, 13);
                Console.Write("开始游戏");
                Console.ForegroundColor = isStartToggle ? ConsoleColor.White : ConsoleColor.Red;
                Console.SetCursorPosition(26, 15);
                Console.Write("退出游戏");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static void EndPanel()
        {
            Console.Clear();
            bool isExit = false;
            ConsoleKey key = default(ConsoleKey);
            PrintPanel(false);
            bool isEndPanel = false;
            while(!isEndPanel)
            {
                key = Console.ReadKey(true).Key;
                switch(key)
                {
                    case ConsoleKey.W:
                        PrintPanel(false);
                        break;
                    case ConsoleKey.S:
                        PrintPanel(true);
                        break;
                    case ConsoleKey.Enter:
                        isEndPanel = true;
                        if (isExit)                    
                            isEnd = true;                       
                        else
                            state = GameState.StartPanel;
                        break;
                }
            }

            void PrintPanel(bool isExitToggle)
            {
                isExit = isExitToggle;
                Console.SetCursorPosition(26, 6);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("GameOver");
                Console.SetCursorPosition(26, 8);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(gameEndStr);
                Console.ForegroundColor = !isExitToggle ? ConsoleColor.Red : ConsoleColor.White;
                Console.SetCursorPosition(24, 10);
                Console.Write("回到开始界面");
                Console.ForegroundColor = !isExitToggle ? ConsoleColor.White : ConsoleColor.Red;
                Console.SetCursorPosition(26, 12);
                Console.Write("退出游戏");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static void Game()
        {
            Console.Clear();
            InitProject();
            Random random = new Random();
            int cursorPosX = 2;
            int cursorPosY = 1;
            int monsterPosX = 0;
            int monsterPosY = 0;
            int prinessPosX = 0;
            int prinessPosY = 0;
            int myHp = 100;
            int monsterHp = 100;
            bool isFight = false;
            Bool2 isWin = Bool2.None;
            bool isEndGame = false;
            PrintWall();
            PrintMonster();
            while (!isEndGame)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (cursorPosX == monsterPosX && cursorPosY == monsterPosY)
                {
                    continue;
                }
                Console.SetCursorPosition(cursorPosX, cursorPosY);
                Console.Write("●");
                key = Console.ReadKey(true).Key;
                if (isWin == Bool2.True && key != ConsoleKey.J)
                    continue;
                Console.SetCursorPosition(cursorPosX, cursorPosY);
                Console.Write("  ");
                switch (key)
                {
                    case ConsoleKey.W:
                        if(!((cursorPosX == monsterPosX) && (cursorPosY == monsterPosY + 1)))
                            cursorPosY = cursorPosY < 0 ? 0 : (cursorPosY - 1);
                        break;
                    case ConsoleKey.S:
                        if (!((cursorPosX == monsterPosX) && (cursorPosY == monsterPosY - 1)))
                            cursorPosY = cursorPosY + 1 > Console.BufferHeight - 7 ? Console.BufferHeight - 7 : (cursorPosY + 1);
                        break;
                    case ConsoleKey.D:
                        if (!((cursorPosX == monsterPosX - 2) && (cursorPosY == monsterPosY)))
                            cursorPosX = cursorPosX + 2 >= Console.BufferWidth - 4 ? windowWidth - 4 : (cursorPosX + 2);
                        break;
                    case ConsoleKey.A:
                        if (!((cursorPosX == monsterPosX + 2) && (cursorPosY == monsterPosY)))
                            cursorPosX = cursorPosX < 0 ? 0 : (cursorPosX - 2);
                        break;
                    case ConsoleKey.J:
                        if ((cursorPosY == monsterPosY && (cursorPosX == monsterPosX - 2 || cursorPosX == monsterPosX + 2)) ||
                            ((cursorPosX == monsterPosX) && (cursorPosY == monsterPosY - 1 || cursorPosY == monsterPosY + 1)))
                        {
                            if(isWin == Bool2.None)
                                PrintMessage(random.Next(1, 20), random.Next(1, 20));
                            else if(isWin == Bool2.True)
                            {
                                Console.SetCursorPosition(monsterPosX, monsterPosY);
                                Console.Write("  ");
                                monsterPosX = prinessPosX;
                                monsterPosY = prinessPosY;
                                isWin = Bool2.Win;
                            }
                            else if (isWin == Bool2.False || isWin == Bool2.Win)
                            {
                                isEndGame = true;
                                state = GameState.EndPanel;
                            }
                        }
                        break;
                }
            }
            void InitProject()
            {
                Console.CursorVisible = false;
            }
            void PrintWall()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                for(int i = 0; i < windowHeight; i++)
                {
                    if(i == 0 || i == windowHeight - 6 || i == windowHeight - 1)
                    {
                        for (int j = 0; j < windowWidth / 2; j++)
                        {
                            Console.Write("■");
                        }
                    }
                    else
                    {
                        Console.Write("■");
                        Console.SetCursorPosition(windowWidth - 2, i);
                        Console.Write("■");
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            void PrintMonster()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                monsterPosX = random.Next(2, windowWidth - 3);
                monsterPosX = monsterPosX % 2 != 0 ? monsterPosX + 1 : monsterPosX; 
                monsterPosY = random.Next(2, windowHeight - 6);
                Console.SetCursorPosition(monsterPosX, monsterPosY);
                Console.Write("■");
                Console.ForegroundColor = ConsoleColor.White;
            }
            void PrintWin()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                prinessPosX = random.Next(2, windowWidth - 1);
                prinessPosX = prinessPosX % 2 != 0 ? prinessPosX + 1 : prinessPosX;
                prinessPosY = random.Next(2, windowHeight - 6);
                Console.SetCursorPosition(prinessPosX, prinessPosY);
                Console.Write("★");
            }
            void PrintMessage(int monsterAtk, int playerAtk)
            {
                if(!isFight)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(2, windowHeight - 5);
                    Console.Write("开始和Boss战斗了，按J继续");
                    Console.SetCursorPosition(2, windowHeight - 4);
                    Console.Write("Boss血量: {0}", monsterHp);
                    Console.SetCursorPosition(2, windowHeight - 3);
                    Console.Write("玩家血量: {0}", myHp);
                    isFight = true;
                }
                else
                {
                    monsterHp -= playerAtk;
                    myHp -= monsterAtk;                    
                    if (myHp <= 0 || monsterHp <= 0)
                    {
                        if(myHp <= 0 && monsterHp > 0)
                        {
                            Console.SetCursorPosition(2, windowHeight - 4);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("你对Boss造成了{0}伤害，当前Boss血量: {1}     ", playerAtk, monsterHp);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(2, windowHeight - 3);
                            Console.Write("很遗憾，你未能通过boss的试炼，战败了       ", monsterAtk, myHp);
                            isWin = Bool2.False;
                            gameEndStr = "游戏失败";
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(2, windowHeight - 5);
                            Console.Write(monsterHp <= 0 ? "你战胜了Boss，快去营救公主                           " : "");
                            Console.SetCursorPosition(2, windowHeight - 4);
                            Console.Write(monsterHp <= 0 ? "到公主身边按J键继续                    " : "很遗憾，你未能通过boss的试炼，战败了                        ");
                            Console.SetCursorPosition(2, windowHeight - 3);
                            Console.Write("                                            ");
                            PrintWin();
                            isWin = Bool2.True;
                            gameEndStr = "游戏通关";
                        }             
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(2, windowHeight - 5);
                        Console.Write("开始和Boss战斗了，按J继续");
                        Console.SetCursorPosition(2, windowHeight - 4);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("你对Boss造成了{0}伤害，当前Boss血量: {1}     ", playerAtk, monsterHp);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(2, windowHeight - 3);
                        Console.Write("Boss对你造成了{0}伤害，当前你的血量: {1}      ", monsterAtk, myHp);
                    }
                }
            }
        }
    }
    public enum Bool2
    {
        None,
        True,
        False,
        Win
    }
    public enum GameState
    {
        StartPanel,
        Game,
        EndPanel,
    }
}
