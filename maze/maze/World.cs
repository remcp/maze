using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace maze
{
    internal class World
    {
        public void Buildmaze(string[,] maze,int[] playerposition)
        {
            int rows = maze.GetLength(0);
            int cols = maze.GetLength(1);
            for(int y = 0; y < rows; y++)
            {
                for(int x = 0; x < cols; x++)
                {
                    string mazebuild = maze[y, x];
                    SetCursorPosition(x, y);
                    if (y == playerposition[0] && x == playerposition[1])
                    {
                        Write("o");
                    }
                    else
                    {
                        Write(mazebuild);
                    }
                }
            }
        }
        public Boolean Canwalk(string[,] maze, int y, int x)
        {
            return maze[y,x] == " " || maze[y, x] == "x";
        }
    }
}
