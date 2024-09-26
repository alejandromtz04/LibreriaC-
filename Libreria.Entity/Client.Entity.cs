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

        public bool State = true;

        public ClientContact ClientContact { get; set; }
    }
}
