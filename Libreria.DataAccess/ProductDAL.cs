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


        // ADD GET ALL METHOD

        public bool UpdateProduct(int Id)
        {
            bool result = false;

            using (SqlConnection _connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spProductUpdate", _connection))
                {
                    _connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ProductName", Id);
                    cmd.Parameters.AddWithValue("@ProductCode", Id);
                    cmd.Parameters.AddWithValue("@ProductDescription", Id);
                    cmd.Parameters.AddWithValue("@ProductPrice", Id);

                    cmd.Parameters.AddWithValue("@ProductCategoryName", Id);
                    cmd.Parameters.AddWithValue("@ProductStock", Id);

                    result = cmd.ExecuteNonQuery() > 0;
                    //cmd.Parameters.AddWithValue("@ProductStock")
                }
            }
            return result;
        }


        public bool DeleteClient(int Id)
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
