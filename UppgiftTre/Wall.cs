using System;

namespace UppgiftTre
{
    public class Wall
    {
        public Wall(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X;
        public int Y;

        public void Draw()
        {
            Console.SetCursorPosition(X,Y);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("W");
        }
    }
}