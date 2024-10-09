using Libreria.DataAccess;
using Libreria.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.BussinessLogic
{
    public class ProductBL
    {
        private static ClientBL _instance;

        public static ClientBL Instance
        {
            get
            {
                return _instance ?? (_instance = new ClientBL());
            }
        }

        public bool CreateProduct(Product product, ProductCategory productCategory)
        {
            bool Result = false;
            try
            {
                Result = ProductDAL.Instance.CreateProduct(product, productCategory);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear Producto: " + ex.Message);
            }
            return Result;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> Result = null;
            try
            {
                Result = ProductDAL.Instance.GetAllProducts();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer la lista de Productos: " + ex.Message);
            }
            return Result;
        }

        public bool UpdateProduct(Product product, ProductCategory productCategory)
        {
            bool result = false;
            try
            {
                result = ProductDAL.Instance.UpdateProduct(product, productCategory);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar Producto: " + ex.Message);
            }
            return result;
        }

        public bool DeleteProduct(int Id)
        {
            bool result = false;
            try
            {
                result = ProductDAL.Instance.DeleteProduct(Id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar Producto: " + ex.Message);
            }
            return result;
        }
    }
}
