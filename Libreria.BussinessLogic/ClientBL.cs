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

        // establecemos la instancia
        private static ClientBL _instance;

        public static ClientBL Instance
        {
            get
            {
                return _instance ?? (_instance = new ClientBL());
            }
        }

        // creamos el metodo bl para ejecutar el metodo create de la dal y le pasamos 2 parametros, client y clientContact

        public bool CreateClient(Client client, ClientContact clientContact)
        {
            // probamos el codigo con try y catch
            bool Result = false;
            try
            {
                // definimos que el resultado sera igual a la instancia de cliente
                Result = ClientDAL.Instance.CreateClient(client, clientContact);
            }
            catch (Exception ex) 
            // devolvemos el error si ocurre
            {
                throw new Exception("Error al crear Cliente: " + ex.Message);
            }
            return Result;
        }
         
        // metodo de tipo lista de clientes
        public List<Client> GetAllClients()
        {
            //creamos la lista de clientes
            List<Client> Result = null;
            try
            {
                Result = ClientDAL.Instance.GetAllClients();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer la lista de Cliente: " + ex.Message);
            }
            //retornamos el resultado [la lista]
            return Result;
        }

        //metodo actualizar cliente
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


        //elimiar cliente
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
