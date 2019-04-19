namespace UppgiftTre
{
    internal partial class Program
    {
        public /*HÄR*/ static class DevHelper
        {
            // Denna klassen används för att random strängar och integraler inte ska användas på platser,
            // detta minskar risken för problem som debuggern inte kan hitta samt att det blir lättare att läsa och ändra värden.
            // Anledningen till varför vi kan använda denna klassen överallt är pga "static" framför class.
            public const string Up = "UP";
            public const string Down = "DOWN";
            public const string Left = "LEFT";
            public const string Right = "RIGHT";
            public const int XLimit = 50;
            public const int YLimit = 10;
        }
    }
}