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

namespace Librery.View
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client clientForm = new Client();
            clientForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee employeeForm = new Employee();
            employeeForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Invoce InvoceForm = new Invoce();
            InvoceForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Producto ProductoForm = new Producto();
            ProductoForm.ShowDialog();
        }
    }
}
