using Libreria.DataAccess;
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

        public bool CreateInvoice(Invoice invoice)
        {
            if (!ProductDAL.Instance.CheckIfProductExists(invoice.Product.Id))
            {
                throw new Exception("El producto no existe.");
            }

            int stock = ProductDAL.Instance.GetProductStock(invoice.Product.Id);

            if (stock <= 0)
            {
                throw new Exception("El producto no tiene stock disponible.");
            }

            bool result = false;
            try
            {
                result = InvoiceDAL.Instance.CreateInvoice(invoice);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la factura: " + ex.Message);
            }
            return result;
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

        public List<Product> GetProducts()
        {
            try
            {
                return InvoiceDAL.Instance.GetProducts();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer la lista de Productos: " + ex.Message);

            }
        }

        public List<Employee> GetEmployeeNames()
        {
            try
            {
                return InvoiceDAL.Instance.GetEmployees();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer la lista de Empleados: " + ex.Message);

            }
        }

        public List<Client> GetClientNames()
        {

            try
            {
                return InvoiceDAL.Instance.GetClients();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer la lista de Clientes: " + ex.Message);

            }
        }

        public decimal CalculateTotal(int productId, int quantity)
        {

            if (quantity < 0)
            {
                throw new ArgumentException("La cantidad no puede ser negativa.");
            }

            decimal productPrice = InvoiceDAL.Instance.GetProductPrice(productId);

            if (productPrice < 0)
            {
                throw new InvalidOperationException("El precio del producto no puede ser negativo.");
            }

            return productPrice * quantity;
        }
        /*
        public bool CheckProductStock(int productId, int quantity)
        {
            // Obtener el producto del DAL
            var product = InvoiceDAL.Instance.GetProductById(productId);
            if (product != null)
            {
                // Verificar si hay suficiente stock
                return product.ProductStock >= quantity; // Asumiendo que ProductStock es la propiedad que contiene el stock disponible
            }
            return false; // Producto no encontrado o sin stock
        }
        */
    }
}
