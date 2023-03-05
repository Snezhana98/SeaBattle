using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace SeaBattle
{
    public class Ship
    {
        List<Paluba> ship;
        public Ship(int count)
        {
            for (int i = 0; i < count; i++)
            {
                ship[i] = new Paluba();
            }
        }

    }
}
