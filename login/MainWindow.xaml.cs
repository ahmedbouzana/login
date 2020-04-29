using login.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginViewModel viewModels;
        public MainWindow()
        {
            InitializeComponent();
            viewModels = new LoginViewModel();
            DataContext = viewModels;
        }

        private void BtCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
