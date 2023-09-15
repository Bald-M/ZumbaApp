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
using ZumbaApp.Views;
using ZumbaApp.Tests;

namespace ZumbaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Init
            Tests.App app = new Tests.App();
        }

        private void SignUp(object sender, RoutedEventArgs e)
        {
            // Go to sign up page
            SignUp signUp = new SignUp();
            signUp.Show();
            // Close the current page
            Window window = GetWindow(this);
            this.Close();
        }

        private void AttendanceDashboard(object sender, RoutedEventArgs e)
        {
            string username = Username.Text;
            string password = Passwd.Password;

            
            // Validation
            if (Tests.App.ValidateCredentials(username,password) == true)
            {
                // Go to attendance dashboard page
                AttendanceDashboard attendanceDashboard = new AttendanceDashboard();
                attendanceDashboard.Show();
                // Close the current page
                Window window = GetWindow(this);
                window.Close();
            }
            else
            {
                MessageBox.Show("Your username or password is incorrect");
            }
            
        }
    }
}
