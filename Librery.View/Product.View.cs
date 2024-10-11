using Libreria.BussinessLogic;
using Libreria.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librery.View
{
    public partial class Producto : Form
    {
        private ProductBL productBl = ProductBL.Instance;
        public Producto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Producto_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                List<Product> products = productBl.GetAllProducts();

                dataGridView1.DataSource = products;

            }
            catch (Exception ex)
            {
                MessageBox.Show("error al cargar productos: " + ex.Message);
            }
        }
    }
}
