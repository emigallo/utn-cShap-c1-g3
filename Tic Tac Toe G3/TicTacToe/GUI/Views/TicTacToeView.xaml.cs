using GUI.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace GUI.Views
{

    public partial class TicTacToeView : Window 
    {
        private TicTacToeViewModel _vm;
        private String _currentPlayer;
        private LobbyView _lobby;

        public TicTacToeView(String player1,String player2)
        {
            _lobby = new LobbyView();
            InitializeComponent();
            _vm = new TicTacToeViewModel(player1,player2); 
            DataContext = _vm;
            lbl_CurrentPlayer.Content = _vm.GetCurrentPlayer();
            this.Background = new ImageBrush(new BitmapImage(new Uri("../../../Assets/paper.png", UriKind.Relative)));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            
            String key = button.Tag.ToString();

            Coordinates coord = _vm.GetCoordinate(key);

            Boolean _gameOver = _vm.PlayGame(coord.X, coord.Y);
            

            button.IsEnabled = false;

            button.Content = _vm.GetSymbol();

            _currentPlayer = _vm.GetCurrentPlayer();

            lbl_CurrentPlayer.Content = _currentPlayer;

            if (_gameOver)
            {
                if (_vm.CheckWinner() )
                {
                    MessageBox.Show("Gano: " + _currentPlayer);
                }
                else
                {
                    MessageBox.Show("Empate");                  
                }

            }   

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            btn9.IsEnabled = true;

            btn1.Content = "";
            btn2.Content = "";
            btn3.Content = "";
            btn4.Content = "";
            btn5.Content = "";
            btn6.Content = "";
            btn7.Content = "";
            btn8.Content = "";
            btn9.Content = "";


            _vm.PlayAgain();
          
          
        }

        private void Btn_Exit(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void btn_back(object sender, RoutedEventArgs e)
        {
            this.Hide();          
            _lobby.Show();
        
        }
    }
}
