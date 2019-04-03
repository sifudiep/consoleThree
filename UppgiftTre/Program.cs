using System.Diagnostics;
using System.Threading;

namespace UppgiftTre
{
  // Fixa så att coins inte spawnar på walls genom att loopa genom wallList
  // Lägg till timer
  // Lägg till Scoreboard med mongoDB 
  // Lägg till Jump Mechanic ?? "Hoppa" X steg
  internal partial class Program
  {
    public static void Main(string[] args)
    {
      var gc = new GameContainer();
      var mapCreator = new MapCreator();
      mapCreator.MapSettings();
      gc.ScoreSpawner.Start();

      while (true)
      {
        gc.HandleInput();
        gc.CheckScoreSpawn();
      }
    }
  }
}