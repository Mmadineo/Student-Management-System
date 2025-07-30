using System.Windows;

namespace StudentManagementApp.UI
{
    public partial class AddStudentWindow : Window
    {
        public AddStudentWindow()
        {
            InitializeComponent();
            btnAddStudent.Click += (s, e) =>
            {
                string id = txtStudentID.Text;
                string name = txtName.Text;
                string marks = txtMarks.Text;
                MessageBox.Show($"Student Added: {id}, {name}, {marks}");
            };
        }
    }
}
