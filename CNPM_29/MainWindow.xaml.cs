using CNPM_29.Controls;
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

namespace CNPM_29
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double initialWidth;
        private double initialHeight;

        public double OriginalWidth { get; set; }
        public double OriginalHeight { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Iborder_Menu.Content = new Trang_chu();
            initialWidth = this.Width;
            initialHeight = this.Height;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double scaleX = this.ActualWidth / initialWidth; // initialWidth là chiều rộng ban đầu của cửa sổ
            double scaleY = this.ActualHeight / initialHeight; // initialHeight là chiều cao ban đầu của cửa sổ

            ScaleTransform scaleTransform = new ScaleTransform(scaleX, scaleY);
            MainGrid.LayoutTransform = scaleTransform;
        }


        private void Nhan_khau_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow mainWindow)
            {
                mainWindow.Iborder_Menu.Content = new Nhan_khau();
            }
        }

        private void Ho_khau_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow mainWindow)
            {
                mainWindow.Iborder_Menu.Content = new Ho_khau();
            }
        }

        private void Khoan_phi_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow mainWindow)
            {
                mainWindow.Iborder_Menu.Content = new Khoan_phi();
            }
        }

        private void Dong_phi_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow mainWindow)
            {
                mainWindow.Iborder_Menu.Content = new Dong_phi();
            }
        }

        private void Trang_chu_Click(object sender, RoutedEventArgs e)
        {
            if (Window.GetWindow(this) is MainWindow mainWindow)
            {
                mainWindow.Iborder_Menu.Content = new Trang_chu();
            }
        }
    }
}
