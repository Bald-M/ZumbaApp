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
    /// Interaction logic for Attendance.xaml
    /// </summary>
    public partial class Attendances : UserControl
    {
        private List<Attendance> attendances;
        
        public Attendances()
        {
            InitializeComponent();

            Member member1 = new Member(1, "John Doe", "2000-01-01");
            
            Member member2 = new Member(2, "John Green", "2000-01-02");
            Member member3 = new Member(3, "John Smith", "2000-01-03");

            Class class1 = new Class(1, "Zumba", "123 Main St", 3, 2, "Latin");
            Class class2 = new Class(2, "Yoga", "456 Elm St", 1, 1, "Relaxing");
            Class class3 = new Class(3, "Pilates", "789 Oak St", 2, 2, "Contemporary");
            Class class4 = new Class(4, "Spinning", "321 Pine St", 4, 3, "Rock");
            Class class5 = new Class(5, "Hip Hop", "654 Birch St", 4, 4, "Hip Hop");

            attendances = new List<Attendance>();
            attendances.Add(new Attendance(1,1,2,"2023-09-15",true,member1,class2));
            attendances.Add(new Attendance(2,2,1,"2023-09-15",true,member2,class1));
            attendances.Add(new Attendance(3,3,1,"2023-09-15",false,member3,class1));

            resultListView.ItemsSource = attendances;
        }

        private void SearchButton(object sender, RoutedEventArgs e)
        {
            
            string searchText = searchClass.Text.ToLower();
            // Search condition: Class ID
            //List<Models.Attendance> searchResults = attendances.Where(s => s.Member.DOB.ToLower().Contains(searchText)).ToList();
            List<Attendance> searchResults = attendances.Where(s => s.Class.Id.ToString() == searchText).ToList();
            resultListView.ItemsSource = searchResults;
            resultListView.Visibility = Visibility.Visible;
        }
    }
}
