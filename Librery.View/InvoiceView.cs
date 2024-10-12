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
    public partial class InvoiceView : Form
    {
        public InvoiceView()
        {
            InitializeComponent();
        }

        private void InvoiceView_Load(object sender, EventArgs e)
        {
            GetListInvoices();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start start = new start();
            start.Show();
            this.Close();
        }

        private void GetListInvoices()
        {
            try
            {
                var invoices = InvoiceBL.Instance.GetAllInvoices();

                dataGridView1.DataSource = invoices;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las facturas: " + ex.Message);
            }
        }
    }
}
