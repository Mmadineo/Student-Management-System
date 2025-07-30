using System.Windows;

namespace StudentManagementApp.UI
{
    public partial class SearchStudentWindow : Window
    {
        public SearchStudentWindow()
        {
            InitializeComponent();
            btnSearchStudent.Click += (s, e) =>
            {
                string id = txtSearchID.Text;
                txtResult.Text = $"Search result for ID: {id}";
            };
        }
    }
}
