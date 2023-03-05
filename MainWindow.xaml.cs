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

namespace SeaBattle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Game game;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClickPlay(object sender, RoutedEventArgs e)
        {
            game = new Game(GridComp, GridPlayer, Status);
        }

        private void OnClickShips(object sender, RoutedEventArgs e)
        {

        }

        private void LeftMouse(object sender, MouseButtonEventArgs e)
        {
            if (e.OriginalSource is Border border)
            {
                game.LeftMouse(border.Tag as Field);
            }
        }

    }
}
