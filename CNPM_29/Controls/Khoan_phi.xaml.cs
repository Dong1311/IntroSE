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
    /// Interaction logic for Khoan_phi.xaml
    /// </summary>
    public partial class Khoan_phi : UserControl
    {
        public Khoan_phi()
        {
            InitializeComponent();
        }

        private void Them_khoan_thu_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow mainWindow)
            {
                mainWindow.Iborder_Menu.Content = new Them_khoan_thu();
            }
        }

        private void Sua_khoan_thu_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow mainWindow)
            {
                mainWindow.Iborder_Menu.Content = new Cap_nhat_khoan_thu();
            }
        }
    }
}
