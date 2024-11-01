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
    public partial class EmployeeModifyView : Form
    {
        private int employeeId;
        public EmployeeModifyView(int id, string employeeName, string employeeLastName, int employeeAge, string employeeEmail, string employeePhone, string employeeAddress)
        {
            InitializeComponent();

            employeeId = id;
            txtEmployeeName.Text = employeeName;
            txtEmployeeLastName.Text = employeeLastName;
            txtEmployeeAge.Text = employeeAge.ToString();
            txtEmployeeEmail.Text = employeeEmail;
            txtEmployeePhone.Text = employeePhone;
            txtEmployeeAddress.Text = employeeAddress;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeView employeeView = new EmployeeView();
            employeeView.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // MODIFY CHANGES
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeName.Text) ||
                string.IsNullOrWhiteSpace(txtEmployeeLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmployeeAge.Text) ||
                string.IsNullOrWhiteSpace(txtEmployeeEmail.Text) ||
                string.IsNullOrWhiteSpace(txtEmployeePhone.Text) ||
                string.IsNullOrWhiteSpace(txtEmployeeAddress.Text))
            {
                MessageBox.Show("Por favor ingrese los datos faltantes del Empleado");
                return;
            }

            var updateEmployee = new Employee
            {
                Id = employeeId,
                EmployeeName = txtEmployeeName.Text,
                EmployeeLastName = txtEmployeeLastName.Text,
                EmployeeAge = int.Parse(txtEmployeeAge.Text),
                EmployeeContact = new EmployeeContact
                {
                    EmployeeEmail = txtEmployeeEmail.Text,
                    EmployeePhone = txtEmployeePhone.Text,
                    EmployeeAddress = txtEmployeeAddress.Text
                }
            };

            EmployeeBL.Instance.UpdateEmployee(updateEmployee);

            EmployeeView employeeView = new EmployeeView();
            employeeView.Show();
            this.Close();
        }
    }
}
