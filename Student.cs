using System;

namespace StudentManagementApp
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }

        public Student(int id, string name, double marks)
        {
            StudentID = id;
            Name = name;
            Marks = marks;
        }

        public override string ToString()
        {
            return $"ID: {StudentID}, Name: {Name}, Marks: {Marks}";
        }
    }
}