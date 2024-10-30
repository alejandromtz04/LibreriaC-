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


        public bool CreateInvoice(Invoice invoice)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("spInvoiceCreate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Asignar parámetros
                    command.Parameters.AddWithValue("@BranchAddress", invoice.BranchAddress);
                    command.Parameters.AddWithValue("@InvoiceDescription", invoice.InvoiceDescription);
                    command.Parameters.AddWithValue("@Quantity", invoice.Quantity);
                    command.Parameters.AddWithValue("@TotalAmount", invoice.TotalAmount);
                    command.Parameters.AddWithValue("@InvoiceDate", invoice.InvoiceDate);
                    command.Parameters.AddWithValue("@EmployeeId", invoice.Employee.Id);
                    command.Parameters.AddWithValue("@ClientId", (object)invoice.Client?.Id ?? DBNull.Value); // Manejo de valor nulo
                    command.Parameters.AddWithValue("@ProductId", invoice.Product.Id);
                    command.Parameters.AddWithValue("@GuestName", (object)invoice.GuestName ?? DBNull.Value); // Manejo de valor nulo

                    // Abrir conexión y ejecutar el procedimiento almacenado
                    connection.Open();
                    result = command.ExecuteNonQuery() > 0;
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


        public List<Product> GetProducts()
        {
            var products = new List<Product>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, ProductName FROM Product WHERE State = 1", connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var product = new Product
                                {
                                    Id = (int)reader["Id"], // Asegúrate de que tienes una propiedad Id en tu clase Product
                                    ProductName = reader["ProductName"].ToString()
                                };
                                products.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer la lista de Productos: " + ex.Message);
            }

            return products;
        }


        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, EmployeeName FROM Employee WHERE State = 1", connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var employee = new Employee
                                {
                                    Id = (int)reader["Id"], // Asegúrate de que tienes una propiedad Id en tu clase Employee
                                    EmployeeName = reader["EmployeeName"].ToString()
                                };
                                employees.Add(employee);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer la lista de Empleados: " + ex.Message);
            }

            return employees;
        }



        public List<Client> GetClients()
        {
            var clients = new List<Client>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, ClientName FROM Client WHERE State = 1", connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var client = new Client
                                {
                                    Id = (int)reader["Id"], // Asegúrate de que tienes una propiedad Id en tu clase Client
                                    ClientName = reader["ClientName"].ToString()
                                };
                                clients.Add(client);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer la lista de Clientes: " + ex.Message);
            }

            return clients;
        }



        public decimal GetProductPrice(int productId)
        {
            decimal productPrice = 0;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ProductPrice FROM Product WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", productId);
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
