using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_homework
{
    internal class Employee
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }

        public Employee(int id, string firstName, string lastName, int age)
        {
            this.Age = age;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        public override string? ToString()
        {
            return $"{Id,-5} {FirstName,-15} {LastName,-10} {Age,-5}";
        }
    }
}
