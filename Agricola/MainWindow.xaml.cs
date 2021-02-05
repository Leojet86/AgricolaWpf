using Agricola.Dialog;
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

namespace Agricola
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _numberOfPlayers;

        public MainWindow()
        {

            // TODO - start app maximized pour cuteness overload
            InitBoard();
            InitializeComponent();
        }

        private void InitBoard()
        {
            
        }

        private void startNewGame_Click(object sender, RoutedEventArgs e)
        {
            // TODO - open new game dialog return number of players
            NewGameDialog newGameDialog = new NewGameDialog();
            if (newGameDialog.ShowDialog() == true)
            {
                Console.WriteLine("===== NEW GAME YESSSSS =====");
                Console.WriteLine("===== Number of players : {0}", newGameDialog.NumberOfPlayers());
            }
        }
    }
}
