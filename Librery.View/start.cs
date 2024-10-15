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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductView productView = new ProductView();
            productView.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InvoiceView invoiceView = new InvoiceView();
            invoiceView.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClientView clientView = new ClientView();
            clientView.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmployeeView employeeView = new EmployeeView();
            employeeView.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
