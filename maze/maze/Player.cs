using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze
{
    internal class Player
    {
        public void Walk(String[,] maze, int[] playerposition)
        {
            World world = new World();
            Game game = new Game();
            ConsoleKeyInfo keypress = Console.ReadKey();
            // Update players new position after keypress

            //links, rechts
            if (keypress.KeyChar == 'd')
            {
                playerposition[1]++;
                if(!world.Canwalk(maze, playerposition[0], playerposition[1]))
                {
                    playerposition[1]--;
                }
            }
            if (keypress.KeyChar == 'a')
            {
                playerposition[1]--;
                if (!world.Canwalk(maze, playerposition[0], playerposition[1]))
                {
                    playerposition[1]++;
                }
            }

            //boven, onder
            if (keypress.KeyChar == 'w')
            {
                playerposition[0]--;
                if (!world.Canwalk(maze, playerposition[0], playerposition[1]))
                {
                    playerposition[0]++;
                }
            }
            if (keypress.KeyChar == 's')
            {
                playerposition[0]++;
                if (!world.Canwalk(maze, playerposition[0], playerposition[1]))
                {
                    playerposition[0]--;
                }
            }
        }
    }
}
