using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Entity
{
    public class Box
    {
        public int Id { get; set; }
        public DateTime StartBox { get; set; }

        public DateTime EndBox { get; set; }
        public string TotalSales { get; set; }
        public bool State {  get; set; }

        // Relation with sales
    }
}
