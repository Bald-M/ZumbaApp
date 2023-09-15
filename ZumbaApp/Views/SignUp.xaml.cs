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

namespace ZumbaApp.Views
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void CreateAccount(object sender, RoutedEventArgs e)
        {
            // Validation

            // Write in database

            // Pop up
            MessageBox.Show("Your account is created successfully!");

            // Redirect to sign in page
            MainWindow signIn = new MainWindow();
            signIn.Show();
            // Close the current page
            Window currentWindow = GetWindow(this);
            this.Close();
        }
    }
}
