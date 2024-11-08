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
using PartnerApp.Pages;
using PartnerApp.TimeStorage;


namespace PartnerApp.EditWindows
{
    /// <summary>
    /// Логика взаимодействия для EditingPartner.xaml
    /// </summary>
    public partial class EditingPartner : Window
    {
        Partners storage = EditPartnerStorage.Partners;
        public EditingPartner()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            List<string> typesPartner = new List<string> { "ЗАО", "ПАО", "ООО", "ОАО" };
            TypePartner.ItemsSource = typesPartner;
            TypePartner.SelectedIndex = typesPartner.IndexOf(storage.PartnerType);
            NamePartner.Text = storage.PartnerName;
            Director.Text = storage.Director;
            Phone.Text = storage.Phone;
            Rating.Text = storage.Rating.ToString();
            Email.Text = storage.Email;
            Address.Text = storage.LegalAddress;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var context = PartnerDBEntities.GetContext();
            var obj = context.Partners.FirstOrDefault(x => x.id == storage.id);
            obj.PartnerType = TypePartner.SelectedItem.ToString();
            obj.PartnerName = NamePartner.Text;
            obj.Email = Email.Text;
            obj.Director = Director.Text;
            obj.Phone = Phone.Text;
            obj.Email = Email.Text;
            obj.INN = INN.Text;
            obj.Rating = Convert.ToInt32(Rating.Text);
            obj.LegalAddress = Address.Text;
            context.SaveChanges();
            
            Close();
        }
    }
}
