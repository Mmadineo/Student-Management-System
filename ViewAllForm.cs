
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentManagementApp.Forms
{
    public partial class ViewAllForm : Form
    {
        private StudentBST bst;

        public ViewAllForm(StudentBST tree)
        {
            InitializeComponent();
            bst = tree;
            LoadStudents();
        }

        private void LoadStudents()
        {
            List<Student> students = bst.InOrderTraversal();
            foreach (Student student in students)
            {
                listBoxStudents.Items.Add($"ID={student.StudentID}, Name={student.Name}, Marks={student.Marks}");
            }
        }
    }
}
