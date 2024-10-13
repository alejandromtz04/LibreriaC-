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

                dataGridView1.DataSource = products;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
