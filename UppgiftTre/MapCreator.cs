using System;

namespace UppgiftTre
{
    public class MapCreator
    {
        /// <summary>
        /// Creates all walls for the map. 
        /// </summary>
        public void MapSettings()
        {
            Console.CursorVisible = false;
            HorizontalWalls(0, Program.DevHelper.XLimit+1, 1);
            VerticalWalls(1, Program.DevHelper.YLimit+1, 0);
            HorizontalWalls(0,Program.DevHelper.XLimit+1, Program.DevHelper.YLimit+1);
            VerticalWalls(1, Program.DevHelper.YLimit+2, Program.DevHelper.XLimit+1);
            HorizontalWalls(0, Program.DevHelper.XLimit/2, Program.DevHelper.YLimit/2);
            VerticalWalls(1,Program.DevHelper.YLimit/2, Program.DevHelper.XLimit/2+1);
            VerticalWalls(1, Program.DevHelper.YLimit, Program.DevHelper.XLimit/2+15);
        }
    
        /// <summary>
        ///  Creates a horizontal line of walls.
        /// </summary>
        /// <param name="from">First wall x position.</param>
        /// <param name="to">Last wall x position</param>
        /// <param name="y">y position of all the horizontal walls.</param>
        public void HorizontalWalls(int from, int to, int y)
        {
            for (int i = from; i < to; i++)
            {
                var wall = new Wall(i, y);
                Program.GameContainer.WallList.Add(wall);
                wall.Draw();
            }
        }
        
        // Fråga om du inte förstår och vill veta hur algoritmerna funkar för HorizontalWalls() och VerticalWalls().

        /// <summary>
        /// Creates a vertical line of walls.
        /// </summary>
        /// <param name="from">First wall y position.</param>
        /// <param name="to">Last wall y position.</param>
        /// <param name="x">x position of all the vertical walls.</param>
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