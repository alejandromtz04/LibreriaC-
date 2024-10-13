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
    public partial class ProductCreateView : Form
    {
        public ProductCreateView()
        {
            InitializeComponent();
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductView productView = new ProductView();
            productView.Show();
            this.Hide();
        }

        private void ProductCreateView_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text) ||
                string.IsNullOrEmpty(txtProductCode.Text) ||
                string.IsNullOrWhiteSpace(txtProductDescription.Text) ||
                string.IsNullOrWhiteSpace(txtProductPrice.Text) ||
                string.IsNullOrWhiteSpace(txtProductCategory.Text) ||
                string.IsNullOrWhiteSpace(numProductStock.Text))
            {
                MessageBox.Show("Complete los campos requeridos", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product product = new Product
            {
                ProductName = txtProductName.Text,
                ProductCode = txtProductCode.Text,
                ProductPrice = decimal.Parse(txtProductPrice.Text),
                ProductDescription = txtProductDescription.Text,
                State = true
            };

            ProductCategory productCategory = new ProductCategory
            {
                ProductCategoryName = txtProductCategory.Text,
                ProductStock = int.Parse(numProductStock.Text),
                State = true
            };

            var result = ProductBL.Instance.CreateProduct(product, productCategory);

            if (result != null)
            {
                MessageBox.Show("Producto agregado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error al guardar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtProductName.Clear();
            txtProductCode.Clear();
            txtProductPrice.Clear();
            txtProductDescription.Clear();
            txtProductCategory.Clear();
            numProductStock.ResetText();
        }
    }
}
