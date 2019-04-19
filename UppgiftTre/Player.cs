using System;

namespace UppgiftTre
{
    internal partial class Program
    {
        public class Player
        {
            public int X = DevHelper.XLimit/2;
            public int Y = DevHelper.YLimit/2;

            /// <summary>
            /// Moves the player one step in the wanted direction.
            /// </summary>
            /// <param name="direction">Direction that the player is to be moved in.</param>
            public void Move(string direction)
            {
                switch (direction)
                {
                    case DevHelper.Up:
                        if (Y > 1)
                        {
                            // EraseHero() använder funktionen Console.SetCursorPosition(X, Y) för att sätta pekaren på spelarens x koordinat och sudda ut det som står i konsolen. 
                            EraseHero();
                            // Sedan så minskas Y värdet på Player.
                            Y--;
                            // Tillsist så ritas Player ut med sina X och Y värden, denna gången har y-värdet dock ändrats vilket gör att det ser ut som att den rört sig.
                            // Detta händer på "Down", "Left" och "Right" förutom att X & Y värdena ändras på olika sätt.
                            // OBS! den ända skillnaden på Erase och Draw är att Draw ritar ut "H" medan Erase ritar ut " " ett space vilket gör att det ser ut som ingenting är där. 
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

            /// <summary>
            /// Draws the hero at it's X and Y coordinates.
            /// </summary>
            public void DrawHero()
            {
                Console.SetCursorPosition(X, Y);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("H");
            }

            /// <summary>
            /// Erases the hero at it's X and Y coordinates. 
            /// </summary>
            public void EraseHero()
            {
                Console.SetCursorPosition(X,Y);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
        }
    }
}