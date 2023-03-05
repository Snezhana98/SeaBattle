using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace SeaBattle
{
    public class Ship
    {
        Viewbox viewbox;
        TextBlock OneFieldShip;
        public Ship()
        {

        }
        public void CreateFour(Grid grid, int x, int y)
        {
            OneFieldShip = new TextBlock();
            OneFieldShip.Text = "🚢";
            viewbox = new Viewbox();
            viewbox.Child = OneFieldShip;
            grid.Children.Add(viewbox);
            Grid.SetColumn(viewbox, x);
            Grid.SetRow(viewbox, y);
        }
    }
}
