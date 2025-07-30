using System;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public class MainMenuForm : Form
    {
        private Button addButton;
        private Button searchButton;
        private Button viewButton;

        public MainMenuForm()
        {
            Text = "Main Menu";
            Width = 300;
            Height = 200;

            addButton = new Button { Text = "Add Student", Top = 20, Left = 20 };
            searchButton = new Button { Text = "Search Student", Top = 60, Left = 20 };
            viewButton = new Button { Text = "View All Records", Top = 100, Left = 20 };

            addButton.Click += (s, e) => new AddStudentForm().Show();
            searchButton.Click += (s, e) => new SearchStudentForm().Show();
            viewButton.Click += (s, e) => new ViewAllForm().Show();

            Controls.Add(addButton);
            Controls.Add(searchButton);
            Controls.Add(viewButton);
        }
    }
}