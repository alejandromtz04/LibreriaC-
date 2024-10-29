using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.DataAccess
{
    public class Connection
    {
        protected string _connectionString = ConfigurationManager.ConnectionStrings["LibreriaDB"].ConnectionString;

    }
}
