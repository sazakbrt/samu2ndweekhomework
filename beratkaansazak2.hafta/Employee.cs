using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beratkaansazak2.hafta
{
    internal class Employee
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Employee(int Id, string FirstName, string LastName)
        {
            this.id = Id;
            this.firstName = FirstName;
            this.lastName = LastName;
        }


    }
}
