using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp1.Model;
using System.IO;
namespace WpfApp1.View
{
    /// <summary>
    /// Interaction logic for OrderFood.xaml
    /// </summary>
    public partial class OrderFood : Window
    {
        ObservableCollection<Food> Menu;
        ObservableCollection<Order> Order_List = new ObservableCollection<Order>();
        public OrderFood()
        {
            InitializeComponent();
            DataContext = this;
            string foods_json = File.ReadAllText("C:\\Users\\Elgun\\Source\\Repos\\McDonalds\\WpfApp1\\JSON Files\\Foods.json");
            Menu = JsonConvert.DeserializeObject<ObservableCollection<Food>>(foods_json);
            menu.ItemsSource = Menu;
            order_schedule.ItemsSource = Order_List;
        }

        private void menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (menu.SelectedItem != null)
            {
                Food selectedItem = menu.SelectedItem as Food;
                Order_List.Add(new Order(selectedItem.FoodName, selectedItem.FoodCost));
            }
        }
    }
}
