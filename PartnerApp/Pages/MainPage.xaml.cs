using PartnerApp.TimeStorage;
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

namespace PartnerApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void buttonPartnerClick(object sender, RoutedEventArgs e)
        {
            manager.Frame.Navigate(new PartnersList());
        }

        private void buttonPartnerStoryClick(object sender, RoutedEventArgs e)
        {
            manager.Frame.Navigate(new PartnerStory());           
        }

        private void buttonDiscountClick(object sender, RoutedEventArgs e)
        {
            manager.Frame.Navigate(new Discounts());
        }
    }
}
