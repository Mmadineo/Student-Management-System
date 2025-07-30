using System.Windows;

namespace StudentManagementApp.UI
{
    public partial class ViewAllWindow : Window
    {
        public ViewAllWindow()
        {
            InitializeComponent();
            lvStudents.Items.Add("Student 1: ID=101, Name=Alice, Marks=90");
            lvStudents.Items.Add("Student 2: ID=102, Name=Bob, Marks=85");
        }
    }
}
