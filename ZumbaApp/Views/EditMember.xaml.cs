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
using ZumbaApp.Models;

namespace ZumbaApp.Views
{
    /// <summary>
    /// Interaction logic for EditMember.xaml
    /// </summary>
    public partial class EditMember : UserControl
    {
        private List<Member> members;
        public EditMember()
        {
            InitializeComponent();
            members = Tests.App.members;

            resultListView.ItemsSource = members;
        }

        private void SearchButton(object sender, RoutedEventArgs e)
        {
            string searchText = SearchClass.Text.ToLower();
            // Search condition: Member name
            // 需要实现名字模糊查询
            List<Member> searchResults = members.Where(s => s.FullName.ToString() == searchText).ToList();
            resultListView.ItemsSource = searchResults;
            resultListView.Visibility = Visibility.Visible;
        }
    }
}
