using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Entity
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string ProductCategoryName { get; set; }
        public string ProductStock { get; set; }

        public bool State = true;
    }
}