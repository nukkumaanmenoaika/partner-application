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

namespace PartnerApp.EditWindows
{
    /// <summary>
    /// Логика взаимодействия для AddPartner.xaml
    /// </summary>
    public partial class AddPartner : Window
    {
        List<string> typesPartner = new List<string> { "ЗАО", "ПАО", "ООО", "ОАО" };
        public AddPartner()
        {
            InitializeComponent();
            TypePartner.ItemsSource = typesPartner;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var context = PartnerDBEntities.GetContext();
            Partners par = new Partners();
            
            par.PartnerType = TypePartner.SelectedItem.ToString();
            par.PartnerName = NamePartner.Text;
            par.Email = Email.Text;
            par.INN = INN.Text;
            par.Director = Director.Text;
            par.Phone = Phone.Text;
            par.Email = Email.Text;
            par.Rating = Convert.ToInt32(Rating.Text);
            par.LegalAddress = Address.Text;
            context.Partners.Append(par);
            context.SaveChanges();

            Close();
        }
    }
}
