using System;

namespace NessCS
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            using (Game game = new Game())
            {
                game.Run(30, 30);
            }
        }
    }
}
