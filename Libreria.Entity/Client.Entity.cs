using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Entity
{
    public class Client
    {
        public int Id { get; set; }
        public string ClientName { get; set; }

        public string ClientLastName { get; set; }
        public int ClientAge { get; set; }
        public bool state = true;

        // Add relation with ClientContact
    }
}
