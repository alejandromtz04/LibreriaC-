using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Entity;

namespace Libreria.DataAccess
{
    public class EmployeeDal : Connection
    {

        // I need to know the concept
        private static EmployeeDal _instance;
        public static EmployeeDal Instance
        {
            get
            {
                return _instance ?? (_instance = new EmployeeDal());
            }
        }


        public bool CreateEmployee(Employee employee, EmployeeContact employeeContact)
        {
            bool result = false;

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spEmployeeCreate", _connection))
                {
                    _connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    // This is for Employee

                    cmd.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                    cmd.Parameters.AddWithValue("@EmployeeLastName", employee.EmployeeLastName);
                    cmd.Parameters.AddWithValue("@EmployeeAge", employee.EmployeeAge);
                    cmd.Parameters.AddWithValue("@State", employee.State);

                    // This is for the EmployeeContact after fix the procedure on the dataa base, the same procedure is been used to execute booth tables/options.

                    cmd.Parameters.AddWithValue("@EmployeeEmail", employeeContact.EmployeeEmail);
                    cmd.Parameters.AddWithValue("@EmployeePhone", employeeContact.EmployeePhone);
                    cmd.Parameters.AddWithValue("@EmployeeAddress", employeeContact.EmployeeAddress);
                    
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employeesList = new List<Employee>();

            using (SqlConnection _connnection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spEmployeeGetAll", _connnection))
                {
                    _connnection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader()) 
                    {
                        while (reader.Read()) 
                        {
                            Employee employee = new Employee
                            {
                                // Get data from Employee

                                Id = Convert.ToInt32(reader["Id"]),
                                EmployeeName = reader["EmployeeName"].ToString(),
                                EmployeeLastName = reader["EmployeeLasName"].ToString(),
                                EmployeeAge = Convert.ToInt32(reader["EmployeeAge"]),
                                State = true
                            };

                            // Get and save data from EmployeeContact
                            EmployeeContact employeeContact = new EmployeeContact
                            {
                                EmployeeEmail = reader["EmployeeEmail"].ToString(),
                                EmployeePhone = reader["EmployeePhone"].ToString(),
                                EmployeeAddress = reader["EmployeeAddress"].ToString()
                            };

                            employee.EmployeeContact = employeeContact;
                            employeesList.Add(employee);
                        }
                    }
                }
            }
            return employeesList;
        }


        // Must be fix this
        public bool UpdateEmployee(int Id)
        {
            bool result = false;

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spEmployeeUpdate", _connection))
                {
                    _connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeName", Id);
                    cmd.Parameters.AddWithValue("@EmployeeLastName", Id);
                    cmd.Parameters.AddWithValue("@EmployeeAge", Id);

                    cmd.Parameters.AddWithValue("EmployeeEmail", Id);
                    cmd.Parameters.AddWithValue("EmployeePhone", Id);
                    cmd.Parameters.AddWithValue("EmployeeAddress", Id);

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        // Must be fix this
        public bool DeleteEmployee(int Id)
        {
            bool result = false;

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spEmployeeDelete", _connection))
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
