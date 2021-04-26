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

namespace WPF_Exercise_5
{
    /// <summary>
    /// Interaction logic for UserControlCustomize.xaml
    /// </summary>
    public partial class UserControlCustomize : UserControl
    {
        public UserControlCustomize()
        {
            List<Order> orders = new List<Order>();
            InitializeComponent();

            orders.Add(new Order() { Id = 1, FirstName = "John", LastName = "Smith", Age = 19, Email = "john19@gmail.com", IsMember = true, OrderValue = 212.29, OrderStatus = MyEnum.Received });
            orders.Add(new Order() { Id = 2, FirstName = "Duncan", LastName = "Broun", Age = 24, Email = "d_broun9@gmail.com", IsMember = true, OrderValue = 10.01, OrderStatus = MyEnum.Processing });
            orders.Add(new Order() { Id = 3, FirstName = "Kate", LastName = "Pittleton", Age = 31, Email = "kate@gmail.com", IsMember = false, OrderValue = 121.99, OrderStatus = MyEnum.New });
            orders.Add(new Order() { Id = 4, FirstName = "Cris", LastName = "Adams", Age = 30, Email = "cadams1@mail.com", IsMember = true, OrderValue = 999.99, OrderStatus = MyEnum.Shipped });
            orders.Add(new Order() { Id = 5, FirstName = "Simon", LastName = "Bale", Age = 28, Email = "szymon@mail.com", IsMember = true, OrderValue = 149.99, OrderStatus = MyEnum.None });
            orders.Add(new Order() { Id = 6, FirstName = "Arnold", LastName = "Colins", Age = 28, Email = "acolins@gmail.com", IsMember = false, OrderValue = 190.01, OrderStatus = MyEnum.Shipped });

            dgOrders.ItemsSource = orders;
        }
    }
}
