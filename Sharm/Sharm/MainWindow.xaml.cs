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

namespace Sharm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = employee;
        }
        DataBase.Employee employee = new DataBase.Employee();
        DataBase.SharmEntities sharm = new DataBase.SharmEntities();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sharm.Employee.FirstOrDefault(p => p.Login == employee.Login &&  p.Password == employee.Password) != null)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else if (sharm.Employee.FirstOrDefault(p => p.Login == employee.Login || p.Password == employee.Password) != null)
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }
    }
}
