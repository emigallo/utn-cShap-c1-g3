using GUI.ViewModel;
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

namespace GUI.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class TicTacToeView : Window 
    {

        private TicTacToeViewModel _vm;
        
        public TicTacToeView(String player1,String player2)
        {
            InitializeComponent();
            _vm = new TicTacToeViewModel(player1,player2); 
            DataContext = _vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            
            String key = button.Tag.ToString();

            Coordinates coord = _vm.GetCoordinate(key);

            Boolean _matchWin = _vm.PlayGame(coord.X, coord.Y); //Colocar en if

            button.IsEnabled = false;

            button.Content = _vm.GetSymbol();

            if (_matchWin)
            {
                MessageBox.Show("Gano el Jugador: " + "Tic Tac Toe");
            }   

        }
    }
}
