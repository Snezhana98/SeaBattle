using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace SeaBattle
{ 
    class Game
    {
        

        TextBlock status;
        public Game(Grid GridComp, Grid GridPlayer, TextBlock st)
        {
            Field field = new Field(GridComp, GridPlayer);         
            status = st;
            status.Text = "Расставьте свои корабли";
        }
     
        

        public void LeftMouse(Field field)
        {
            field.borderEnemy.Background = null;
        }
    }

}
