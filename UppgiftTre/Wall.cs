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
        
        // Väggar har endast X och Y koordinater så att GameContainer kan lista ut när player och väggar krockar med varandra. 
        
        public int X;
        public int Y;

        /// <summary>
        /// Draws out the wall on the console, using it's X and Y coordinates.
        /// </summary>
        public void Draw()
        {
            Console.SetCursorPosition(X,Y);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("#");
        }
    }
}