using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.Windows.Input;

namespace RPGGame
{
    class Hero
    {
        FoxDraw foxDraw;
        public double x = 0;
        public double y = 0;

        public Hero(FoxDraw foxdraw)
        {
            this.foxDraw = foxdraw;

        }

        public void AppearHero()
        {
            foxDraw.AddImage(@"../../Assets/hero.png", x, y);

        }
    }
}
