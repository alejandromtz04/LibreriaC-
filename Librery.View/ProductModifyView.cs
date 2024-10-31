using Libreria.BussinessLogic;
using Libreria.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librery.view
{
    public partial class ProductModifyView : Form
    {
        private int productId;
        public ProductModifyView(int id, string productName, string productCode, string productDescription, decimal productPrice, string productCategory, int productStock)
        {
            InitializeComponent();

            productId = id;
            txtProductName.Text = productName;
            txtProductCode.Text = productCode;
            txtProductDescription.Text = productDescription;
            txtProductPrice.Text = productPrice.ToString();
            txtProductCategory.Text = productCategory;
            numProductStock.Value = productStock;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductView productView = new ProductView();
            productView.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // modify cahnges
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtProductCode.Text) ||
                string.IsNullOrWhiteSpace(txtProductDescription.Text) ||
                string.IsNullOrWhiteSpace(txtProductPrice.Text) ||
                string.IsNullOrWhiteSpace(txtProductCategory.Text) ||
                numProductStock.Value <= 0) 
            {
                MessageBox.Show("Por favor ingrese los datos faltantes del cliente.");
                return;
            }

            decimal productPrice;
            if (!decimal.TryParse(txtProductPrice.Text, out productPrice))
            {
                MessageBox.Show("Por favor, ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var updateProduct = new Product
            {
                Id = productId,
                ProductName = txtProductName.Text,
                ProductCode = txtProductCode.Text,
                ProductDescription = txtProductDescription.Text,
                ProductPrice = productPrice,
                ProductCategory = new ProductCategory
                {
                    ProductCategoryName = txtProductCategory.Text,
                    ProductStock = Convert.ToInt32(numProductStock.Value)
                }
            };

            ProductBL.Instance.UpdateProduct(updateProduct);

            ProductView productView = new ProductView();
            productView.Show();
            this.Close();
        }
    }
}
