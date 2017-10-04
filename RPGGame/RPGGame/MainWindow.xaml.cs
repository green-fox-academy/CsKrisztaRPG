using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace RPGGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FoxDraw foxDraw;
        Hero hero;
        Map map;

        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            map = new Map(foxDraw);
            map.Walls();

            hero = new Hero(foxDraw);
            hero.AppearHero();

        }

        public void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                if (hero.x > 0)
                {
                    hero.x -= 50;
                    hero.AppearHero();
                    foxDraw.AddImage(@"../../Assets/hero-left.png", hero.x, hero.y);

                }
            }

            if (e.Key == Key.Right)
            {
                if (hero.x < 500)
                {
                    hero.x += 50;
                    hero.AppearHero();
                    foxDraw.AddImage(@"../../Assets/hero-right.png", hero.x, hero.y);
                    //foxDraw.SetPosition(hero.x, hero.y);

                }
            }

            if (e.Key == Key.Up)
            {
                if (hero.y > 0)
                {
                    hero.y -= 50;
                    hero.AppearHero();
                    foxDraw.AddImage(@"../../Assets/hero-up.png", hero.x, hero.y);
                }
      
            }

            if (e.Key == Key.Down)
            {
                if (hero.y < 500)
                {
                    hero.y += 50;
                    hero.AppearHero();
                    foxDraw.AddImage(@"../../Assets/hero-down.png", hero.x, hero.y);
                }              
            }
        }
    }
}