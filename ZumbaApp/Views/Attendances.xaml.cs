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

            attendances = new List<Attendance>();
            List<Attendance> attendanceClass = Tests.App.attendances;

            for (int i = 0; i < attendanceClass.Count; i++)
            {
                attendances.Add(new Attendance(i, attendanceClass[i].MemberID, attendanceClass[i].ClassID, attendanceClass[i].Date, attendanceClass[i].Attended, Tests.App.members[attendanceClass[i].MemberID - 1], Tests.App.classes[attendanceClass[i].ClassID - 1]));
                //Console.WriteLine($"{attendanceClass[i].MemberID} {attendanceClass[i].ClassID}");
            }
            resultListView.ItemsSource = attendances;
        }

        private void SearchButton(object sender, RoutedEventArgs e)
        {
            
            string searchText = searchClass.Text.ToLower();
            // Search: Class ID
            List<Attendance> searchResults = attendances.Where(s => s.Class.Id.ToString() == searchText).ToList();
            resultListView.ItemsSource = searchResults;
            resultListView.Visibility = Visibility.Visible;
        }
    }
}
