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

namespace CNPM_29
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public double OriginalWidth { get; set; }
        public double OriginalHeight { get; set; }
        public LoginWindow()
        {
            InitializeComponent();
            txtUsername.Text = "Username";
            txtPassword.Password = "Password";
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OriginalWidth = this.Width;
            OriginalHeight = this.Height;
        }

        /*private void Window_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                MyScaleTransform.ScaleX = this.ActualWidth / OriginalWidth;
                MyScaleTransform.ScaleY = this.ActualHeight / OriginalHeight;
            }
            else
            {
                MyScaleTransform.ScaleX = 1;
                MyScaleTransform.ScaleY = 1;
            }
        }*/
        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                MyScaleTransform.ScaleX = 1.5; // Giá trị 1.5 là một ví dụ, bạn có thể tùy chỉnh
                MyScaleTransform.ScaleY = 1.5;
            }
            else
            {
                MyScaleTransform.ScaleX = 1;
                MyScaleTransform.ScaleY = 1;
            }
        }



        private void txtUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password == "Password")
            {
                txtPassword.Password = "";
            }
        }

        private void txtPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Password))
            {
                txtPassword.Password = "Password";
            }
        }
        private void OnLoginClick(object sender, RoutedEventArgs e)
        {
            // Here you can add your login logic. If login is successful, proceed to the next step.

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Close the login window.
        }
    }
}

