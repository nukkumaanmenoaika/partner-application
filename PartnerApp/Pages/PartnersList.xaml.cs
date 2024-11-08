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
using MahApps.Metro.Actions;
using PartnerApp.EditWindows;
using PartnerApp.TimeStorage;

namespace PartnerApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PartnersList.xaml
    /// </summary>
    public partial class PartnersList : Page
    {



        public PartnersList()
        {
            InitializeComponent();
            MainGrid.ItemsSource = PartnerDBEntities.GetContext().Partners.ToList();

        }

       

        private void Button_Edit_Click(object sender, RoutedEventArgs e)
        {
            Partners select = MainGrid.SelectedItem as Partners;
            if (select != null)
            {
                EditPartnerStorage.Partners = select;
                EditingPartner editingPartner = new EditingPartner();
                editingPartner.Show();
                
            }
            else
            {
                MessageBox.Show("Объект не выбран!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            

        }
        
        public  void UpdateData()
        {
            MainGrid.ItemsSource = PartnerDBEntities.GetContext().Partners.ToList();
        }

        
       
        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            manager.Frame.Navigate(new MainPage());
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {

            AddPartner editingPartner = new AddPartner();
            editingPartner.Show();
        }
    }
}
