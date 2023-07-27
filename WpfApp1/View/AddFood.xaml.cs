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
using Newtonsoft.Json;

namespace WpfApp1.View
{
    /// <summary>
    /// Interaction logic for AddFood.xaml
    /// </summary>
    public partial class AddFood : Window
    {
        ObservableCollection<Food> foods { get; set; }
        public AddFood()
        {
            InitializeComponent();
            DataContext = this;
            string foods_json = File.ReadAllText("C:\\Users\\Elgun\\Source\\Repos\\McDonalds\\WpfApp1\\JSON Files\\Foods.json");
            foods = JsonConvert.DeserializeObject<ObservableCollection<Food>>(foods_json);
            food_list.ItemsSource = foods;
        }
    }
}
