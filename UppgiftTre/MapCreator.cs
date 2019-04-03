using System;

namespace UppgiftTre
{
    public class MapCreator
    {
        public void MapSettings()
        {
            Console.CursorVisible = false;
            HorizontalWalls(0,Program.DevHelper.XLimit+1, Program.DevHelper.YLimit+1);
            VerticalWalls(1, Program.DevHelper.YLimit+2, Program.DevHelper.XLimit+1);
            HorizontalWalls(0, Program.DevHelper.XLimit/2, Program.DevHelper.YLimit/2);
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