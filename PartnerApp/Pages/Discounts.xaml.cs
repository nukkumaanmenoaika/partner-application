using PartnerApp.TimeStorage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;
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
    /// Логика взаимодействия для Discounts.xaml
    /// </summary>
    public partial class Discounts : Page

    {
        PartnerDBEntities context = PartnerDBEntities.GetContext();

        public Discounts()
        {
            InitializeComponent();
            ProcessingData();
        }


        private void ProcessingData()
        {
            var obj = context.Sales.ToList();
            string timeDiscount = "";
            List<PartnerDiscount> res = new List<PartnerDiscount>();
            foreach ( var item in obj )
            {

                if (item.ProductQuantity <= 10000)
                {
                    timeDiscount = "0%";
                }
                if (item.ProductQuantity > 10000 && item.ProductQuantity <= 50000)
                {
                    timeDiscount = "5%";
                }
                if (item.ProductQuantity > 50000 && item.ProductQuantity <= 300000)
                {
                    timeDiscount = "10%";

                }if (item.ProductQuantity > 300000)
                {
                    timeDiscount = "15%";
                }

                
                var par = context.Partners.FirstOrDefault(x => x.PartnerName == item.PartnerName);
                if (par == null) { MessageBox.Show("1"); }
                PartnerDiscount timeRes = new PartnerDiscount();
                timeRes.PartnerType = par.PartnerType;
                timeRes.PartnerName = par.PartnerName;
                timeRes.Director = par.Director;
                timeRes.Phone = par.Phone;
                timeRes.Rating = par.Rating.ToString();
                timeRes.Discount = timeDiscount;
                res.Add(timeRes);
            }
            MessageBox.Show(res.LongCount().ToString());
            MainGrid.ItemsSource = res;

        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            manager.Frame.Navigate(new MainPage());
        }
    }
}
