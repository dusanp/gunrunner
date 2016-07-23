using gunrunner.try2;
using System;

namespace GunRunner_v2
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new GameMaster())
                game.Run();
        }
    }
#endif
}
