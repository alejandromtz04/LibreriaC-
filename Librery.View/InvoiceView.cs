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

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("Id", "Numero");
                dataGridView1.Columns.Add("BranchAddress", "Lugar de venta");
                dataGridView1.Columns.Add("InvoiceDescription", "Descripcion");
                dataGridView1.Columns.Add("Quantity", "Cantidad");
                dataGridView1.Columns.Add("TotalAmount", "Monto total");
                dataGridView1.Columns.Add("InvoiceDate", "Fecha de facturacion");
                dataGridView1.Columns.Add("EmployeeName", "Nombre del vendedor");
                dataGridView1.Columns.Add("EmployeeLastName", "Apellido del vendedor");
                dataGridView1.Columns.Add("ClientName", "Nombre del comprador");
                dataGridView1.Columns.Add("ClientLastName", "Apellido del comprador");
                dataGridView1.Columns.Add("ProductName", "Producto");
                dataGridView1.Columns.Add("ProductCode", "Codigo de producto");
                dataGridView1.Columns.Add("ProductPrice", "Precio del producto");
                dataGridView1.Columns.Add("GuestName", "Consumidor no registrado");

                foreach (var invoice in invoices)
                {
                    dataGridView1.Rows.Add(
                            invoice.Id,
                            invoice.BranchAddress,
                            invoice.InvoiceDescription,
                            invoice.Quantity,
                            invoice.TotalAmount,
                            invoice.InvoiceDate,
                            
                            invoice.Employee?.EmployeeName ?? "",
                            invoice.Employee?.EmployeeLastName ?? "",

                            invoice.Client?.ClientName ?? "",
                            invoice.Client?.ClientLastName ?? "",

                            invoice.Product?.ProductName ?? "",
                            invoice.Product?.ProductCode ?? "",
                            invoice.Product?.ProductPrice ?? null,

                            invoice.GuestName

                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las facturas: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InvoiceCreateView invoiceCreateView = new InvoiceCreateView();
            invoiceCreateView.Show();
            this.Hide();
        }
    }
}
