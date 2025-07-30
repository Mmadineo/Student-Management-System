using System;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace StudentManagementApp
{
    public class AddStudentForm : Form
    {
        private TextBox idBox, nameBox, marksBox;
        private Button addButton;
        private static StudentBST bst = new StudentBST();

        public AddStudentForm()
        {
            Text = "Add Student";
            Width = 300;
            Height = 250;

            Label idLabel = new Label { Text = "Student ID", Top = 20, Left = 20 };
            idBox = new TextBox { Top = 40, Left = 20, Width = 200 };

            Label nameLabel = new Label { Text = "Name", Top = 70, Left = 20 };
            nameBox = new TextBox { Top = 90, Left = 20, Width = 200 };

            Label marksLabel = new Label { Text = "Marks", Top = 120, Left = 20 };
            marksBox = new TextBox { Top = 140, Left = 20, Width = 200 };

            addButton = new Button { Text = "Add", Top = 180, Left = 20 };
            addButton.Click += AddButton_Click;

            Controls.Add(idLabel);
            Controls.Add(idBox);
            Controls.Add(nameLabel);
            Controls.Add(nameBox);
            Controls.Add(marksLabel);
            Controls.Add(marksBox);
            Controls.Add(addButton);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idBox.Text);
            string name = nameBox.Text;
            double marks = double.Parse(marksBox.Text);

            Student student = new Student(id, name, marks);
            bst.Insert(student);

            string filePath = "StudentMarks.xlsx";
            FileInfo fileInfo = new FileInfo(filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                var worksheet = package.Workbook.Worksheets.Add("Marks");
                worksheet.Cells[1, 1].Value = "StudentID";
                worksheet.Cells[1, 2].Value = "Name";
                worksheet.Cells[1, 3].Value = "Marks";
                worksheet.Cells[2, 1].Value = student.StudentID;
                worksheet.Cells[2, 2].Value = student.Name;
                worksheet.Cells[2, 3].Value = student.Marks;
                package.Save();
            }

            MessageBox.Show("Student added successfully.");
        }
    }
}