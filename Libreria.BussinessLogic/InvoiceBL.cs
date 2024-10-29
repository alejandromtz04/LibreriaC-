﻿using Libreria.DataAccess;
using Libreria.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.BussinessLogic
{
    public class InvoiceBL
    {
        private static InvoiceBL _instance;

        public static InvoiceBL Instance
        {
            get
            {
                return _instance ?? (_instance = new InvoiceBL());
            }
        }

        public bool CreateInvoice(Invoice invoice, Employee employee, Client client, Product product)
        {
            bool Result = false;
            try
            {
                Result = InvoiceDAL.Instance.CreateInvoice(invoice, employee, client, product);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la Factura: " + ex.Message);
            }
            return Result;
        }

        public List<Invoice> GetAllInvoices()
        {
            List<Invoice> Result = null;
            try
            {
                Result = InvoiceDAL.Instance.GetAllInvoices();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer la lista de Facturas: " + ex.Message);
            }
            return Result;
        }

        public List<string> GetProductNames()
        {
            List<string> Result = null;
            try
            {
                Result = InvoiceDAL.Instance.GetProductNames();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer la lista de Productos: " + ex.Message);

            }
            return Result;
        }

        public List<string> GetEmployeeNames()
        {
            List<string> Result = null;
            try
            {
                Result = InvoiceDAL.Instance.GetEmployeeNames();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer la lista de Empleados: " + ex.Message);

            }
            return Result;
        }

        public List<string> GetClientNames()
        {
            List<string> Result = null;
            try
            {
                Result = InvoiceDAL.Instance.GetClientNames();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer la lista de Clientes: " + ex.Message);

            }
            return Result;
        }
    }
}
