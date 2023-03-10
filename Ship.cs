using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace SeaBattle
{
    public class Ship
    {
        bool killed = false;
        int count;
        List<Paluba> ship = new List<Paluba>();
        public Ship()
        {

        }
        public void CreateShip (int x, int y, Grid grid)
        {
            
                Paluba paluba = new Paluba();
                paluba.x = x;
                paluba.y = y;
                paluba.CreatePaluba(grid);
           
        }
    }
}
