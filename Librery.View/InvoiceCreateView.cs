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
using Libreria.Entity;
using System.Drawing.Text;

namespace Librery.view
{
    public partial class InvoiceCreateView : Form
    {
        private readonly InvoiceBL _invoiceBL;
        private List<Product> _Products;
        private List<Employee> _Employees;
        private List<Client> _clients;
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
            var products = _invoiceBL.GetProducts();

            if (products == null || products.Count == 0)
            {
                MessageBox.Show("No hay productos disponibles para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                comboBoxProductList.DataSource = products; // Asignar la lista de productos
                comboBoxProductList.DisplayMember = "ProductName"; // Propiedad a mostrar
                comboBoxProductList.ValueMember = "Id"; // Propiedad que se usará como valor
                comboBoxProductList.SelectedIndex = -1; // Deselecciona cualquier opción
            }
        }

        private void LoadEmployees()
        {
            var employees = _invoiceBL.GetEmployeeNames();

            if (employees == null || employees.Count == 0)
            {
                MessageBox.Show("No hay empleados disponibles para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                comboBoxEmployeeName.DataSource = employees; // Asignar la lista de empleados
                comboBoxEmployeeName.DisplayMember = "EmployeeName"; // Propiedad a mostrar
                comboBoxEmployeeName.ValueMember = "Id"; // Propiedad que se usará como valor
                comboBoxEmployeeName.SelectedIndex = -1; // Deselecciona cualquier opción
            }
        }


        private void LoadClients()
        {
            var clients = _invoiceBL.GetClientNames();

            if (clients == null || clients.Count == 0)
            {
                MessageBox.Show("No hay clientes disponibles para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                comboBoxClientName.DataSource = clients; // Asignar la lista de clientes
                comboBoxClientName.DisplayMember = "ClientName"; // Propiedad a mostrar
                comboBoxClientName.ValueMember = "Id"; // Propiedad que se usará como valor
                comboBoxClientName.SelectedIndex = -1; // Deselecciona cualquier opción
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

        private void button2_Click(object sender, EventArgs e) // SAVE BUTTON
        {
            if (comboBoxProductList.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica si hay un empleado seleccionado
            if (comboBoxEmployeeName.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona un empleado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica si hay un cliente seleccionado
            if (comboBoxClientName.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productId = (int)comboBoxProductList.SelectedValue;
            int quantity = int.Parse(numQuantity.Text);



            decimal totalAmount = _invoiceBL.CalculateTotal(productId, quantity);

            var invoice = new Invoice
            {
                BranchAddress = txtBranchAddress.Text,
                InvoiceDescription = txtDescription.Text,
                Quantity = int.Parse(numQuantity.Text),
                TotalAmount = totalAmount,
                InvoiceDate = DateTime.Now, // O el valor adecuado según tu lógica
                Employee = new Employee { Id = (int)comboBoxEmployeeName.SelectedValue },
                Client = new Client { Id = (int)comboBoxClientName.SelectedValue },
                Product = new Product { Id = (int)comboBoxProductList.SelectedValue },
                GuestName = txtGuestName.Text // Suponiendo que tienes un TextBox para el nombre del invitado
            };

            bool isSaved = _invoiceBL.CreateInvoice(invoice);

            if (isSaved)
            {
                MessageBox.Show("Factura creada exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show("Hubo un error al crear la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
