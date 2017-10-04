using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.IO;

namespace RPGGame
{
    class Map
    {
        FoxDraw foxDraw;
        int x = 0;
        int y = 0;
        int n = 10;

        public Map(FoxDraw foxdraw)
        {
            this.foxDraw = foxdraw;
        }
        public void DrawMap()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    x += 50;
                    foxDraw.AddImage(@"../../Assets/floor.png", x, y);
                }
                y += 50;
                x = 0;
            }
        }  
        
        public void Walls()
        {
            StreamReader map = new StreamReader(@"../../Assets/MapFile.txt");
            string line = map.ReadLine();
            //int row = 10;
            //int col = 10;
            while (line != null)
            {
                string[] letters = line.Split(' ');

                foreach (string letter in letters)
                {
                    
                    if (letter.Equals("t"))
                    {
                        foxDraw.AddImage(@"../../Assets/floor.png", x , y);

                    }
                    else
                    {
                        foxDraw.AddImage("../../Assets/wall.png", x, y);

                    }
                    x += 50;
                }
                line = map.ReadLine();

                x = 0;
                y += 50;
            }
        }

        public void Monster()
        {

        }
    }
}
