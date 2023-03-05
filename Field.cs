using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SeaBattle
{
    class Field
    {

        public Border borderEnemy;
        public Border borderPlayer;
        public Field()
        {
            
        }
        public void SetBorderEnemy(int i, int j, Grid grid)
        {
            int x = i;
            int y = j;
            borderEnemy = new Border();
            borderEnemy.Background = null; /*Brushes.LightGray;*/
            borderEnemy.BorderBrush = Brushes.Black;
            borderEnemy.BorderThickness = new Thickness(1);
            //border.Width = 30;
            //border.Height = 30;
            borderEnemy.Tag = this;
            grid.Children.Add(borderEnemy);
            Grid.SetColumn(borderEnemy, x);
            Grid.SetRow(borderEnemy, y);
        }
        public void SetBorderPlayer(int i, int j, Grid grid)
        {
            int x = i;
            int y = j;
            borderPlayer = new Border();
            borderPlayer.Background = null;
            borderPlayer.BorderBrush = Brushes.Black;
            borderPlayer.BorderThickness = new Thickness(1);
            grid.Children.Add(borderPlayer);
            Grid.SetColumn(borderPlayer, x);
            Grid.SetRow(borderPlayer, y);
        }
        public void CreateShip()
        {
            Ship ship1 = new Ship(4);
        }
    }
}
