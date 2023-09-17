using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for AttendanceDashboard.xaml
    /// </summary>
    public partial class AttendanceDashboard : Window
    {
        public AttendanceDashboard()
        {
            InitializeComponent();
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (e.NewValue is TreeViewItem selectedItem)
            {
                string? pageTag = selectedItem.Tag as string;
                if (!string.IsNullOrEmpty(pageTag))
                {
                    Console.WriteLine("Selected Page Tag: " + pageTag);

                    
                    string pageUri = $"Zumba.Views.{pageTag}";

                    if (pageTag == "AddMember")
                    {
                        AddMember addMember = new AddMember();
                        contentFrame.Navigate(addMember);
                    }
                    else if (pageTag == "Attendances")
                    {
                        Attendances attendance = new Attendances();
                        contentFrame.Navigate(attendance);
                    }
                    else if (pageTag == "EditMember")
                    {
                        EditMember editMember = new EditMember();
                        contentFrame.Navigate(editMember);
                    }
                }
            }
        }

    }
}
