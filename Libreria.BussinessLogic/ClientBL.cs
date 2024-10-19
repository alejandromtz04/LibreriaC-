using Libreria.DataAccess;
using Libreria.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.BussinessLogic
{
    public class ClientBL
    {
        private static ClientBL _instance;

        public static ClientBL Instance
        {
            get
            {
                return _instance ?? (_instance = new ClientBL());
            }
        }

        public bool CreateClient(Client client, ClientContact clientContact)
        {
            bool Result = false;
            try
            {
                Result = ClientDAL.Instance.CreateClient(client, clientContact);
            }
            catch (Exception ex) 
            {
                throw new Exception("Error al crear Cliente: " + ex.Message);
            }
            return Result;
        }
         
        public List<Client> GetAllClients()
        {
            List<Client> Result = null;
            try
            {
                Result = ClientDAL.Instance.GetAllClients();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer la lista de Cliente: " + ex.Message);
            }
            return Result;
        }

        public bool UpdateClient(Client client)
        {
            bool result = false;
            try
            {
                result = ClientDAL.Instance.UpdateClient(client);
            } 
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar cliente: " + ex.Message);
            }
            return result;
        }

        public bool DeleteClient(int Id)
        {
            bool result = false;
            try
            {
                result = ClientDAL.Instance.DeleteClient(Id);
            } 
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar cliente: " + ex.Message);
            }
            return result;
        }
    }
}
