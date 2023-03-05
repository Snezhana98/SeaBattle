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
            ShipsEnemy(gridEnemy);
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
        void ShipsEnemy(Grid grid)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int X = random.Next(0, 10);
                int Y = random.Next(0, 10);
                matrixEnemy[X, Y].CreateShip();

            }
        }
        public void LeftMouse(Field field)
        {
            field.borderEnemy.Background = null;
        }
    }

}
