using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Entity
{
    public class EmployeeContact
    {
        public int Id { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeAddress { get; set; }

        public bool State = true;
    }
}
