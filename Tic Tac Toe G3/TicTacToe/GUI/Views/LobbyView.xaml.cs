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
        private TicTacToeView ticTacToe;
        public LobbyView()
        {
            InitializeComponent();

            ticTacToe = new TicTacToeView();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Start(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            this.Hide();
            ticTacToe.Show();


        }
    }
}
