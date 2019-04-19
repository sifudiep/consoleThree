using System.Diagnostics;
using System.Linq.Expressions;
using System.Threading;

namespace UppgiftTre
{
  internal partial class Program
  {
    public static void Main(string[] args)
    {
      var gc = new GameContainer();
      var mapCreator = new MapCreator();
      // Startar map settings vilket skapar väggar.
      mapCreator.MapSettings();
      
      // Loopar HandleInput för att konstant kolla om spelaren klickat på knappar
      while (true)
      {
        gc.HandleInput();
      }
    }
  }
}