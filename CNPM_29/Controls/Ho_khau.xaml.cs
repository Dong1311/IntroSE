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
    /// Interaction logic for Ho_khau.xaml
    /// </summary>
    public partial class Ho_khau : UserControl
    {
        public Ho_khau()
        {
            InitializeComponent();
        }

        private void Them_ho_khau_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow mainWindow)
            {
                mainWindow.Iborder_Menu.Content = new Them_ho_khau();
            }
        }

        private void Sua_ho_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow mainWindow)
            {
                mainWindow.Iborder_Menu.Content = new Sua_ho_khau();
            }
        }
    }
}
