using login.ViewModels;
using System.Windows;

namespace login
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }

        private void BtCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
