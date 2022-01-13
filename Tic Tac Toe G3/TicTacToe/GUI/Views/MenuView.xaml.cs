
using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace GUI.Views
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class MenuView : Window
    {
        private LobbyView _lobby;
        public MenuView()
        {
            _lobby = new LobbyView();
            this.Background = new ImageBrush(new BitmapImage(new Uri("../../../Assets/paper.png", UriKind.Relative)));
            InitializeComponent();
        }

        private void Button_Start_Game(object sender, RoutedEventArgs e)
        {
            this.Hide();
            _lobby.Show();
        }

        private void Button_Exit_Game(object sender, RoutedEventArgs e)
        {           
            System.Windows.Application.Current.Shutdown();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
