using System.Collections.Generic;

namespace StudentManagementApp
{
    public static class StudentRepository
    {
        private static List<Student> students = new List<Student>();

        public static void AddStudent(Student student)
        {
            students.Add(student);
        }

        public static List<Student> GetAllStudents()
        {
            return new List<Student>(students);
        }

        public static Student SearchById(int id)
        {
            return students.Find(s => s.StudentID == id);
        }
    }
}
