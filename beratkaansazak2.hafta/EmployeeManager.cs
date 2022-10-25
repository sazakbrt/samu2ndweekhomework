using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beratkaansazak2.hafta
{
    internal class EmployeeManager
    {
        List<Employee> employees;

        public EmployeeManager()
        {
            employees = new List<Employee>();
        }

        public void Create(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine("employee eklendi");
        }

        public void Delete(int id)
        {
            var deleteEmp = employees.FirstOrDefault(x => x.id == id);

            if (deleteEmp == null)
            {
                Console.WriteLine("employee bulunamadi");

            }




            else
            {
                employees.Remove(deleteEmp);
                Console.WriteLine(id + " employee silindi");
            }




        }

        public void ReadList()
        {
            foreach (var employees in employees)
            {
                Console.WriteLine("id: " + employees.id);
            }
        }
    }
}
