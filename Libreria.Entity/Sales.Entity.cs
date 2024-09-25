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
        public string BranchAddress { get; set; }
        public string SaleDescription { get; set; }
        public string Quantity { get; set; }
        public int Total {  get; set; }
        public bool State {  get; set; }
        public DateTime DateAndTime { get; set; }

        // relations

        public Client Client { get; set; }
        public Employee Employee { get; set; }
        public Product Product { get; set; }
    }
}
