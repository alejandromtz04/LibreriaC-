using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Entity
{
    public class Invoice
    {
        public int Id { get; set; }
        public string BranchAddress { get; set; }
        public string InvoiceDescription { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount {  get; set; }
        public DateTime InvoiceDate { get; set; }
        public string GuestName { get; set; }
        public bool State {  get; set; }
        
        // relations
        public Employee Employee { get; set; }
        public Client Client { get; set; }
        public Product Product { get; set; }
    }
}
