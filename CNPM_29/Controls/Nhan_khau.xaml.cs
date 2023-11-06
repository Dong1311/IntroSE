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

namespace CNPM_29.Controls
{
    /// <summary>
    /// Interaction logic for Nhan_khau.xaml
    /// </summary>
    public partial class Nhan_khau : UserControl
    {
        public Nhan_khau()
        {
            InitializeComponent();
        }

        private void Them_nhan_khau_click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow mainWindow)
            {
                mainWindow.Iborder_Menu.Content = new Them_nhan_khau();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cap_nhat_nhan_khau_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow mainWindow)
            {
                mainWindow.Iborder_Menu.Content = new Cap_nhat_nhan_khau();
            }
        }
    }
}
