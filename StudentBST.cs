using System;
using System.Collections.Generic;

namespace StudentManagementApp
{
    public class StudentNode
    {
        public Student Data { get; set; }
        public StudentNode Left { get; set; }
        public StudentNode Right { get; set; }

        public StudentNode(Student student)
        {
            Data = student;
        }
    }

    public class StudentBST
    {
        private StudentNode root;

        public void Insert(Student student)
        {
            root = InsertRec(root, student);
        }

        private StudentNode InsertRec(StudentNode node, Student student)
        {
            if (node == null)
                return new StudentNode(student);

            if (student.StudentID < node.Data.StudentID)
                node.Left = InsertRec(node.Left, student);
            else if (student.StudentID > node.Data.StudentID)
                node.Right = InsertRec(node.Right, student);

            return node;
        }

        public Student Search(int studentID)
        {
            return SearchRec(root, studentID);
        }

        private Student SearchRec(StudentNode node, int studentID)
        {
            if (node == null)
                return null;

            if (studentID == node.Data.StudentID)
                return node.Data;
            else if (studentID < node.Data.StudentID)
                return SearchRec(node.Left, studentID);
            else
                return SearchRec(node.Right, studentID);
        }

        public List<Student> InOrder()
        {
            List<Student> students = new List<Student>();
            InOrderRec(root, students);
            return students;
        }

        private void InOrderRec(StudentNode node, List<Student> list)
        {
            if (node != null)
            {
                InOrderRec(node.Left, list);
                list.Add(node.Data);
                InOrderRec(node.Right, list);
            }
        }
    }
}