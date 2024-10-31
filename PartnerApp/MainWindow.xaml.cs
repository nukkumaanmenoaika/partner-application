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
using PartnerApp.Pages;

namespace PartnerApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void changeMainObject()
        {
            Menu.Visibility = Visibility.Hidden;
            pageFrame.Visibility = Visibility.Visible;
        }

        private void buttonPartnerClick(object sender, RoutedEventArgs e)
        {
            pageFrame.Navigate(new Partners());
            changeMainObject();
        }

        private void buttonPartnerStoryClick(object sender, RoutedEventArgs e)
        {
            pageFrame.Navigate(new PartnerStory());
            changeMainObject();
        }
    }
}
