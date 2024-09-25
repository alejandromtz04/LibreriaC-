using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Libreria.Entity;

namespace Libreria.DataAccess
{
    public class SalesDAL: Connection
    {
        private static ProductDAL _instance = new ProductDAL();

        public static ProductDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new ProductDAL());
            }
        }


        public bool CreateSale(Sales sales, Employee employee, Client client, Product product)
        {
            bool result = false;

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spCreateSale", _connection))
                {
                    _connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@BranchAddress", sales.BranchAddress);
                    cmd.Parameters.AddWithValue("@SaleDescription", sales.SaleDescription);
                    cmd.Parameters.AddWithValue("@Quantity", sales.Quantity);
                    cmd.Parameters.AddWithValue("@Total", sales.Total);
                    cmd.Parameters.AddWithValue("@DateAndTime", sales.DateAndTime);

                    // Employee

                    cmd.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                    cmd.Parameters.AddWithValue("@EmployeeLastName", employee.EmployeeLastName);

                    // Client

                    cmd.Parameters.AddWithValue("@ClientName", client.ClientName);
                    cmd.Parameters.AddWithValue("@ClientLastName", client.ClientLastName);

                    // Product

                    cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }
    }
}
