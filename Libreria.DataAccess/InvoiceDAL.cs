﻿using System;
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


        public bool CreateSale(Invoice invoice, Employee employee, Client client, Product product)
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