using System;

namespace beratkaansazak2.hafta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "Berat ", "Sazak");
            Employee emp1 = new Employee(2, "Kaan", "Sazak");


            EmployeeManager employeeManager = new EmployeeManager();

            employeeManager.Create(emp);
            employeeManager.Create(emp1);
            employeeManager.Delete(2);
            employeeManager.Delete(59);
            employeeManager.ReadList();



        }
    }
}
