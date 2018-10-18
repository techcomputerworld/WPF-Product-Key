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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1

{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// realmente me parece mucho follon implementar el MVVM para todo y la gestion de ventanas dicho por muchas personas,
    /// Es muy dificil. 
    /// It really seems to me very much to continue implementing the MVVM for everything and the management of windows,
    /// It is very difficult
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        
        private void MenuItem_Click_About(object sender, RoutedEventArgs e)
        {
            About aboutWindow = new About();
            aboutWindow.ShowDialog();
        }
    }
}
