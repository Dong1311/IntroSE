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
    /// Interaction logic for Dong_phi.xaml
    /// </summary>
    public partial class Dong_phi : UserControl
    {
        public Dong_phi()
        {
            InitializeComponent();
        }

        private void Them_nop_tien_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow mainWindow)
            {
                mainWindow.Iborder_Menu.Content = new Nop_tien();
            }
        }
    }
}
