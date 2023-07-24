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
using WpfApp1.ViewModel;

namespace WpfApp1.View
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public ICommand? _login { get; set; }
        public LogIn()
        {
            InitializeComponent();
            DataContext = this;
            _login = new RelayCommand(exe_log,can_exe_log);
        }

        public void exe_log(object? parameter) 
        {
            
        }
        public bool can_exe_log(object? parameter) 
        {
            if (Username.Text != "" && Password.Password != "") { return true; }
            return false;
        }
    }
}
