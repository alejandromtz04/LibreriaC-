using Libreria.BussinessLogic;
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

namespace Librery.view
{
    public partial class EmployeeCreateView : Form
    {
        public EmployeeCreateView()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeName.Text) ||
                string.IsNullOrEmpty(txtEmployeeLastName.Text) ||
                string.IsNullOrEmpty(txtEmployeePhone.Text) ||
                string.IsNullOrWhiteSpace(numEmployeeAge.Text) ||
                string.IsNullOrWhiteSpace(txtEmployeeEmail.Text) ||
                string.IsNullOrWhiteSpace(txtEmployeeAddress.Text))
            {
                MessageBox.Show("Complete los campos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Employee employee = new Employee
            {
                EmployeeName = txtEmployeeName.Text,
                EmployeeLastName = txtEmployeeLastName.Text,
                EmployeeAge = int.Parse(numEmployeeAge.Text),
                State = true
            };

            EmployeeContact employeeContact = new EmployeeContact
            {
                EmployeeEmail = txtEmployeeEmail.Text,
                EmployeePhone = txtEmployeePhone.Text,
                EmployeeAddress = txtEmployeeAddress.Text,
                State = true
            };

            var result = EmployeeBL.Instance.CreateEmployee(employee, employeeContact);

            if (result != null)
            {
                MessageBox.Show("Colaborador Agregado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error al guardar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtEmployeeName.Clear();
            txtEmployeeLastName.Clear();
            numEmployeeAge.ResetText();
            txtEmployeeEmail.Clear();
            txtEmployeePhone.Clear();
            txtEmployeeAddress.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeView employeeView  = new EmployeeView();
            employeeView.Show();
            this.Hide();
        }
    }
}
