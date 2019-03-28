using System;

namespace UppgiftTre
{
    internal partial class Program
    {
        public class GameContainer
        {
            private ConsoleKeyInfo _keyInfo;
            private Player _player = new Player();
      
            public void HandleInput()
            {
                if (Console.KeyAvailable)
                {
                    if ((_keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
                    {
                        switch (_keyInfo.Key)
                        {
                            case ConsoleKey.UpArrow:
                                _player.Move(DevHelper.Up);
                                break;
                            case ConsoleKey.DownArrow:
                                _player.Move(DevHelper.Down);
                                break;
                            case ConsoleKey.LeftArrow:
                                _player.Move(DevHelper.Left);
                                break;
                            case ConsoleKey.RightArrow:
                                _player.Move(DevHelper.Right);
                                break;
                        }
                    }
                } 
            }
      
        }
    }
}