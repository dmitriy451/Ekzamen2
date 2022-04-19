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
    /// Логика взаимодействия для ShowOrder.xaml
    /// </summary>
    public partial class ShowOrder : Page
    {
        DataBase.SharmEntities sharm = new DataBase.SharmEntities();
        public ShowOrder(int employeeId)
        {
            InitializeComponent();
            DGrid_Orders.ItemsSource = sharm.Order.Where(p => p.EmployeeId == employeeId).ToList();
        }
    }
}
