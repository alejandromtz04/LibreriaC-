using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Entity
{
    //entidad de cliente
    public class Client
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ClientLastName { get; set; }
        public int ClientAge { get; set; }

        public bool State { get; set; } = true;

        //relacion entre contacto de cliente
        public ClientContact ClientContact { get; set; }
    }
}
