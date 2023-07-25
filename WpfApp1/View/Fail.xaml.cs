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
using WpfApp1.ViewModel;
using WpfApp1.View;
namespace WpfApp1.View
{
    /// <summary>
    /// Interaction logic for Fail.xaml
    /// </summary>
    public partial class Fail : Page
    {
        public ICommand _back { get; set; }
        public Fail()
        {
            InitializeComponent();
            DataContext = this;
            _back = new RelayCommand(exe_back,can_exe_back);
        }
        public void exe_back(object? parameter) 
        {
            LogIn logIn = new LogIn();
            logIn.LogInFrame.Navigate(new LogIn());
        }
    
        public bool can_exe_back(object? parameter) 
        {
            return true;
        }
    }
}
