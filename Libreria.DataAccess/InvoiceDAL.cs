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
    public class InvoiceDAL: Connection
    {
        private static InvoiceDAL _instance = new InvoiceDAL();

        public static InvoiceDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new InvoiceDAL());
            }
        }


        public bool CreateInvoice(Invoice invoice, Employee employee, Client client, Product product)
        {
            bool result = false;

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spCreateInvoice", _connection))
                {
                    _connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@BranchAddress", invoice.BranchAddress);
                    cmd.Parameters.AddWithValue("@InvoiceDescription", invoice.InvoiceDescription);
                    cmd.Parameters.AddWithValue("@Quantity", invoice.Quantity);
                    cmd.Parameters.AddWithValue("@TotalAmount", invoice.TotalAmount);
                    cmd.Parameters.AddWithValue("@InvoiceDate", invoice.InvoiceDate);

                    // Employee

                    cmd.Parameters.AddWithValue("@EmployeeId", employee.Id);

                    // Client

                    cmd.Parameters.AddWithValue("@ClientId", client != null ? client.Id : (object)DBNull.Value);
                    // Product

                    cmd.Parameters.AddWithValue("@ProductId", product.Id);
                    //cmd.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);

                    cmd.Parameters.AddWithValue("@GuestName", invoice.GuestName ?? (object)DBNull.Value);

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public List<Invoice> GetAllInvoices()
        {
            List<Invoice> invoiceList = new List<Invoice>();

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spGetAllInvoices", _connection))
                {
                    _connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Invoice invoice = new Invoice
                            {
                                Id = Convert.ToInt32(reader["InvoiceId"]),
                                BranchAddress = reader["BranchAddress"].ToString(),
                                InvoiceDescription = reader["InvoiceDescription"].ToString(),
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                                InvoiceDate = Convert.ToDateTime(reader["InvoiceDate"]),
                                GuestName = reader["GuestName"].ToString()
                            };


                            invoice.Employee = new Employee
                            {
                                EmployeeName = reader["EmployeeName"].ToString(),
                                EmployeeLastName = reader["EmployeeLastName"].ToString()
                            };


                            invoice.Client = new Client
                            {
                                ClientName = reader["ClientName"].ToString(),
                                ClientLastName = reader["ClientLastName"].ToString()
                            };


                            invoice.Product = new Product
                            {
                                ProductName = reader["ProductName"].ToString(),
                                ProductCode = reader["ProductCode"].ToString(),
                                ProductPrice = Convert.ToDecimal(reader["ProductPrice"])
                            };


                            invoiceList.Add(invoice);
                        }
                    }
                }
            }
            return invoiceList;
        }


        public List<string> GetProductNames()
        {
            var productNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ProductName FROM Product WHERE State = 1", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productNames.Add(reader["ProductName"].ToString());
                        }
                    }
                }
            }
            return productNames;
        }


        public List<string> GetEmployeeNames()
        {
            var employeeNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT EmployeeName FROM Employee WHERE State = 1", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employeeNames.Add(reader["EmployeeName"].ToString());
                        }
                    }
                }
            }
            return employeeNames;
        }


        public List<string> GetClientNames()
        {
            var clientNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ClientName FROM Client WHERE State = 1", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clientNames.Add(reader["ClientName"].ToString());
                        }
                    }
                }
            }
            return clientNames;
        }


        public decimal GetProductPrice(string productName)
        {
            decimal productPrice = 0;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ProductPrice FROM Product WHERE ProductName = @ProductName", conn))
                {
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    conn.Open();
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        productPrice = Convert.ToDecimal(result);
                    }
                }
            }

            return productPrice;
        }

    }
}
