using System;

namespace UppgiftTre
{
    internal partial class Program
    {
        public class Player
        {
            public int X = DevHelper.XLimit/2;
            public int Y = DevHelper.YLimit/2;

            public void Move(string direction)
            {
                switch (direction)
                {
                    case DevHelper.Up:
                        if (Y > 1)
                        {
                            EraseHero();
                            Y--;        
                            DrawHero();
                        }
                        break;
                    case DevHelper.Down:
                        if (Y < DevHelper.YLimit)
                        {
                            EraseHero();
                            Y++;
                            DrawHero();
                        }  
                        break;
                    case DevHelper.Left:
                        if (X > 0)
                        {
                            EraseHero();
                            X--;
                            DrawHero();  
                        }
                        break;
                    case DevHelper.Right:
                        if (X < DevHelper.XLimit)
                        {
                            EraseHero();
                            X++;
                            DrawHero();
                        }
                        break;
                }
            }

            public void DrawHero()
            {
                Console.SetCursorPosition(X, Y);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("H");
            }

            public void EraseHero()
            {
                Console.SetCursorPosition(X,Y);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
        }
    }
}