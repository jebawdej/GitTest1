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

namespace HamburgerMenuDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ICommand
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MouseMove += MainWindow_MouseMove;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.GetPosition(this);
            if ( (p.X < 50) && (Keyboard.IsKeyDown(Key.LeftCtrl) ) )
                hamburgerMenu.Visibility = Visibility.Visible;
            else
                hamburgerMenu.Visibility = Visibility.Collapsed;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            
            //if (hmi_Home.IsSelected)
            //    MainFrame.NavigationService.Navigate(new Uri("MainWindow.xaml", UriKind.RelativeOrAbsolute));
            if (hmi_Search.IsSelected)
                MainFrame.NavigationService.Navigate(new Uri("Page1.xaml", UriKind.RelativeOrAbsolute));
            if (hmi_Likes.IsSelected)
                MainFrame.NavigationService.Navigate(new Uri("Page2.xaml", UriKind.RelativeOrAbsolute));

        }
    }
}
