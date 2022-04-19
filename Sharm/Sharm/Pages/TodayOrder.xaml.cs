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

namespace Sharm.Pages
{
    /// <summary>
    /// Логика взаимодействия для TodayOrder.xaml
    /// </summary>
    public partial class TodayOrder : Page
    {
        DataBase.SharmEntities sharm = new DataBase.SharmEntities();
        public TodayOrder()
        {
            InitializeComponent();
            DGrid_Orders.ItemsSource = sharm.Employee.Where(p => p.Order.Count > 0).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DGrid_Orders.SelectedItem !=null)
            {
            Terminal.frame.Navigate(new Pages.ShowOrder((DGrid_Orders.SelectedItem as DataBase.Employee).Id));
            }
        }
    }
}
