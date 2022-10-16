using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    class Program
    {
        static void Main(string[] args)
        {
            Game maze = new Game();
            Player player = new Player();
            World world = new World();
            bool gameover = false;

            maze.Start(gameover);

        }
    }
}
