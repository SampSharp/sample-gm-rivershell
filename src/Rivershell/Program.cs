using SampSharp.Core;

namespace Rivershell
{
    internal static class Program
    {
        public static void Main()
        {
            new GameModeBuilder()
                .Use<GameMode>()
                .Run();
        }
    }
}