using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Entity
{
    public class Sales
    {
        public int Id { get; set; }
        //public Client => name
        //public Employee => name
        public string BranchAddress { get; set; }
        public string SaleDescription { get; set; }
        public string quantity { get; set; }
        // public Product => name
        public int total {  get; set; }
        public bool state {  get; set; }
    }
}
