using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace SeaBattle
{ 
    class Game
    {
        Grid gridEnemy;
        Grid gridPlayer;
        public Field[,] matrixEnemy = new Field[10, 10];
        public Field[,] matrixPlayer = new Field[10, 10];
        TextBlock status;
        public Game(Grid gr1, Grid gr2, TextBlock st)
        {
            gridEnemy = gr1;
            gridPlayer = gr2;
            gridEnemy.Children.Clear();
            gridPlayer.Children.Clear();
            ClearGrid();
            OnGridFieldEnemy(gridEnemy);
            OnGridFieldPlayer(gridPlayer);
            //CreateShipsEnemy(gridEnemy);
            CreateBorderEnemy();

            status = st;
            status.Text = "Расставьте свои корабли";

        }
        void ClearGrid()
        {
            for (int i = 0; i < 8; i++)
            {
                gridEnemy.RowDefinitions.Clear();
                gridPlayer.RowDefinitions.Clear();
                gridEnemy.ColumnDefinitions.Clear();
                gridPlayer.ColumnDefinitions.Clear();
            }
        }
        void OnGridFieldEnemy(Grid gridEnemy)
        {
            for (int i = 0; i < 10; i++)
            {
                ColumnDefinition colDef = new ColumnDefinition();
                gridEnemy.ColumnDefinitions.Add(colDef);
                RowDefinition rowDef = new RowDefinition();
                gridEnemy.RowDefinitions.Add(rowDef);
            }
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    matrixEnemy[i, j] = new Field();

                }
        }
        void OnGridFieldPlayer(Grid gridPlayer)
        {
            for (int i = 0; i < 10; i++)
            {
                ColumnDefinition colDef = new ColumnDefinition();
                gridPlayer.ColumnDefinitions.Add(colDef);
                RowDefinition rowDef = new RowDefinition();
                gridPlayer.RowDefinitions.Add(rowDef);
            }
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    matrixPlayer[i, j] = new Field();

                }
        }
        void CreateBorderEnemy()
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    matrixEnemy[i, j].SetBorderEnemy(i, j, gridEnemy);
                    matrixPlayer[i, j].SetBorderPlayer(i, j, gridPlayer);
                }
        }
        //void CreateShipsEnemy(Grid gridEnemy)
        //{
        //    Random random = new Random();
        //    Ship[] four = new Ship[4];
            
        //    int X = random.Next(0, 9);
        //    int Y = random.Next(0, 9);

        //    four[0].CreateFour(gridEnemy, X, Y);
        //    if (!matrixEnemy[X, Y].HaveShip)
        //    {
        //        for (int i = 1; i < 4; i++)
        //        {

        //            int k = random.Next(-1, 1);
        //            int l = random.Next(-1, 1);
        //            if (k ==0 && l == 0)
        //            {
        //                i--;
        //                continue;
        //            }
        //            matrixEnemy[X+k, Y+l].HaveShip = true;
        //            four[i].CreateFour(gridEnemy, X + k, Y + l);

        //        }
        //    }
        //}
        public void LeftMouse(Field field)
        {
            field.borderEnemy.Background = null;
        }
    }

}
