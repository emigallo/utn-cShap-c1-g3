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
using System.Windows.Shapes;

namespace GUI.Views
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class LobbyView : Window
    {
        private TicTacToeView _ticTacToe;
        private String _player1;
        private String _player2;
        private MenuView _menuView;

        private Dictionary<String, Func<String,String>> _textBoxMap;
        public LobbyView()
        {

            _player1 = new String("");
            _player2 = new String("");
            _textBoxMap = new Dictionary<String, Func<String,String>>();
            _textBoxMap.Add("player1", val => _player1 = val);
            _textBoxMap.Add("player2",  val => _player2 = val);

            InitializeComponent();
        }

        private void TextBox_Player(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            String key = textBox.Name;
            _textBoxMap[key].Invoke(textBox.Text);
        
           
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            _menuView = new MenuView();
            this.Hide();
            _menuView.Show();
        }
        private void Button_Start(object sender, RoutedEventArgs e)
        {           
            Button button = sender as Button;

            _ticTacToe = new TicTacToeView(_player1, _player2);
            _ticTacToe.Show();
            this.Close();
        }




       
    }
}
