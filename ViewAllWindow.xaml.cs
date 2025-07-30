using System.Collections.Generic;
using System.Windows;

namespace StudentManagementApp.UI
{
    public partial class ViewAllWindow : Window
    {
        public ViewAllWindow()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            List<Student> allStudents = StudentRepository.GetAllStudents();
            lvStudents.ItemsSource = allStudents;
        }
    }
}
