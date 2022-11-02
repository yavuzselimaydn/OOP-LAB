using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_lab
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email => FirstName.ToLower() + "." + LastName.ToLower() + "@samsun.edu.tr";
        public string FullName => $"{FirstName} {LastName}";

        public Student()
        {

        }
        public Student(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string? ToString()
        {
            return $"{Id,-5} {FullName,-25} {Email,-15}";
        }
    }
}
