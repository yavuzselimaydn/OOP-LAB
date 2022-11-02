using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_homework
{
    internal class EmpManager
    {
        private List<Employee> _list;

        public EmpManager()
        {
            _list = new List<Employee>();
        }

        public void Add(Employee employee)
        {
            _list.Add(employee);
        }

        public void Remove(int id)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (_list[0].Id == id)
                {
                    _list.Remove(_list[i]);
                }

                else
                {
                    Console.WriteLine("Girilen Id değeri bulunamadı.");
                }
            }
        }

        public List<Employee> GetList()
        {
            return _list;
        }
    }
}
