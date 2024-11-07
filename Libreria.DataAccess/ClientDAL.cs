using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Entity;

using Libreria.DataAccess;

namespace Libreria.DataAccess
{
    public class ClientDAL: Connection
    {
        // crea la instancia de cliente
        private static ClientDAL _instance;

        public static ClientDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new ClientDAL());
            }
        }

        // metodo de creear cliente
        public bool CreateClient(Client client, ClientContact clientContact)
        {
            bool result = false;

            // usamos la conexion sql y le pasamos como parametro _connectionstring

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                // usamos la consola de comandos de sql y ejecutamos el procedimiento almacenado
                using (SqlCommand cmd = new SqlCommand("spClientCreate", _connection)) 
                { 
                    // abrimos la conexion
                    _connection.Open();
                    // le decimos que tipo de comando sera, en este caso es de tipo procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;

                    // pasamos los datos
                    cmd.Parameters.AddWithValue("@ClientName", client.ClientName);
                    cmd.Parameters.AddWithValue("@ClientLastName", client.ClientLastName);
                    cmd.Parameters.AddWithValue("@ClientAge", client.ClientAge);
                    cmd.Parameters.AddWithValue("@State", client.State);

                    cmd.Parameters.AddWithValue("@ClientEmail", clientContact.ClientEmail);
                    cmd.Parameters.AddWithValue("@ClientPhone", clientContact.ClientPhone);
                    cmd.Parameters.AddWithValue("@ClientAddress", clientContact.ClientAddress);
                    //cmd.Parameters.AddWithValue("@State", clientContact.State);

                    // result se establecera verdadero si al ejecutar la query es diferente de 0
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        // metodo obtener todos los clientes
        public List<Client> GetAllClients()
        {
           // creamos una lista de tipo cliente
            List<Client> clientList = new List<Client>();

            using (SqlConnection _connnection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spClientGetAll", _connnection))
                {
                    _connnection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        // mientras este habilitado el reader se crearan 2 objetos nuevos
                        // cliente y contacto de cliente
                        while (reader.Read())
                        {
                            Client client = new Client
                            {
                                // Get data from Client
                                // ADD @ MAYBE

                                Id = Convert.ToInt32(reader["Id"]),
                                ClientName = reader["ClientName"].ToString(),
                                ClientLastName = reader["ClientLastName"].ToString(),
                                ClientAge = Convert.ToInt32(reader["ClientAge"]),
                            };

                            ClientContact clientContact = new ClientContact
                            {
                                ClientEmail = reader["ClientEmail"].ToString(),
                                ClientPhone = reader["ClientPhone"].ToString(),
                                ClientAddress = reader["ClientAddress"].ToString(),
                            };

                            client.ClientContact = clientContact;

                            // a;adimos cliente a la lista
                            clientList.Add(client);

                            // Get and save data from ClientContact
                            
                        }
                    }
                }
            }
            //retorna la lista de clientes
            return clientList;
        }

        // actualizar cliente
        public bool UpdateClient(Client client)
        {

            // establecemos un resultado falso
            bool result = false;

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spClientUpdate", _connection))
                {

                    // abrimos la conexion
                    _connection.Open();

                    // tipo de consulta
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", client.Id);
                    cmd.Parameters.AddWithValue("@ClientName", client.ClientName);
                    cmd.Parameters.AddWithValue("@ClientLastName", client.ClientLastName);
                    cmd.Parameters.AddWithValue("@ClientAge", client.ClientAge);

                    cmd.Parameters.AddWithValue("@ClientEmail", client.ClientContact.ClientEmail);
                    cmd.Parameters.AddWithValue("@ClientPhone", client.ClientContact.ClientPhone);
                    cmd.Parameters.AddWithValue("@ClientAddress", client.ClientContact.ClientAddress);

                    // devolvemos el resultado
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            // retornamos el resultado
            return result;
        }


        // borrar cliente
        public bool DeleteClient(int Id)
        {
            bool result = false;

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spClientDelete", _connection))
                {
                    // abrimos la conexion
                    _connection.Open();

                    // tipo de procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    //pasamos el id
                    cmd.Parameters.AddWithValue("@Id", Id);

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
