﻿using GUI.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;

namespace GUI.Views
{

    public partial class TicTacToeView : Window 
    {
        private TicTacToeViewModel _vm;
        private String _currentPlayer;


        public TicTacToeView(String player1,String player2)
        {
            InitializeComponent();
            _vm = new TicTacToeViewModel(player1,player2); 
            DataContext = _vm;
            //player.Content = _vm.GetCurrentPlayer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            
            String key = button.Tag.ToString();

            Coordinates coord = _vm.GetCoordinate(key);

            Boolean _matchWin = _vm.PlayGame(coord.X, coord.Y);
            

            button.IsEnabled = false;

            button.Content = _vm.GetSymbol();

            _currentPlayer = _vm.GetCurrentPlayer();

            //player.Content = _currentPlayer;

            if (_matchWin)
            {
                MessageBox.Show("Gano el Jugador: " + _currentPlayer + "!");
            }   

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
