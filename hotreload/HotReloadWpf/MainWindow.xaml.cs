using System.Windows;

namespace HotReloadWpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickMeButton_Click(object sender, RoutedEventArgs e)
        {
            ClickMeButton.Content = "Got clicked";
        }
    }
}
