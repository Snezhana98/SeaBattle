using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SeaBattle
{
    public class Field
    {
        public Grid gridEnemy;
        public Grid gridPlayer;
        public Border borderEnemy;
        public Border borderPlayer;
        public bool HaveShip = false;
        bool empty = true;
        //public Field[,] matrixEnemy = new Field[10, 10];
        //public Field[,] matrixPlayer = new Field[10, 10];
        public Field(Grid gr1, Grid gr2)
        {
            
            gridEnemy = gr1;
            gridPlayer = gr2;
            ClearGrid();
            gridEnemy.Children.Clear();
            gridPlayer.Children.Clear();
            OnGridFieldEnemy(gridEnemy);
            OnGridFieldPlayer(gridPlayer);
            //CreteShipsEnemy();
            CreateBorderEnemy();
        }

        public void ClearGrid()
        {
            for (int i = 0; i < 10; i++)
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
            //gridEnemy.ShowGridLines = true;
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
            //gridPlayer.ShowGridLines = true;
        }
        void CreateBorderEnemy()
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    SetBorderEnemy(i, j, gridEnemy);
                    SetBorderPlayer(i, j, gridPlayer);

                }
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
        public void ShipsEnemy(Grid grid, int X, int Y)
        { 
                Ship ship = new Ship();
                ship.CreateShip(X, Y, grid);            
        }

        //void CreteShipsEnemy()
        //{
        //    Random random = new Random();
        //    for (int i = 0; i < 10; i++)
        //    {

        //        int X = random.Next(1, 8);
        //        int Y = random.Next(1, 8);
                
        //        if (!HaveShip)
        //        {
        //            HaveShip = true;
        //            ShipsEnemy(gridEnemy, X, Y);
        //        }
        //        else i--;

        //        for (int j = 0; j < 4; j++)
        //        {
        //            Random random1 = new Random();
        //            int K = random1.Next(-1, 1);
        //            int L = random1.Next(-1, 1);
        //            if (K == L)
        //            {
        //                j--;
        //            }
        //            else
        //            {
        //                matrixEnemy[X + K, Y + L].ShipsEnemy(gridEnemy, X + K, Y + L);
        //                X = X + K;
        //                Y = Y + L;
        //            }

        //        }

        //    }
        }
    }

