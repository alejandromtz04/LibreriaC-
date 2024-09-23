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
                                // Get specific data from the table
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName")),
                                EmployeeLastName = reader.GetString(reader.GetOrdinal("EmployeeLastName")),
                                EmployeeAge = reader.GetInt32(reader.GetOrdinal("Employee")),
                            };
                            employeesList.Add(employee);
                        }
                    }
                }
            }
            return employeesList;
        }

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

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

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
