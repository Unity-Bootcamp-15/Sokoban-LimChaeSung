using System;

namespace Sokoban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Title = "Sokoban Game";

            // 플레이어 초기 설정
            int posX = 10;
            int posY = 10;

            char player = 'P';

            while (true)
            {
                Console.Clear();

                //화면 밖 나가지 않게하기
                if(posX<=0)
                {
                    posX = 0;
                }
                if (posX >= 119)
                {
                    posX = 119;
                }
                if (posY <= 0)
                {
                    posY = 0;
                }
                if(posY >= 29)
                {
                    posY = 29;
                }

                Console.SetCursorPosition(posX, posY);
                Console.Write(player);

                ConsoleKeyInfo info = Console.ReadKey();

                //if(info.Key == ConsoleKey.LeftArrow)
                //{

                //}
                                                             //스위치 문이 정답이었다
                switch (info.Key)
                {
                    case ConsoleKey.LeftArrow:
                        posX--;
                        break;

                    case ConsoleKey.RightArrow:
                        posX++;
                        break;

                    case ConsoleKey.UpArrow:
                        posY--;
                        break;

                    case ConsoleKey.DownArrow:
                        posY++;
                        break;

                    case ConsoleKey.Q: //Q 누르면 종료
                        Console.Clear();
                        return;
                }
            }
        }
    }
}
