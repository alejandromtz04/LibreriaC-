using Libreria.BussinessLogic;
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
    public partial class ProductView : Form
    {
        public ProductView()
        {
            InitializeComponent();
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            GetProductList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start start = new start();
            start.Show();
            this.Hide();
        }

        private void GetProductList()
        {
            try
            {
                var products = ProductBL.Instance.GetAllProducts();

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("Id", "Numero");
                dataGridView1.Columns.Add("ProductName", "Nombre del Producto");
                dataGridView1.Columns.Add("ProductCode", "Codigo");
                dataGridView1.Columns.Add("ProductDescription", "Descripcion");
                dataGridView1.Columns.Add("ProductPrice", "Precio");

                dataGridView1.Columns.Add("ProductCategoryName", "Categoria");
                dataGridView1.Columns.Add("ProductStock", "Existencias");

                foreach(var product in products)
                {
                    dataGridView1.Rows.Add(
                            product.Id,
                            product.ProductName,
                            product.ProductCode,
                            product.ProductDescription,
                            product.ProductPrice,
                            product.ProductCategory?.ProductCategoryName ?? "",
                            product.ProductCategory?.ProductStock ?? null
                        );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductCreateView productCreateView = new ProductCreateView();
            productCreateView.Show();
            this.Hide();
        }
    }
}
