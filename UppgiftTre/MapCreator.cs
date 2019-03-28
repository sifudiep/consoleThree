using System;

namespace UppgiftTre
{
    public class MapCreator
    {
        public void MapSettings()
        {
            Console.CursorVisible = false;
            HorizontalWalls(0,Program.DevHelper.XLimit, Program.DevHelper.YLimit+1);
            VerticalWalls(0, Program.DevHelper.YLimit, Program.DevHelper.XLimit+1);
        }
    
        public void HorizontalWalls(int from, int to, int y)
        {
            for (int i = from; i < to; i++)
            {
                var wall = new Wall(i, y);
                Program.GameContainer.WallList.Add(wall);
                wall.Draw();
            }
        }

        public void VerticalWalls(int from, int to, int x)
        {
            for (int i = from; i < to; i++)
            {
                var wall = new Wall(x, i);
                Program.GameContainer.WallList.Add(wall);
                wall.Draw();
            }
        }
    }
}