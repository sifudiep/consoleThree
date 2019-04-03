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
            private Player _player = new Player();

            public int ScoreAmount = 0;
            public Stopwatch ScoreSpawner = new Stopwatch();
            private Random rnd = new Random();
            public List<ScoreObject> ScoreList = new List<ScoreObject>();
            
            public static List<Wall> WallList = new List<Wall>();
      
            public void HandleInput()
            {
                if (Console.KeyAvailable)
                {
                    if ((_keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
                    {
                        switch (_keyInfo.Key)
                        {
                            case ConsoleKey.UpArrow:
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
            }

            public bool CheckPlayerCollision(string direction)
            {
                var possibleX = _player.X;
                var possibleY = _player.Y;
                switch (direction)
                {
                    case DevHelper.Up:
                        possibleY -= 1;
                        break;
                    case DevHelper.Down:
                        possibleY += 1;
                        break;
                    case DevHelper.Right:
                        possibleX += 1;
                        break;
                    case DevHelper.Left:
                        possibleX -= 1;
                        break;
                }
                
                for (int i = 0; i < ScoreList.Count; i++)
                {
                    if (ScoreList[i].X == possibleX && ScoreList[i].Y == possibleY)
                    {
                        ScoreAmount += DevHelper.AddScore;
                        UpdateScoreText();
                        ScoreList.RemoveAt(i);
                        return true;
                    }
                }

                for (int i = 0; i < WallList.Count; i++)
                {
                    if (WallList[i].X == possibleX && WallList[i].Y == possibleY)
                    {
                        return false;
                    }
                }

                return true;
            }

            public void UpdateScoreText()
            {
                Console.SetCursorPosition(0, 0);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Score : " + ScoreAmount);
                Console.ForegroundColor = ConsoleColor.Black;
            }

            public void CheckScoreSpawn()
            {
                if (ScoreSpawner.ElapsedMilliseconds > 2000)
                {
                    var score = new ScoreObject(rnd.Next(0, DevHelper.XLimit), rnd.Next(1, DevHelper.YLimit));
                    ScoreList.Add(score);
                    score.Draw();
                    ScoreSpawner.Restart();
                }
            }
      
        }
    }
}