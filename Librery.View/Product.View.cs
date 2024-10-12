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

<<<<<<< HEAD
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
=======
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
>>>>>>> 5673a18f2b4901f95c9c78a79b8c0fea50cb211b
            }
        }
    }
}
