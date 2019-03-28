using System;

namespace UppgiftTre
{
    public class ScoreObject
    {
        public ScoreObject(int x, int y)
        {
            X = x;
            Y = y;
        }
    
        public int X;
        public int Y;

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("C");
        }
    }
}