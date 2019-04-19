using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UppgiftTre
{
    internal partial class Program
    {
        public class GameContainer
        {
            private ConsoleKeyInfo _keyInfo;
            // Här skapas och sparas våran spelare.
            private Player _player = new Player();

            private Random rnd = new Random();
            
            // I walllist sparas alla väggar.
            public static List<Wall> WallList = new List<Wall>();
        
            /// <summary>
            /// Detects up,down, right and left arrow to move the player accordingly. 
            /// </summary>
            public void HandleInput()
            {
                if (Console.KeyAvailable)
                {
                    // Console.ReadKey läser av vilken knapp som trycktes.
                    _keyInfo = Console.ReadKey(true);
                    // Switchen används för att kolla om _keyInfo.Key är lika med ConsoleKey.UpArrow eller ConsoleKey.DownArrow eller ConsoleKey.LeftArrow eller ConsoleKey.RightArrow.
                    switch (_keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            // Kollar först om player krockar med någonting.
                            // Om CheckPlayerCollision returnerar false så sker ingenting, returnerar den true så rör sig spelaren med hjälp av Move().
                            if (CheckPlayerCollision(DevHelper.Up))
                                _player.Move(DevHelper.Up);

                            break;
                        case ConsoleKey.DownArrow:
                            if (CheckPlayerCollision(DevHelper.Down))
                                _player.Move(DevHelper.Down);
                            break;
                        case ConsoleKey.LeftArrow:
                            if (CheckPlayerCollision(DevHelper.Left))
                                _player.Move(DevHelper.Left);
                            break;
                        case ConsoleKey.RightArrow:
                            if (CheckPlayerCollision(DevHelper.Right))
                                _player.Move(DevHelper.Right);
                            break;
                    }
                } 
            }

            /// <summary>
            /// Checks if the player is going to collide with something.
            /// </summary>
            /// <param name="direction"></param>
            /// <returns></returns>
            public bool CheckPlayerCollision(string direction)
            {
                // Beroende på direction så ändras possibleX och possibleY.
                var possibleX = _player.X;
                var possibleY = _player.Y;
                switch (direction)
                {
                    case DevHelper.Up:
                        // Om spelaren vill gå upp så minskas y med 1;
                        possibleY -= 1;
                        break;
                    case DevHelper.Down:
                        // Om spelaren vill gå ned så ökas y med 1;
                        possibleY += 1;
                        break;
                    case DevHelper.Right:
                        // Om spelaren vill gå ned så ökas x med 1;
                        possibleX += 1;
                        break;
                    case DevHelper.Left:
                        // Om spelaren vill gå ned så minskas x med 1;
                        possibleX -= 1;
                        break;
                }
                
                // Sedan loopar vi igenom alla väggar i wallList för att kolla om deras koordinater matchar. 
                for (int i = 0; i < WallList.Count; i++)
                {
                    // Kollar om väggen i har samma x och y koordinater, om det har det så returneras false.
                    if (WallList[i].X == possibleX && WallList[i].Y == possibleY)
                    {
                        return false;
                    }
                }
                
                // returnerar true då ingen vägg har samma koordinater som possibleX och possibleY
                return true;
            }
        }
    }
}