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

        private static ClientDAL _instance;

        public static ClientDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new ClientDAL());
            }
        }
        public bool CreateClient(Client client, ClientContact clientContact)
        {
            bool result = false;

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spClientCreate", _connection)) 
                { 
                    _connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ClientName", client.ClientName);
                    cmd.Parameters.AddWithValue("@ClientLastName", client.ClientLastName);
                    cmd.Parameters.AddWithValue("@ClientAge", client.ClientAge);

                    cmd.Parameters.AddWithValue("@ClientEmail", clientContact.ClientEmail);
                    cmd.Parameters.AddWithValue("@ClientPhone", clientContact.ClientPhone);
                    cmd.Parameters.AddWithValue("@ClientAddress", clientContact.ClientAddress);

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public List<Client> GetAllClients()
        {
            List<Client> clientList = new List<Client>();

            using (SqlConnection _connnection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spClientGetAll", _connnection))
                {
                    _connnection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
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
                            clientList.Add(client);

                            // Get and save data from ClientContact
                            
                        }
                    }
                }
            }
            return clientList;
        }


        public bool UpdateClient(Client client, ClientContact clientContact)
        {
            bool result = false;

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spClientUpdate", _connection))
                {
                    _connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", client.Id);
                    cmd.Parameters.AddWithValue("@ClientName", client.ClientName);
                    cmd.Parameters.AddWithValue("@ClientLastName", client.ClientLastName);
                    cmd.Parameters.AddWithValue("@ClientAge", client.ClientLastName);

                    cmd.Parameters.AddWithValue("@ClientEmail", clientContact.ClientEmail);
                    cmd.Parameters.AddWithValue("@ClientPhone", clientContact.ClientPhone);
                    cmd.Parameters.AddWithValue("@ClientAddress", clientContact.ClientAddress);

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public bool DeleteClient(int Id)
        {
            bool result = false;

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spClientDelete", _connection))
                {
                    _connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", Id);

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
