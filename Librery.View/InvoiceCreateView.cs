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
    public partial class InvoiceCreateView : Form
    {
        private readonly InvoiceBL _invoiceBL;
        public InvoiceCreateView()
        {
            InitializeComponent();
            _invoiceBL = new InvoiceBL();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceCreateView_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadEmployees();
            LoadClients();
        }

        private void LoadProducts()
        {
            var productNames = _invoiceBL.GetProductNames();

            if (productNames.Count == 0)
            {
                MessageBox.Show("No hay productos disponibles para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                comboBoxProductList.Items.AddRange(productNames.ToArray());
            }
        }

        private void LoadEmployees()
        {
            var employeeNames = _invoiceBL.GetEmployeeNames();

            if (employeeNames.Count == 0)
            {
                MessageBox.Show("No hay empleados disponibles para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                comboBoxEmployeeName.Items.AddRange(employeeNames.ToArray());
            }
        }

        private void LoadClients()
        {
            var clientNames = _invoiceBL.GetClientNames();

            if (clientNames.Count == 0)
            {
                MessageBox.Show("No hay clientes disponibles para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                comboBoxClientName.Items.AddRange(clientNames.ToArray());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceView invoiceView = new InvoiceView();
            invoiceView.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxClientName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
