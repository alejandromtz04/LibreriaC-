using Libreria.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Libreria.DataAccess;


namespace Libreria.DataAccess
{
    public class UsuarioDAL: Connection
    {
        private static UsuarioDAL _instance;

        public static UsuarioDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new UsuarioDAL());
            }
        }


        public bool CreateUser(Usuario user)
        {
            bool result = false;
            string encryptPassword = Utilities.EncodePassword(user.Password);

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUserCreate", _connection))
                {
                    _connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserName", user.UserName);
                    cmd.Parameters.AddWithValue("@Password", encryptPassword);
                    

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public List<Usuario> GetAllUsers()
        {
            List<Usuario> usersList = new List<Usuario>();

            using (SqlConnection _connnection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUserGetAll", _connnection))
                {
                    _connnection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario user = new Usuario
                            {
                                // Get data from Client
                                // ADD @ MAYBE

                                Id = Convert.ToInt32(reader["Id"]),
                                UserName = reader["UserName"].ToString(),
                            };
                            usersList.Add(user);
                        }
                    }
                }
            }
            return usersList;
        }

        public bool UpdatePassword(Usuario user)
        {
            bool result = false;

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spChangePassword", _connection))
                {
                    _connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", user.Id);
                    cmd.Parameters.AddWithValue("Password", user.Password);
                 
                    result = cmd.ExecuteNonQuery() > 0;
                    //cmd.Parameters.AddWithValue("@ProductStock")
                }
            }
            return result;
        }

        public bool Login(Usuario user)
        {
            bool isAuthenticated = false;
            string encryptedPassword = Utilities.EncodePassword(user.Password);


            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUserLogin", _connection))
                {
                    _connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserName", user.UserName);
                    cmd.Parameters.AddWithValue ("@Password", encryptedPassword);

                    var result = cmd.ExecuteScalar();

                    isAuthenticated = result?.ToString() == "Login Exitoso";
                }
            }

            return isAuthenticated;
        }

        public bool DeleteUser(int Id)
        {
            bool result = false;

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUserDelete", _connection))
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
