using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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
            _textBoxMap[textBox.Name].Invoke(textBox.Text);        
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            _menuView = new MenuView();
            this.Hide();
            _menuView.Show();
        }
        private void Button_Start(object sender, RoutedEventArgs e)
        {           
            _ticTacToe = new TicTacToeView(_player1, _player2);
            this.Hide();
            _ticTacToe.Show();
          
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown(); 
        }
    }
}
