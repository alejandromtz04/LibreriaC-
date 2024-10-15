using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeLastName { get; set; }
        public int EmployeeAge { get; set; } 
        
        public bool State = true;

        public EmployeeContact EmployeeContact { get; set; }
    }
}
