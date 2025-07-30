using System;
using System.Collections.Generic;

namespace StudentManagementApp
{
    public class StudentBST
    {
        public Student Root { get; private set; }

        public void Insert(Student student)
        {
            Root = InsertRec(Root, student);
        }

        private Student InsertRec(Student root, Student student)
        {
            if (root == null)
                return student;

            if (student.StudentID < root.StudentID)
                root.Left = InsertRec(root.Left, student);
            else if (student.StudentID > root.StudentID)
                root.Right = InsertRec(root.Right, student);

            return root;
        }

        public Student Search(int studentID)
        {
            return SearchRec(Root, studentID);
        }

        private Student SearchRec(Student root, int studentID)
        {
            if (root == null || root.StudentID == studentID)
                return root;

            if (studentID < root.StudentID)
                return SearchRec(root.Left, studentID);
            else
                return SearchRec(root.Right, studentID);
        }

        public List<Student> InOrder()
        {
            List<Student> result = new List<Student>();
            InOrderRec(Root, result);
            return result;
        }

        private void InOrderRec(Student root, List<Student> result)
        {
            if (root != null)
            {
                InOrderRec(root.Left, result);
                result.Add(root);
                InOrderRec(root.Right, result);
            }
        }
    }
}