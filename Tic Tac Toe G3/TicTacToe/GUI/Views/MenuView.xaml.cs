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
    public partial class MenuView : Window
    {
        private LobbyView lobby;
        public MenuView()
        {
            lobby = new LobbyView();
            InitializeComponent();

        }

        private void Button_Start_Game(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            this.Hide();
            lobby.Show();


        }

        private void Button_Exit_Game(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            
            System.Windows.Application.Current.Shutdown();
        }

    }
}
