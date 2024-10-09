using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Entity;
using System.Data;

namespace Libreria.DataAccess
{
    public class ProductDAL: Connection
    {
        private static ProductDAL _instance;

        public static ProductDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new ProductDAL());
            }
        }

        public bool CreateProduct(Product product, ProductCategory productCategory)
        {
            bool result = false;

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spProductCreate", _connection))
                {
                    _connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("@ProductCode", product.ProductCode);
                    cmd.Parameters.AddWithValue("@ProductDescription", product.ProductDescription);
                    cmd.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);

                    cmd.Parameters.AddWithValue("@ProductCategoryName", productCategory.ProductCategoryName);
                    cmd.Parameters.AddWithValue("@ProductStock", productCategory.ProductStock);
                    
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }



        public List<Product> GetAllProducts()
        {
            List<Product> productsList = new List<Product>();

            using (SqlConnection _connnection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spProductsGetAll", _connnection))
                {
                    _connnection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                // Get data from Product
                                // ADD @ MAYBE

                                Id = Convert.ToInt32(reader["Id"]),
                                ProductName = reader["ProductName"].ToString(),
                                ProductCode = reader["ProductCode"].ToString(),
                                ProductDescription = reader["ProductDescription"].ToString(),
                                ProductPrice = Convert.ToDecimal(reader["ProductPrice"])
                                //State = true
                            };

                            // Get and save data from ProductCategory
                            ProductCategory productCategory = new ProductCategory
                            {
                                ProductCategoryName = reader["ProductCategoryName"].ToString(),
                                ProductStock = Convert.ToInt32(reader["ProductStock"])
                            };

                            product.ProductCategory = productCategory;
                            productsList.Add(product);
                        }
                    }
                }
            }
            return productsList;
        }

        public bool UpdateProduct(Product product, ProductCategory productCategory)
        {
            bool result = false;

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spProductUpdate", _connection))
                {
                    _connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", product.Id);
                    cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("@ProductCode", product.ProductCode);
                    cmd.Parameters.AddWithValue("@ProductDescription", product.ProductDescription);
                    cmd.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);

                    cmd.Parameters.AddWithValue("@ProductCategoryName", productCategory.ProductCategoryName);
                    cmd.Parameters.AddWithValue("@ProductStock", productCategory.ProductStock);

                    result = cmd.ExecuteNonQuery() > 0;
                    //cmd.Parameters.AddWithValue("@ProductStock")
                }
            }
            return result;
        }


        public bool DeleteProduct(int Id)
        {
            bool result = false;

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spProductDelete", _connection))
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
