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

        public TicTacToeView()
        {
            InitializeComponent();
            _vm = new TicTacToeViewModel(); 
            DataContext = _vm; 
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            String key = button.Tag.ToString();

            (int x, int y) = _vm.SendKey(key);

            Boolean _matchWin = _vm.PlayGame(x, y);
                

            button.Content = _vm.GetSymbol();

            if (_matchWin)
                MessageBox.Show("Juego Terminado", "Tic Tac Toe");
        }

    }
}
