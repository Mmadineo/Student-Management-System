
using System;
using System.Windows.Forms;

namespace StudentManagementApp.Forms
{
    public partial class SearchStudentForm : Form
    {
        private StudentBST bst;

        public SearchStudentForm(StudentBST tree)
        {
            InitializeComponent();
            bst = tree;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int studentID;
            if (int.TryParse(txtStudentID.Text, out studentID))
            {
                Student student = bst.Search(studentID);
                if (student != null)
                {
                    MessageBox.Show($"Found: ID={student.StudentID}, Name={student.Name}, Marks={student.Marks}");
                }
                else
                {
                    MessageBox.Show("Student not found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Student ID.");
            }
        }
    }
}
