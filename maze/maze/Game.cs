using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace maze
{
    internal class Game
    {
        public void Start(bool gameover)
        {
            World world = new World();
            Player player = new Player();
            int[] playerposition = {1, 2};
            String[,] maze =
            {
                {"-","-","-","-","-","-","-","-","-","-","-","-","-"},
                {"|"," "," "," "," "," "," "," "," "," "," "," ","|"},
                {"|"," ","-","-","-","-","-","-","-","-"," "," ","|"},
                {"|"," "," "," "," "," "," "," "," ","|"," "," ","|"},
                {"|","_","_","_","_","_","_","_","_","|"," "," ","|"},
                {"|"," "," "," "," "," "," "," "," "," "," "," ","|"},
                {"|"," ","|","_","_","_","_","_","_","_","_","_","|"},
                {"|"," "," "," "," "," "," "," "," "," "," ","x","|"},
                {"-","-","-","-","-","-","-","-","-","-","-","-","-"},
            };
            while (gameover == false)
            {
                player.Walk(maze, playerposition);
                world.Buildmaze(maze, playerposition);
                WriteLine();
            }
        }
    }
}
