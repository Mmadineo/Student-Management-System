using System.Windows;

namespace StudentManagementApp.UI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnAdd.Click += (s, e) => new AddStudentWindow().Show();
            btnSearch.Click += (s, e) => new SearchStudentWindow().Show();
            btnViewAll.Click += (s, e) => new ViewAllWindow().Show();
        }
    }
}
