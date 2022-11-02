using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_lab
{
    internal class StudentManager
    {
        List<Student> stdList;

        public StudentManager()
        {
            stdList = new List<Student>();
        }
        public StudentManager(List<Student> std)
        {
            stdList = std;
        }
        public StudentManager(Student std)
        {
            stdList = new List<Student>();
            CreateStudents(std);
        }

        //Create
        public void CreateStudents(Student student)
        {
            stdList.Add(student);
        }
        //Read
        public Student ReadStudent(int id)
        {
            return stdList[id];
        }
        //Update
        public void UpdateStudent(int id, string firstName, string lastName)
        {
            if (firstName != null)
            {
                stdList[id].FirstName = firstName;
            }
            if (lastName != null)
                stdList[id].LastName = lastName;
        }
        //Delete
        public void StudentDelete(int id)
        {
            var std = ReadStudent(id);
            stdList.Remove(std);
        }
        public void ReadAll()
        {
            foreach (var std in stdList)
            {
                Console.WriteLine(std);
            }
        }

    }
}
